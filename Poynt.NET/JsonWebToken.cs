using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Poynt.NET.Exceptions;

namespace Poynt.NET
{
    public class JsonWebToken
    {
        private ClientConfig clientConfig;
        private Config config;
        private JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        public JsonWebToken(Config config, ClientConfig clientConfig)
        {
            this.config = config;
            this.clientConfig = clientConfig;
        }

        public JwtSecurityToken GetJwtToken()
        {
            if (string.IsNullOrEmpty(clientConfig.KeyFileData))
            {
                throw new PoyntSDKException("RSA Key not initlized");
            }

            var rsaProvider = PEMToRSA.GetRSAProvider(clientConfig.KeyFileData);
            var key = new RsaSecurityKey(rsaProvider);

            var now = DateTime.UtcNow;

            var token = jwtSecurityTokenHandler.CreateJwtSecurityToken(
                clientConfig.AppId,
                config.ApiHost, 
                GetClaimsIdentity(), 
                null,
                now.AddMinutes(15),
                now, new SigningCredentials(key, SecurityAlgorithms.RsaSha256));
            
            return token;
        }

        public string EncodeJwtToken(JwtSecurityToken token)
        {
            return jwtSecurityTokenHandler.WriteToken(token);
        }

        public string GetEncodedJwtToken()
        {
            var token = GetJwtToken();
            return jwtSecurityTokenHandler.WriteToken(token);
        }

        private ClaimsIdentity GetClaimsIdentity()
        {
            var claimsIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim("sub", clientConfig.AppId),
                }, "Custom");

            return claimsIdentity;
        }

    }
}
