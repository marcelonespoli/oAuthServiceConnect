namespace OAuthServiceConnect.Models
{
    public class OauthConfig
    {
        [ConfigurationKeyName("client_id")]
        public string ClientId { get; set; }

        [ConfigurationKeyName("app_secret")]
        public string AppSecret { get; set; }

        [ConfigurationKeyName("redirect_uri")]
        public string RedirectUri { get; set; }

        [ConfigurationKeyName("version")]
        public string Version { get; set; }     
    }
}
