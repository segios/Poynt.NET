# Poynt.NET
.NET Library for Poynt API 

Config is loading from a file "poynt.configuration\poyntClientSDKConfig.json"
Folder "poynt.configuration" should contain PEM file with your app's keys.

Config sample "poyntClientSDKConfig.json"

```c#

{
"businessId": "11111111-1111-1111-111-111111111111",
  "clientConfigs": {
    "test": {
      "name": "test",
      "appId": "urn:aid:11111111-1111-1111-111-111111111111",
      "keyFile": "test_urn_aid_11111111-1111-1111-111-111111111111_publicprivatekey.pem",
      "secret": "|B?LVZQAVl7Z:L5yHCT9",
      "isActive": true
    }
  }
}

// 'secret' is used to setup webhooks secret
```
