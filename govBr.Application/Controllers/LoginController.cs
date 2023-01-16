using govBr.Infra.IServices;
using govBr.Infra;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace govBr.Application.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet("UrlLogin")]
        public ActionResult<string> GetLoginUrl()
        {
            var result = _loginService.UrlLogin();

            return Ok(result);
        }
    }
}
