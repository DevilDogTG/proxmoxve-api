using Microsoft.Extensions.Logging;

namespace DMNSN.Clients.ProxmoxVE
{
    public class PveClient
    {
        private readonly ILogger<PveClient> logger;
        private readonly PveClientOptions options;

        public PveClient(ILogger<PveClient> _logger, PveClientOptions _options)
        {
            logger = _logger;
            options = _options ?? throw new ArgumentNullException(nameof(_options));
        }
    }
}
