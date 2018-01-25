using Group1.Common;
using Group1.Models;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserDAO dao = new UserDAO();
                
                var result = dao.Login(model.Account, model.Password);
                if (result == 1)
                {
                    var acc = dao.getAccount(model.Account);
                    var accountSession = new UserLogin();

                    accountSession.Account = acc.Account;

                    Session.Add(CommonConstants.ACCOUNT_SESSION, accountSession);

                    return RedirectToAction("Index", "Organisantion");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại!");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Sai thông tin tài khoản hoặc mật khẩu!");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng!");
                }
            }
            return View("Index");
        }
    }
}