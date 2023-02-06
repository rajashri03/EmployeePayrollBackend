using BusinessLayer.Interfaces;
using CommonLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;

namespace EmployeePayroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBL userBL;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserBL userBL, ILogger<UserController> _logger)
        {

            this.userBL = userBL;
            this._logger = _logger;

        }
        [HttpPost("Add")]
        public IActionResult AddUser(EmpRegistration userRegistration)
        {
            try
            {
                var reg = this.userBL.Registration(userRegistration);
                if (reg != null)
                {
                    return this.Ok(new { Success = true, message = "Registration Sucessfull", Response = reg });
                }
                else
                {

                    return this.BadRequest(new { Success = false, message = "Registration Unsucessfull" });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { Success = false, message = ex.Message });
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(EmpLogin login)
        {
            try
            {
                string tokenString = userBL.Login(login);
                if (tokenString != null)
                {
                    return Ok(new { Success = true, message = "login Sucessfull", Data = tokenString });
                }
                else
                {
                    return BadRequest(new { Success = false, message = "login Unsucessfull" });
                }
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }
        }
        [HttpGet("AllEMployees")]
        public IEnumerable<UserEntity> GetAllEmp()
        {
            try
            {
                return userBL.GetAllEmployee();
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpDelete("Remove")]
        public IActionResult DeleteNotes(long empid)
        {
            try
            {
                if (userBL.DeleteNote(empid))
                {
                    return this.Ok(new { Success = true, message = "Employee Deleted Successfully" });
                }
                else
                {
                    return this.Ok(new { Success = false, message = "Unable to delete note" });
                }
            }
            catch (Exception ex)
            {
                return this.BadRequest(new { Success = false, message = ex.Message });
            }
        }
    }
}
