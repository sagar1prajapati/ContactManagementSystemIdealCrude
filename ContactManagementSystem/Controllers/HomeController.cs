using ContactManagementSystem.Interfaces;
using ContactManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _managePersonService;
        public HomeController(IPersonService managePersonService)
        {
            _managePersonService = managePersonService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult List()
        {
            var result = _managePersonService.List();
            var jsonResult = Json(result, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }
        [HttpPost]
        public JsonResult Add(PersonContact_VM personContact_VM)
        {
            var result = _managePersonService.Add(personContact_VM);
            var jsonResult = Json(result, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }
        [HttpPost]
        public JsonResult Edit(PersonContact_VM personContact_VM)
        {
            var result = _managePersonService.Edit(personContact_VM);
            var jsonResult = Json(result, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }
        [HttpPost]
        public JsonResult Delete(Int64 ID)
        {
            var result = _managePersonService.Delete(ID);
            var jsonResult = Json(result, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }
    }
}