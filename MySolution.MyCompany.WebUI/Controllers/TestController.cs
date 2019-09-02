using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySolution.MyCompany.Bussiness.Interface;
using MySolution.MyCompany.Bussiness.Service;

namespace MySolution.MyCompany.WebUI.Controllers
{
    public class TestController : Controller
    {
        private ITestService _testService;

        public TestController(TestService testService)
        {
            _testService = testService;
        }
        // GET: Test
        public ActionResult Index()
        {
            var test = _testService.GetName();

            if(test.HasError)
            {

            }

            ViewBag.Test = _testService.GetName().Entity;
            return View();
        }
    }
}