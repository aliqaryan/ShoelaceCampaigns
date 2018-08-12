using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoelaceCampaigns.Models
{
    public class CampaignViewModel
    {
        public CampaignViewModel()
        {
            TemplateName = string.Empty;
            Title = string.Empty;
            AdCopy = string.Empty;
            CampaignObjective = string.Empty;
            Image = string.Empty;
            Status = string.Empty;
            AdNetworkId = string.Empty;
        }

        public string TemplateName { get; set; }

        public string Title { get; set; }

        public string AdCopy { get; set; }

        public string CampaignObjective { get; set; }

        public string Image { get; set; }

        public string Status { get; set; }

        public string AdNetworkId { get; set; }
    }
}
