using govBr.Infra.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace govBr.Infra.Services
{
    public class LoginService : ILoginService
    {
        readonly IConfiguration _configuration;

        public LoginService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public Task<object> GetTokens(string code)
        //{
        //    string code_verifier = _configuration.GetSection("DataSecret:code_verifier").Value;
        //}

        public string UrlLogin()
        {
            string response_type = "code";
            string client_id = "h-detran.se.gov.br";
            string scope = "openid+email+profile+govbr_confiabilidades";
            string redirect_uri = _configuration.GetSection("DataSecret:redirect_uri").Value;
            string nonce = "wq2zL5k9GuZoRqTL";
            string state = "h53fsGAFbrywc2m6";
            string code_challenge = _configuration.GetSection("DataSecret:code_challenge").Value; // gerado junto ao CodeVerifier
            string code_challenge_method = "S256";


            var URLRetorno = $"https://sso.staging.acesso.gov.br/authorize?response_type={response_type}&client_id={client_id}&scope={scope}&redirect_uri={redirect_uri}&state={state}&code_challenge={code_challenge}&code_challenge_method={code_challenge_method}&nonce={nonce}";
            return URLRetorno;

        }
    }
}
