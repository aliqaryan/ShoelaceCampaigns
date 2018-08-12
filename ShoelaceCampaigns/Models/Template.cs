using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoelaceCampaigns.Models
{
    public class Template
    {

        public TemplateNames TemplateName { get; set; }
        public List<string> Title { get; set; }
        public List<string> AdCopy { get; set; }
        public string CampaignObjective { get; set; }
        public Template(TemplateNames template = TemplateNames.SingleImageAd)
        {
            LoadTemplate(template);
        }

        private void LoadTemplate(TemplateNames template)
        {
            switch (template)
            {
                case TemplateNames.SingleImageAd:
                    TemplateName = TemplateNames.SingleImageAd;
                    Title = new List<string>() { "Default Title" };
                    AdCopy = new List<string>() { "Default Text" };
                    CampaignObjective = "LeadGeneration";
                    break;
                case TemplateNames.MultiImageCarouselAd:
                    TemplateName = TemplateNames.MultiImageCarouselAd;
                    Title = new List<string>() { "Default Title 1", "Default Title 2", "Default Title 3" };
                    AdCopy = new List<string>() { "Default Text1", "Default Text2", "Default Text3" };
                    CampaignObjective = "Conversions";
                    break;
                case TemplateNames.MultiImageSliderAd:
                    TemplateName = TemplateNames.MultiImageSliderAd;
                    Title = new List<string>() { "Default Title 1", "Default Title 2", "Default Title 3" };
                    AdCopy = new List<string>() { "Default Text1", "Default Text2", "Default Text3" };
                    CampaignObjective = "Impressions";
                    break;
                default:
                    break;
            }
        }

    }

    public enum TemplateNames
    {
        SingleImageAd,
        MultiImageCarouselAd,
        MultiImageSliderAd
    }
}
