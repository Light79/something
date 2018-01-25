using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group1.Controllers
{
    public class SupportingMaterialsController : Controller
    {
        // GET: SupportingMaterials
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SupportingMaterial sup)
        {
            if (ModelState.IsValid)
            {
                var dao = new SupportingMaterialsDAO();
                int id = dao.Insert(sup);
                if(id > 0)
                    return RedirectToAction("Index", "Organisantion");
                else
                    ModelState.AddModelError("", "Thêm sup không thành công!");
            }
            return View("Index");
        }
    }
}