using System.Web.Mvc;
using System.Web.Optimization;

namespace Conpak.Sam.Areas.Customer
{
    public class CustomerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Customer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Customer_default",
                "Customer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "Conpak.Sam.Areas.Customer.Controllers" }
            );

            RegisterBundles(BundleTable.Bundles);
        }

        public void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/customer/scripts")
                .IncludeDirectory("~/Areas/Customer/Scripts","*.js"));
        }
    }
}