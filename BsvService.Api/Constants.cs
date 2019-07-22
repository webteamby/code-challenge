﻿namespace BsvService.Api
{
    public static class Constants
    {
        public static class Settings
        {
            public static string AllowedOrigins => "allowed-origins";

            public static string LiteDbPath => "LiteDb.Path";

            public static class Auth
            {
                public static string Issuer => "oauth2:issuer";
                public static string Audience => "oauth2:audience";
                public static string CertThumbprint => "oauth2:cert-thumbprint";
            }
        }
    }
}
