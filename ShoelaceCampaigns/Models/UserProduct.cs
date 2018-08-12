using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShoelaceCampaigns.Models
{
    public class UserProduct
    {
        public UserProduct()
        {
            Name = string.Empty;
            Description = string.Empty;
            Price = decimal.Zero;
            Image = string.Empty;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }


      

    }
}
