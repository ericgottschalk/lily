using ENG.Lily.Infraestructure.Runtime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Text;

namespace ENG.Lily.Api.Filters
{
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues authHeader);
            var token = authHeader.ToString();

            if (!string.IsNullOrWhiteSpace(token) && token.StartsWith("bearer", StringComparison.OrdinalIgnoreCase))
            {
                token = token.Substring("Basic ".Length).Trim();

                if (!ValidateToken(token))
                {
                    context.Result = new StatusCodeResult((int)HttpStatusCode.Unauthorized);
                }
            }

            base.OnActionExecuting(context);
        }

        private bool ValidateToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(RuntimeContext.SecretKey)),
                    ValidateLifetime = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ClockSkew = TimeSpan.Zero
                };

                var claimsPrincipal = handler.ValidateToken(token, validationParameters, out SecurityToken securityToken);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
