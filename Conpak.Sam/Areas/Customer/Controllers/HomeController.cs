using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Web;
using System.Web.Mvc;
using Conpak.Core.Data;
using Conpak.Core.Models.Domain;
using Conpak.Core.Queries;
using Conpak.Core.Repositories;
using Dapper;

namespace Conpak.Sam.Areas.Customer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private DataContext Context;
        public HomeController()
        {
            Context =new DataContext();
        }
        // GET: Customer/Home
        [Authorize(Roles="Admin")]
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult List(string format = "html")
        {
            ViewData.Model = DateTime.Now;
            var id = Guid.Parse("eaedcbbe-1246-47b1-8881-f21c67c89c5b");
            //var customers = Conpak.Core.Models.Domain.Customer.Get(Context,Guid.Parse("eaedcbbe-1246-47b1-8881-f21c67c89c5b"));
            //var customers = Context.Get<Conpak.Core.Models.Domain.Customer>(id);
            //var repo = new CustomerRepository(Context);
            //var customers = repo.Get(id);

            var query = new ComplexCustomerQuery(Context);

            if (1 == 1)
            {
                query.Id = id;
            }
            var customers = query.Get();


                if (format == "json")
                {
                    return Json( new[]{customers}, JsonRequestBehavior.AllowGet);
                } 
            

            return PartialView();
        }


    }
}