namespace DMNSN.Clients.ProxmoxVE
{
    public class PveClientOptions
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string TokenName { get; set; } = string.Empty;
        public string TokenValue { get; set; } = string.Empty;
    }
}
