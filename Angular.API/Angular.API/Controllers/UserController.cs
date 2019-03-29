using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Angular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
    
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new
            {
                Nombre = "Pedro",
                Apellido = "Perez",
                Email = "prueba@angular.com"
            });
        }

        // GET api/values/5
        [HttpGet("users")]
        public ActionResult GetUsers()
        {
            List<UserViewModel> users = new List<UserViewModel>();

            users.Add(new UserViewModel
            {
                LastName = "Garcia",
                Name = "Beto",
                Email = "email@email.com"
            });

            users.Add(new UserViewModel
            {
                LastName = "Alonzo",
                Name = "Beto",
                Email = "email@email.com"
            });

            users.Add(new UserViewModel
            {
                LastName = "Puente",
                Name = "Tito",
                Email = "email@email.com"
            });

            return Ok(users);
        }

        // GET api/values/5
        [HttpPost("adduser")]
        public ActionResult AddUser([FromBody]UserViewModel user)
        {
            return Ok();
        }

    }
}
