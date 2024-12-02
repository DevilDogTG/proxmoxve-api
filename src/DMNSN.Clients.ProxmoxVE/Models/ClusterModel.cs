namespace DMNSN.Clients.ProxmoxVE.Models
{
    public class ClusterModel
    {
        public string Name { get; set; } = string.Empty;
        public int Version { get; set; }
        public int NodesCount { get; set; }
        public bool Quorate { get; set; }
        public List<NodeModel> Nodes { get; set; } = [];
    }
}
