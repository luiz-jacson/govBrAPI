using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace govBr.Infra
{
    public class AuthorizeService
    {
        string response_type = "code";
        string client_id = "h-detran.se.gov.br";
        string scope = "openid+email+profile+govbr_confiabilidades";
        string redirect_uri = "https%3A%2F%2Fwww.h-detran.se.gov.br%2Fportal";
        string nonce = "wq2zL5k9GuZoRqTL";
        string state = "h53fsGAFbrywc2m6";
        string code_challenge = "";
        string code_challenge_method = "S256";

        public string Authorize()
        {
            var URLRetorno = $"https://sso.staging.acesso.gov.br/authorize?response_type={response_type}&client_id={client_id}&scope={scope}&redirect_uri={redirect_uri}&nonce={nonce}&state={state}&code_challenge={code_challenge}&code_challenge_method={code_challenge_method}";
            return URLRetorno;
        }
    }
}