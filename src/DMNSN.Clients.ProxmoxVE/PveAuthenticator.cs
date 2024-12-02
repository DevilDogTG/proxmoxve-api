using RestSharp;
using RestSharp.Authenticators;

namespace DMNSN.Clients.ProxmoxVE
{
    public class PveAuthenticator : IAuthenticator
    {
        private readonly PveClientOptions options;
        public PveAuthenticator(PveClientOptions _options)
        {
            options = _options ?? throw new ArgumentNullException(nameof(_options));
        }

        public ValueTask Authenticate(IRestClient client, RestRequest request)
        {
            var token = $"PVEAPIToken={options.UserName}!{options.TokenName}={options.TokenValue}";
            request.AddHeader("Authorization", token);
            return ValueTask.CompletedTask;
        }
    }
}
