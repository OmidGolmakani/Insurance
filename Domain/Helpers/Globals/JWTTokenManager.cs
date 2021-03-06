using Domain.CustomException;
using Domain.Extensions.Other;
using Domain.Models.Dtos.Responses.Authentications;
using Domain.Models.Dtos.Responses.RolePermissions;
using Domain.Models.Dtos.Responses.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Domain.Helpers.Globals
{
    public class JWTTokenManager
    {
        public static IConfiguration configuration = null;
        private static AuthenticationResponse AuthInfo
        {
            get
            {
                AuthenticationResponse authorizationOption = new AuthenticationResponse();
                configuration.GetSection("Authentication").Bind(authorizationOption);
                return authorizationOption;
            }
        }
        public static HttpContext HttpContext { get; set; }
        public static string GeneratePermissionToken(RolePermissionResponse Permission)
        {

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            ClaimsIdentity claims = new ClaimsIdentity();
            var key = Encoding.BigEndianUnicode.GetBytes(AuthInfo.SecretKey);
            var SecurityKey = new SymmetricSecurityKey(key);
            IdentityModelEventSource.ShowPII = true;

            claims.AddClaim(new Claim(ClaimTypes.Role, Permission.RoleId.ToString()));
            claims.AddClaim(new Claim("Url", Permission.Url));

            SecurityTokenDescriptor TokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = claims,
                SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256Signature),
            };
            SecurityToken token = tokenHandler.CreateToken(TokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public static TokenResponse GenerateToken(Models.Entities.User user, List<string> rolesName)
        {

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            ClaimsIdentity claims = new ClaimsIdentity();
            var key = Encoding.BigEndianUnicode.GetBytes(AuthInfo.SecretKey);
            var SecurityKey = new SymmetricSecurityKey(key);
            IdentityModelEventSource.ShowPII = true;

            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            claims.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
            claims.AddClaim(new Claim(ClaimTypes.MobilePhone, user.PhoneNumber));
            claims.AddClaim(new Claim(ClaimTypes.Email, user.Email ?? ""));
            claims.AddClaim(new Claim(ClaimTypes.Expired, DateTime.Now.AddMinutes(AuthInfo.ExpiryTime).ToString()));
            claims.AddClaim(new Claim(ClaimTypes.Role, string.Join(string.Empty, rolesName.ToArray())));

            SecurityTokenDescriptor TokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = claims,
                Expires = DateTime.Now.AddMinutes(AuthInfo.ExpiryTime),
                SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256Signature),
                NotBefore = DateTime.Now
            };
            SecurityToken token = tokenHandler.CreateToken(TokenDescriptor);
            return new TokenResponse() { Value = tokenHandler.WriteToken(token) };
        }
        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null)
                    return null;
                byte[] key = Encoding.BigEndianUnicode.GetBytes(AuthInfo.SecretKey);
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out securityToken);
                return principal;
            }
            catch (CustomException.CustomException)
            {
                return null;
            }
        }
        public static ClaimsPrincipal GetPermissionPrincipal(string token)
        {
            try
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                if (jwtToken == null)
                    return null;
                byte[] key = Encoding.BigEndianUnicode.GetBytes(AuthInfo.SecretKey);
                TokenValidationParameters parameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = false,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
                SecurityToken securityToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, parameters, out securityToken);
                return principal;
            }
            catch (CustomException.CustomException)
            {
                return null;
            }
        }
        public static string ValidatePermissionToken(string Token)
        {
            try
            {
                ClaimsPrincipal principal = GetPermissionPrincipal(Token);
                if (principal == null)
                    return null;
                ClaimsIdentity identity = null;
                try
                {
                    identity = (ClaimsIdentity)principal.Identity;
                }
                catch (CustomException.CustomException)
                {
                    return null;
                }


                Claim usernameClaim = identity.FindFirst("Url");
                return usernameClaim.Value;
            }
            catch (CustomException.CustomException ex)
            {
                throw new CustomException.CustomException("ValidatePermissionToken", ex);
            }
        }
        //public static string ValidateToken(string token,  Domain.Models.Dtos.Fundamentals.Response.ListResponse<UserResponse> user)
        //{
        //    try
        //    {
        //        string username = null;
        //        ClaimsPrincipal principal = GetPrincipal(token);
        //        if (principal == null)
        //            return null;
        //        ClaimsIdentity identity = null;
        //        try
        //        {
        //            identity = (ClaimsIdentity)principal.Identity;
        //        }
        //        catch (MyException)
        //        {
        //            return null;
        //        }
        //        long Id = identity.FindFirst(ClaimTypes.NameIdentifier).Value.ToLong();
        //        string userName = identity.FindFirst(ClaimTypes.Name).Value;
        //        string phone = identity.FindFirst(ClaimTypes.MobilePhone).Value;
        //        string email = identity.FindFirst(ClaimTypes.Email).Value;
        //        if (user.Items.FirstOrDefault(u => u.Id != Id || u.UserName != userName || u.PhoneNumber != phone || u.Email != email) == null)
        //        {
        //            throw new MyException(System.Net.HttpStatusCode.Unauthorized, "توکن ارسال شده نامعتبر است");
        //        }


        //        Claim usernameClaim = identity.FindFirst(ClaimTypes.Name);
        //        username = usernameClaim.Value;
        //        return username;
        //    }
        //    catch (MyException ex)
        //    {
        //        throw new Exception("ValidateToken", ex);
        //    }
        //}
        public static long GetUserIdByToken(string token = "")
        {
            try
            {
                if (HttpContext.Request.Headers
                        .Count(x => x.Key == "Authorization") == 0)
                {
                    return -1;
                }
                if (token == "")
                {
                    token = HttpContext.Request.Headers
                        .FirstOrDefault(x => x.Key == "Authorization").Value.
                        ToString().Replace("Bearer", "").Trim();
                }
                ClaimsPrincipal principal = GetPrincipal(token);
                if (principal == null)
                    return 0;
                ClaimsIdentity identity = null;
                try
                {
                    identity = (ClaimsIdentity)principal.Identity;
                }
                catch (CustomException.CustomException)
                {
                    return 0;
                }
                return identity.FindFirst(ClaimTypes.NameIdentifier).Value.ToLong();

            }
            catch (CustomException.CustomException)
            {
                throw;
            }
        }
        public static long GetUserIdByCookie(string token = "")
        {
            try
            {
                if (HttpContext.Request.Cookies.ContainsKey("AccessToken") == false)
                {
                    return -1;
                }
                if (token == "")
                {
                    token = HttpContext.Request.Cookies
                        .FirstOrDefault(x => x.Key == "AccessToken").Value.
                        ToString().Trim();
                }
                ClaimsPrincipal principal = GetPrincipal(token);
                if (principal == null)
                    return 0;
                ClaimsIdentity identity = null;
                try
                {
                    identity = (ClaimsIdentity)principal.Identity;
                }
                catch (CustomException.CustomException)
                {
                    return 0;
                }
                return identity.FindFirst(ClaimTypes.NameIdentifier).Value.ToLong();

            }
            catch (CustomException.CustomException)
            {
                throw;
            }
        }
        //public static string GetTokenFromRequest()
        //{
        //    if (Helpers.MyAppContext.Current.Request.Headers.
        //           FirstOrDefault(x => x.Key == "Authorization").Value.FirstOrDefault() == null)
        //    {
        //        throw new Exception("توکن ارسال نشده است");
        //    }
        //    var Token = Helpers.MyAppContext.Current.Request.Headers.
        //        FirstOrDefault(x => x.Key == "Authorization").Value.FirstOrDefault().
        //        Replace("Bearer", "").Trim();
        //    return Token;
        //}
    }
}
