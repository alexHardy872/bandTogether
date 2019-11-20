using bandTogether.Models;
using bandTogether.Models.ViewModels;
using bandTogether.Services.Band;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace bandTogether.Controllers
{
    public class BandController : Controller
    {

        ApplicationDbContext context;

        public BandController()
        {
            context = new ApplicationDbContext();
        }


        // GET: Band
        public async Task<ActionResult> Index()
        {
            BandSocialViewModel socialIndex = new BandSocialViewModel();

            // get social posts
            string facebookPageId = "1308735289192501";

            socialIndex.facebookPermalinks = await FacebookService.GetPermaUrlFromPost(facebookPageId);

            // get facebook posts

            // get twitter posts

            // get spotify info

            // get youtube info

            return View(socialIndex);
        }

        // GET: Band/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Band/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Band/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Band/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Band/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Band/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
