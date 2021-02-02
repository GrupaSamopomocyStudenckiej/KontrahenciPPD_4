using API.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text.Json;
using System.Text;

namespace API.Controllers
{
    public class IntegracjaController : ApiController
    {
        private readonly KontrahenciEntities db = new KontrahenciEntities();

        public HttpResponseMessage GetDaneIntegracyjne(int id)
        {
            IQueryable<Firmy> firmaDB = db.Firmy.Where(firm => firm.Nip == id.ToString());

            FirmyJSON firmaJSON = new FirmyJSON();

            firmaJSON.ID = firmaDB.First().IdFirmy;
            firmaJSON.Nazwa = firmaDB.First().NazwaFirmy;
            firmaJSON.Adres = firmaDB.First().Miasto + ", " + firmaDB.First().Ulica + " " + firmaDB.First().NrBudynku + "/" + firmaDB.First().NrLokalu + " " + firmaDB.First().KodPocztowy + " " + firmaDB.First().Poczta + " " + firmaDB.First().Kraj;
            firmaJSON.NIP = firmaDB.First().Nip;
            firmaJSON.Email = firmaDB.First().Email;
            firmaJSON.Telefon = firmaDB.First().NrTelefonu; ;

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonSerializer.Serialize<FirmyJSON>(firmaJSON), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
