using govBr.Infra.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace govBr.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly IAuthorizeService _urlService;

        public DefaultController(IAuthorizeService urlService)
        {
            _urlService = urlService;
        }
        public string RetornaUrl() 
        {
            return _urlService.Authorize();
        }
    }
}
