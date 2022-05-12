using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signUps = db.SignUps.Where(x => x.Removed == null).ToList();
                var signUpsVMs = new List<SignUpsVM>();
                foreach (var signUp in signUps)
                {
                    var signUpVM = new SignUpsVM();
                    signUpVM.Id = signUp.id;
                    signUpVM.FirstName = signUp.FirstName;
                    signUpVM.LastName = signUp.LastName;
                    signUpVM.EmailAddress = signUp.EmailAddress;
                    signUpsVMs.Add(signUpVM);
                }

                return View(signUpsVMs);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}