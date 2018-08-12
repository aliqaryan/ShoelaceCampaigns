using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoelaceCampaigns.Models;

namespace ShoelaceCampaigns.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServices _services;
        public HomeController(IServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.TemplateOptions = _services.GetTemplates();
            vm.StatusOptions = _services.GetStatusOptions();
            var products = _services.GetAllUserProducts();
            products.Insert(0, new UserProduct());
            vm.Products = products;
            return View(vm);
        }

        [HttpGet]
        public JsonResult GetTemplateInfo(string template)
        {
            Template templateObj = new Template((TemplateNames)Enum.Parse(typeof(TemplateNames), template));
            return Json(templateObj);
        }

        [HttpPost]
        public JsonResult SaveCampaign(CampaignViewModel campaignVm)
        {
            Campaign campaign = new Campaign()
            {
                AdCopy = campaignVm.AdCopy.Split(',').ToList(),
                AdNetworkId = campaignVm.AdNetworkId,
                CampaignObjective = campaignVm.CampaignObjective,
                CampaignTemplate = new Template((TemplateNames)Enum.Parse(typeof(TemplateNames), campaignVm.TemplateName)),
                Image = campaignVm.Image.Split(',').ToList(),
                Status = (CampaignStatus)Enum.Parse(typeof(CampaignStatus), campaignVm.Status),
                Title = campaignVm.Title.Split(',').ToList()
            };
            var result = campaign.SaveAndPublish();
            return Json(result == true ? "true" : "false");
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
