namespace DMNSN.Clients.ProxmoxVE.Models.Proxmox
{
    public enum IndicateType
    {
        cluster,
        node
    }

    public class ClusterStatusModel
    {
        public string id { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        /// <summary>
        /// Indicates the type, either cluster or node. The type defines the object properties e.g. quorate available for type cluster.
        /// </summary>
        public IndicateType type { get; set; }
        /// <summary>
        /// [node] IP of the resolved nodename.
        /// </summary>
        public string? ip { get; set; }
        /// <summary>
        /// [node] Proxmox VE Subscription level, indicates if eligible for enterprise support as well as access to the stable Proxmox VE Enterprise Repository.
        /// </summary>
        public string? level { get; set; }
        /// <summary>
        /// [node] Indicates if this is the responding node.
        /// </summary>
        public bool? local { get; set; }
        /// <summary>
        /// [node] ID of the node from the corosync configuration.
        /// </summary>
        public int? nodeid { get; set; }
        /// <summary>
        /// [cluster] Nodes count, including offline nodes.
        /// </summary>
        public int? nodes { get; set; }
        /// <summary>
        /// [node] Indicates if the node is online or offline.
        /// </summary>
        public bool? online { get; set; }
        /// <summary>
        /// [cluster] Indicates if there is a majority of nodes online to make decisions
        /// </summary>
        public bool? quorate { get; set; }
        /// <summary>
        /// [cluster] Current version of the corosync configuration file.
        /// </summary>
        public int? version { get; set; }
    }
}
