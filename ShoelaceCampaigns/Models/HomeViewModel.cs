using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoelaceCampaigns.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            TemplateOptions = new List<string>();
            Products = new List<UserProduct>();
            StatusOptions = new List<string>();


        }
        public List<string> TemplateOptions { get; set; }
        public List<UserProduct> Products { get; set; }
        public List<string> StatusOptions { get; set; }



    }
}
