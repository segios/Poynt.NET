using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public static class PEMToRSA
    {
        const string KEY_HEADER = "-----BEGIN RSA PRIVATE KEY-----";
        const string KEY_FOOTER = "-----END RSA PRIVATE KEY-----";

        public static RSACryptoServiceProvider GetRSAProvider(string pem)
        {
            try
            {
                RSACryptoServiceProvider rsaPK = GetRSA(pem);


                return rsaPK;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static RSACryptoServiceProvider GetRSA(string pem)
        {
            RSACryptoServiceProvider rsa = null;

            if (IsPrivateKeyAvailable(pem))
            {
                RSAParameters privateKey = DecodeRSAPrivateKey(pem);

                rsa = new RSACryptoServiceProvider();
               rsa.ImportParameters(privateKey);
            }

            return rsa;
        }

        private static bool IsPrivateKeyAvailable(string privateKeyInPEM)
        {
            return (privateKeyInPEM != null && privateKeyInPEM.Contains(KEY_HEADER)
                && privateKeyInPEM.Contains(KEY_FOOTER));
        }

        private static RSAParameters DecodeRSAPrivateKey(string privateKeyInPEM)
        {
            if (IsPrivateKeyAvailable(privateKeyInPEM) == false)
                throw new ArgumentException("bad format");

            string keyFormatted = privateKeyInPEM;

            int cutIndex = keyFormatted.IndexOf(KEY_HEADER);
            keyFormatted = keyFormatted.Substring(cutIndex, keyFormatted.Length - cutIndex);
            cutIndex = keyFormatted.IndexOf(KEY_FOOTER);
            keyFormatted = keyFormatted.Substring(0, cutIndex + KEY_FOOTER.Length);
            keyFormatted = keyFormatted.Replace(KEY_HEADER, "");
            keyFormatted = keyFormatted.Replace(KEY_FOOTER, "");
            keyFormatted = keyFormatted.Replace("\r", "");
            keyFormatted = keyFormatted.Replace("\n", "");
            keyFormatted = keyFormatted.Trim();

            byte[] privateKeyInDER = System.Convert.FromBase64String(keyFormatted);

            byte[] paramModulus;
            byte[] paramDP;
            byte[] paramDQ;
            byte[] paramIQ;
            byte[] paramE;
            byte[] paramD;
            byte[] paramP;
            byte[] paramQ;

            MemoryStream memoryStream = new MemoryStream(privateKeyInDER);
            BinaryReader binaryReader = new BinaryReader(memoryStream);

            ushort twobytes = 0;
            int elements = 0;
            byte bt = 0;

            try
            {
                twobytes = binaryReader.ReadUInt16();
                if (twobytes == 0x8130)
                    binaryReader.ReadByte();
                else if (twobytes == 0x8230)
                    binaryReader.ReadInt16();
                else
                    throw new CryptographicException("Wrong data");

                twobytes = binaryReader.ReadUInt16();
                if (twobytes != 0x0102)
                    throw new CryptographicException("Wrong data");

                bt = binaryReader.ReadByte();
                if (bt != 0x00)
                    throw new CryptographicException("Wrong data");

                elements = GetIntegerSize(binaryReader);
                paramModulus = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramE = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramD = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramP = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramQ = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramDP = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramDQ = binaryReader.ReadBytes(elements);

                elements = GetIntegerSize(binaryReader);
                paramIQ = binaryReader.ReadBytes(elements);

                EnsureLength(ref paramD, 256);
                EnsureLength(ref paramDP, 128);
                EnsureLength(ref paramDQ, 128);
                EnsureLength(ref paramE, 3);
                EnsureLength(ref paramIQ, 128);
                EnsureLength(ref paramModulus, 256);
                EnsureLength(ref paramP, 128);
                EnsureLength(ref paramQ, 128);

                RSAParameters rsaParameters = new RSAParameters();
                rsaParameters.Modulus = paramModulus;
                rsaParameters.Exponent = paramE;
                rsaParameters.D = paramD;
                rsaParameters.P = paramP;
                rsaParameters.Q = paramQ;
                rsaParameters.DP = paramDP;
                rsaParameters.DQ = paramDQ;
                rsaParameters.InverseQ = paramIQ;

                return rsaParameters;
            }
            finally
            {
                binaryReader.Close();
            }
        }

        private static int GetIntegerSize(BinaryReader binary)
        {
            byte bt = 0;
            byte lowbyte = 0x00;
            byte highbyte = 0x00;
            int count = 0;

            bt = binary.ReadByte();

            if (bt != 0x02)
                return 0;

            bt = binary.ReadByte();

            if (bt == 0x81)
                count = binary.ReadByte();
            else if (bt == 0x82)
            {
                highbyte = binary.ReadByte();
                lowbyte = binary.ReadByte();
                byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                count = BitConverter.ToInt32(modint, 0);
            }
            else
                count = bt;

            while (binary.ReadByte() == 0x00)
                count -= 1;

            binary.BaseStream.Seek(-1, SeekOrigin.Current);

            return count;
        }

        private static void EnsureLength(ref byte[] data, int desiredLength)
        {
            if (data == null || data.Length >= desiredLength)
                return;

            int zeros = desiredLength - data.Length;

            byte[] newData = new byte[desiredLength];
            Array.Copy(data, 0, newData, zeros, data.Length);

            data = newData;
        }
    }
}
