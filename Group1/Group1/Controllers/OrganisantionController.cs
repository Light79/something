using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group1.Controllers
{
    public class OrganisantionController : Controller
    {
        // GET: Organisantion
        public ActionResult Index()
        {
            var db = new ManageDbContext();
            var model = db.Org_Add_View.ToList();
            return View(model);
        }

        //public ActionResult Detail()
        //{
            
        //}

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Organisantion org)
        {
            if (ModelState.IsValid)
            {

                var dao = new OrganisantionDAO();
                int id = dao.Insert(org);

                if (id > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm org không thành công!");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var org = new OrganisantionDAO();
            Organisantion editOrg = org.GetById(id);
            return View(editOrg);
        }

        [HttpPost]
        public ActionResult Edit(Organisantion org)
        {
            if (ModelState.IsValid)
            {

                var dao = new OrganisantionDAO();
                var result = dao.Edit(org);


                if (result != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật user không thành công!");
                }
            }
            return View("Index");
        }
        
        public ActionResult Delete(int id)
        {
            var dao = new OrganisantionDAO();
            dao.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var org = new OrganisantionDAO().GetById(id);
            return View(org);
        }
    }
}