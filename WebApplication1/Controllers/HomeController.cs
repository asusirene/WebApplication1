using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Account()
        {
            string[] categoryArray = new string[] { "收入", "支出" };
            //塞入資料
            Random rnd = new Random();
            List<AccountViewModel> accountModelList = new List<AccountViewModel>();
            for (int i = 0; i <= 100; i++)
            {
                AccountViewModel accountModel = new AccountViewModel();
                accountModel.Category = categoryArray[rnd.Next(0, 2)];
                accountModel.LogDate = DateTime.Now.AddDays(rnd.Next(99));
                accountModel.Money = rnd.Next(1, 9999);
                accountModelList.Add(accountModel);
            }
            return View(accountModelList);
        }
    }
}