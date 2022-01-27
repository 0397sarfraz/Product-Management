using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Controllers
{
    public class AccountController : Controller
    {
        private AccountContext _accontext;
        public AccountController(AccountContext accontext)
        {
            _accontext = accontext;
        }
        // GET: AccountController
        public ActionResult Login()
        {
            LoginViewModal loginViewModal = new LoginViewModal();
            return View(loginViewModal);
        }
        [HttpPost]
        public ActionResult Login(LoginViewModal loginViewModal)
        {
            var users = _accontext.User.Where(x=> x.Email== loginViewModal.Username && x.Password== loginViewModal.Password).FirstOrDefault();
            if(users!=null)
            {
                ViewBag.message = "Login Successfull";

            }
            else
            {
                ViewBag.message = "Invalid Credential";
            }
            
            return View();
        }
        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Registration()
        {
            RegistrationViewModal registrationViewModal = new RegistrationViewModal();
            return View(registrationViewModal);
        }
        [HttpPost]
        public ActionResult Registration(RegistrationViewModal registrationViewModal)
        {
            try
            {
                UserViewModel user = new UserViewModel();
                user.Id = registrationViewModal.Id;
                user.FirstName = registrationViewModal.FirstName;
                user.LastName = registrationViewModal.LastName;
                user.Email = registrationViewModal.Email;
                user.Password = registrationViewModal.Password;
                user.profileImage = registrationViewModal.profileImage;
                user.IsActive = registrationViewModal.IsActive;
                user.Isverified = registrationViewModal.Isverified;
                _accontext.User.Add(user);
                _accontext.SaveChanges();

                return View();
            }
            catch (Exception ex)
            {
            }
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
