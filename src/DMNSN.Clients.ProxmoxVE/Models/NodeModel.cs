namespace DMNSN.Clients.ProxmoxVE.Models
{
    public class NodeModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int NodeId { get; set; }
        public bool IsOnline { get; set; }
    }
}
