using LAB.Entities;
using LAB.Logic;
using LAB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        TerritoriesLogic territoriesLogic = new TerritoriesLogic();
        // GET: Territories
        public ActionResult Index()
        {

            List<Entities.Territories> territories = territoriesLogic.GetAll();

            List<TerritoriesView> territoriesViews = territories.Select(s => new TerritoriesView
            {
                Id = s.TerritoryID,
                TerritoryDescription = s.TerritoryDescription
            }).ToList();

            return View(territoriesViews);
        }

        public ActionResult Insert(string id)
        {
            List<SelectListItem> listRegion = new List<SelectListItem>();
            listRegion.Add(new SelectListItem() { Value = "1", Text = "Eastern" });
            listRegion.Add(new SelectListItem() { Value = "2", Text = "Western" });
            listRegion.Add(new SelectListItem() { Value = "3", Text = "Northem" });
            listRegion.Add(new SelectListItem() { Value = "4", Text = "Southem" });
            ViewBag.RegionDD = listRegion;
            TempData["regiones"] = ViewBag.RegionDD;

            TerritoriesView territoriesView = new TerritoriesView();
            if (id != null)
            {
                var territorie = territoriesLogic.GetOne(id);
                territoriesView.TerritoryDescription = territorie.TerritoryDescription;
                territoriesView.RegionID = territorie.RegionID;
                return View(territoriesView);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Insert(TerritoriesView territoriesView)
        {
            ViewBag.RegionDD = TempData["regiones"];
            if (ModelState.IsValid)
            {
                try
                {
                    var territoriesEntity = new Territories();

                    territoriesEntity.TerritoryID = territoriesView.Id;
                    territoriesEntity.TerritoryDescription = territoriesView.TerritoryDescription;
                    territoriesEntity.RegionID = territoriesView.RegionID;

                    var existe = territoriesLogic.Exists(territoriesView.Id);

                    if (existe)
                        territoriesLogic.Update(territoriesEntity);
                    else
                        territoriesLogic.Add(territoriesEntity);
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {
                    TempData["message"] = ex.Message;
                    return RedirectToAction("Index", "Error");
                }
            }
            return View(territoriesView);
        }

        public ActionResult Delete(string Id)
        {
            try
            {
                territoriesLogic.Delete(Id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
                return RedirectToAction("Index", "Error");
            }
        }

    }
}