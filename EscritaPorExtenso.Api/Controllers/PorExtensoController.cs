using System.Web.Http;

namespace EscritaPorExtenso.Api.Controllers
{
    public class PorExtensoController : ApiController
    {
        [Route("api/PorExtenso/{numero}")]
        public IHttpActionResult Get(int numero)
        {
            var numeroPorExtenso = numero.PorExtenso();
            return Ok(numeroPorExtenso);
        }
    }
}