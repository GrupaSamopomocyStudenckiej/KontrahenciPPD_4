using API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace API.Controllers
{
    public class FakturyController : ApiController
    {
        //https://localhost:44306/api/Faktury?NIP=13221&Data_od=121212&Data_do=12121
        [ResponseType(typeof(FakturyOut))]
        public HttpResponseMessage GetSaldoFaktur(string NIP, string Data_od, string Data_do)
        {
            HttpWebRequest OdpytanieAPI = (HttpWebRequest)WebRequest.Create("https://api.mocki.io/v1/248c570e");
            //HttpWebRequest OdpytanieAPI = (HttpWebRequest)WebRequest.Create("https://api.mocki.io/v1/248c570e?NIP="+ NIP + "&Data_od="+ Data_od + "&Data_do="+ Data_do); 
            OdpytanieAPI.ContentType = "application/json";
            var response = (HttpWebResponse)OdpytanieAPI.GetResponse();
            string text;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            List<FakturyIn> list = JsonConvert.DeserializeObject<List<FakturyIn>>(text);

            FakturyOut fakturyOut = new FakturyOut(0, 0, 0, 0, "");

            foreach (FakturyIn fakturaIn in list)
            {
                if (fakturaIn.Status != "Zapłacone")
                {
                    fakturyOut.IloscNieZaplacone += 1;
                    fakturyOut.WartoscNieZaplacone += fakturaIn.Wartosc_faktury;
                }
                else
                {
                    fakturyOut.IloscZaplacone += 1;
                    fakturyOut.WartoscZaplacone += fakturaIn.Wartosc_faktury;
                }
            }

            fakturyOut.SaldoOstateczne = (0 - fakturyOut.WartoscNieZaplacone).ToString("0.00", CultureInfo.InvariantCulture);

            var res = Request.CreateResponse(HttpStatusCode.OK);
            res.Content = new StringContent(JsonConvert.SerializeObject(fakturyOut), Encoding.UTF8, "application/json");
            return res;
           // return Ok(fakturyOut);
        }
    }
}
