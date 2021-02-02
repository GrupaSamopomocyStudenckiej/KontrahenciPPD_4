using MVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVC.Controllers
{
    public class FakturyController : Controller
    {
        // GET: Faktury
        public ActionResult Index(string NIP, string Data_od, string Data_do)
        {
            HttpWebRequest OdpytanieAPI = (HttpWebRequest)WebRequest.Create("https://localhost:44306/api/Faktury?NIP=" + NIP + "&Data_od="+ Data_od + "&Data_do="+ Data_do);
            OdpytanieAPI.ContentType = "application/json";
            var response = (HttpWebResponse)OdpytanieAPI.GetResponse();
            string text;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            FakturyOut fakturaOut = JsonConvert.DeserializeObject<FakturyOut>(text);

            var enumerable = new[] { fakturaOut };

            return View(enumerable);

        }
    }
}