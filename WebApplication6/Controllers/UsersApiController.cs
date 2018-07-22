using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTest.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    public class UsersApiController : Controller
    {
        private IUserRepository _repo;

        // 의존성 주입: IUserRepository의 인스턴스를 UserRepository의 인스턴스로
        public UsersApiController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            return _repo.GetUsers();
        }

       
        [HttpGet("{Id}")]
        public IEnumerable<User> Get(string Id)
        {
            return _repo.GetUsers(Id);
        }

        [HttpPost]
        public User PostUser([FromBody] User User)
        {
            _repo.AddUser(User);
            return User;
        }
    }
}
