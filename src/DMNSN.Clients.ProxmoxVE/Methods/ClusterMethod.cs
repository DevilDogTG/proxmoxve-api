using DMNSN.Clients.ProxmoxVE.Constraints;
using DMNSN.Clients.ProxmoxVE.Models.Proxmox;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;

namespace DMNSN.Clients.ProxmoxVE.Methods
{
    public class ClusterMethod
    {
        private readonly ILogger<ClusterMethod> logger;
        private readonly PveClientOptions options;

        public ClusterMethod(ILogger<ClusterMethod> _logger, PveClientOptions _options)
        {
            logger = _logger;
            options = _options ?? throw new ArgumentNullException(nameof(_options));
        }

        public async Task<ClusterStatusModel?> GetClusterAsync()
        {
            var client = new RestClient(new RestClientOptions
            {
                BaseUrl = new Uri(options.BaseUrl),
                Authenticator = new PveAuthenticator(options)
            });

            var request = new RestRequest(Paths.ClusterStatus, Method.Get);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                logger.LogInformation($"Cluster information: {response.Content}");
                return JsonConvert.DeserializeObject<ClusterStatusModel>(response.Content);
            }
            else
            {
                logger.LogError($"Failed to get cluster information: {response.Content}");
                return null;
            }
        }
    }
}
