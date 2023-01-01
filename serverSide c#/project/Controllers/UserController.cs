
using Microsoft.Extensions.Logging;

using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using BLL;
using BLL.cast;
using Microsoft.AspNetCore.Cors;


namespace project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("myProject")]
    public class UserController : ControllerBase
    {
        projectDb1 db;
        UserBl userBl;
        public UserController(projectDb1 p, UserBl userBl)
        {
            db = p;
            this.userBl = userBl;
        }

        [HttpGet]
        public IEnumerable<UserDTO> GetAllUsers()
        {
            return userBl.GetUsers();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserById(int id)
        {
            User u = db.Users.Find(id);
            if (u == null)
            {
                return NotFound();
            }
            return Ok(UserCast.GetUserDTO(u));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]

        public IActionResult Register(UserDTO userdto)
        {
            if (userBl.CheckUser(UserCast.GetUser(userdto)))
                return BadReques();
            User newUser =  UserCast.GetUser(userdto);
            db.Users.Add(newUser);
            db.SaveChanges();
            return OK(UserCast.GetUserDTO(newUser));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
         public IActionResult Login(UserDTO userdto)
        {
            if (userBl.CheckUser(UserCast.GetUser(userdto)))
                return OK(userdto);

            User u = db.Users.Find(userdto.Id);
            if (u =! null && u.Name ==userdto.Name && u.Password != userdto.Password)
                return OK(true);
            return BadRequest();
        }



    }

}

