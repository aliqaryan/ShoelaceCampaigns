using ShoelaceCampaigns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace ShoelaceCampaigns
{
    public interface IServices
    {
        List<UserProduct> GetAllUserProducts();
        List<string> GetTemplates();
        List<string> GetStatusOptions();
    }


    public class Services : IServices
    {
        public List<UserProduct> GetAllUserProducts()
        {
            string responseBody = string.Empty;
            List<UserProduct> responseObj = new List<UserProduct>();
            using (WebClient wc = new WebClient())
            {
                responseBody = wc.DownloadString("https://shoelace-dev-test.azurewebsites.net/api/UserProducts");
            }
            responseObj = JsonConvert.DeserializeObject<List<UserProduct>>(responseBody);
            return responseObj;
        }

        public List<string> GetTemplates()
        {
            List<string> result = new List<string>();
            var values = Enum.GetValues(typeof(TemplateNames));
            foreach (var item in values)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public List<string> GetStatusOptions()
        {
            List<string> result = new List<string>();
            var values = Enum.GetValues(typeof(CampaignStatus));
            foreach (var item in values)
            {
                result.Add(item.ToString());
            }
            return result;
        }

    }


}
