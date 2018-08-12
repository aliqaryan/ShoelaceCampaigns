using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoelaceCampaigns.Models
{
    public class Campaign
    {
        public Campaign()
        {
            CampaignTemplate = new Template();
            Title = CampaignTemplate.Title;
            AdCopy = CampaignTemplate.AdCopy;
            CampaignObjective = CampaignTemplate.CampaignObjective;
            Status = CampaignStatus.Paused;
            AdNetworkId = string.Empty;
            Image = new List<string>();
        }

        public Template CampaignTemplate { get; set; }

        public List<string> Title { get; set; }

        public List<string> AdCopy { get; set; }

        public string CampaignObjective { get; set; }

        public List<string> Image { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CampaignStatus Status { get; set; }

        public string AdNetworkId { get; set; }

        public bool SaveAndPublish()
        {
            // Save Campaign on db or file or by another service
            var jsonstring = JsonConvert.SerializeObject(this);
            if (new FileInfo(@"c:\logs\campaign.json").Length != 0)
                jsonstring = "," + jsonstring;
            File.AppendAllText(@"c:\logs\campaign.json", jsonstring + Environment.NewLine);
           
            // Publish to social medi like Facebook 

            return true;
        }




    }

    public enum CampaignStatus
    {
        None,
        Paused,
        Implemented
    }



}
