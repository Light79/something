using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var db = new ManageDbContext();
            var model = db.Users.ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {

                var dao = new UserDAO();
                int id = dao.Insert(user);

                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm user không thành công!");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = new UserDAO();
            User editUser = user.GetById(id);
            return View(editUser);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {

                var dao = new UserDAO();
                var result = dao.Edit(user);

                if (result != null)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật user không thành công!");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var dao = new UserDAO();
            dao.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var org = new UserDAO().GetById(id);
            return View(org);
        }
    }
}