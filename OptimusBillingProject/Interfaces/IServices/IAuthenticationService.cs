using Microsoft.Extensions.Options;
using OptimusBillingProject.Entity;
using OptimusBillingProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace OptimusBillingProject.Interfaces.IServices
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// This interface defines authenticate method which returns a string type Base64 Encode Token
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        string Authenticate(string username, string password);
    }
}    