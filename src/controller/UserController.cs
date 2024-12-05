using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api02.src.interfaces;
using api02.src.models;
using Microsoft.AspNetCore.Mvc;

namespace api02.src.controller
{   
    [Route("api/[controller]")]
    [ApiController]


    public class UserController : ControllerBase
    {

        private readonly iUserRepository _userRepository;

        public UserController(iUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("all")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            var newUser = await _userRepository.Post(user);
            return CreatedAtAction(nameof(GetAllUsers), new { id = newUser.Id }, newUser);
        }

    }
    
}