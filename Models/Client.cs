namespace BaptisteIdentityServer.Models
{
    public class Client
    {
        public string ClientId { get; set;}
        public string ClientSecret { get; set;}
        public List<string> AllowedScopes { get; set; }
        
    }
}
