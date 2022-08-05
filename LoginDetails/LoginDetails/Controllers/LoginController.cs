using LoginDetails.Interfaces;
using LoginDetails.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDetails.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private ILoginDetails members = new MembersRepository(); //u shouldnot create object for IloginDetails...try to use dependancy injecttion

        [HttpGet]
        [Route("")]   // api/login/getallmembers
        public ActionResult<IEnumerable<Login_dto>> GetAllMembers()
        {
            return members.GetAllMember();
        }
        [HttpGet]
        [Route("{id}")] //api/login/1
        public ActionResult<Login_dto> GetMemberById(int id)
        {
            return members.GetMember(id);
        }




        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateModel model)   
        {

            var user = members.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(user);

            //return Ok(new
            //{
            //    Id = user.MemberId,
            //    Username = user.UserName,
            //    FirstName = user.FirstName,
            //    LastName = user.LastName,

            //});
        }



        //[HttpPut("{id}")]
        //public IActionResult Forgetpwd(int id,[FromBody] ForGetPasswordModel model)
        //{
        //    var update= members.Forgetpwd(id,model);
        //    if(update!=null)
        //        return Ok(new { message = "Password updated successfully" });  
        //}
    }
}




