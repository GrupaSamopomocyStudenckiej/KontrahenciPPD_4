using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class FirmyController : Controller
    {
        // GET: Firmy
        public ActionResult Index()
        {
            IEnumerable<mvcFirmyModel> FirmyLista;
            HttpResponseMessage response = ZmienneGlobalne.WebApiClient.GetAsync("Firmy").Result;
            FirmyLista = response.Content.ReadAsAsync<IEnumerable<mvcFirmyModel>>().Result;
            return View(FirmyLista);
        }

        public ActionResult DodajLubUsun(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcFirmyModel());
            }
            else
            {
                HttpResponseMessage response = ZmienneGlobalne.WebApiClient.GetAsync("Firmy/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcFirmyModel>().Result);
            }

        }
        [HttpPost]
        public ActionResult DodajLubUsun(mvcFirmyModel firma)
        {
            if (firma.IdFirmy == 0)
            {
                HttpResponseMessage response = ZmienneGlobalne.WebApiClient.PostAsJsonAsync("Firmy", firma).Result;
                TempData["Sukces"] = "Pomyślnie zapisano";
            }
            else
            {
                HttpResponseMessage response = ZmienneGlobalne.WebApiClient.PutAsJsonAsync("Firmy/" + firma.IdFirmy, firma).Result;
                TempData["Sukces"] = "Pomyślnie edytowano";
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Usun(int id)
        {
            HttpResponseMessage response = ZmienneGlobalne.WebApiClient.DeleteAsync("Firmy/"+id.ToString()).Result;
            TempData["Usunieto"] = "Usunieto kontrahenta";
            return RedirectToAction("Index");
        }
    }
}