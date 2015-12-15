using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class ReservationController : Controller
    {
        private ReservationRespository _repo = ReservationRespository.Current;

        // GET: Reservation
        public ActionResult Index()
        {
          // no longer use this, now using ajax to api/webcontroller ...   return View(_repo.GetAll());
            return View();
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(Reservation item)// FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Add(item);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }

            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Reservation item) // FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid && _repo.Update(item))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Index");
                }
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            _repo.Remove(id);
            return RedirectToAction("Index");
            // return View();
        }

        // POST: Reservation/Delete/5
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
