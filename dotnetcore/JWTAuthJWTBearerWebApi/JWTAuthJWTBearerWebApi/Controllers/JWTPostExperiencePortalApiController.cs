﻿using Microsoft.AspNetCore.Mvc;
using JWTAuthJWTBearerWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTAuthJWTBearerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTPostExperiencePortalApiController : ControllerBase
    {
        // GET: api/<JWTPostExperiencePortalApiController>
        private IConfiguration _configuration;
        private readonly AppDBContext _context;

        public JWTPostExperiencePortalApiController(IConfiguration configuration, AppDBContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> PostLoginDetails(UserModel userModel)
        {
            if (userModel != null)
            {
                var resultLoginCheck = await _context.Employees.Where(e => e.EmailId == userModel.EmailId && e.Password == userModel.Password).FirstOrDefaultAsync();
                if (resultLoginCheck == null)
                {
                    return BadRequest("Invalid Credential");
                }
                else
                {
                    userModel.UserMessage = "Login Success";
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat,DateTime.UtcNow.ToString()),
                        new Claim("EmployeeId",resultLoginCheck.EmployeeId.ToString()),
                         new Claim("FirstName",resultLoginCheck.FirstName.ToString()),
                         new Claim("LastName",resultLoginCheck.LastName.ToString()),
                         new Claim("Email",resultLoginCheck.EmailId.ToString())
                    };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var SignIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddMinutes(10), signingCredentials: SignIn);

                    userModel.AccessToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(userModel);

                }


            }
            else
            {
                return BadRequest("No Data Posted");
            }
        }

    }
}
