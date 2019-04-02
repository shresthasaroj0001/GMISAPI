using Microsoft.AspNetCore.Antiforgery;
using GMIS.Controllers;

namespace GMIS.Web.Host.Controllers
{
    public class AntiForgeryController : GMISControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
