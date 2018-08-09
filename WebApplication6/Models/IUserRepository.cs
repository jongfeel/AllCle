using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 


namespace ApiTest.Models
{
    public interface IUserRepository
    {
        string AddUser(User model); // 입력
        List<User> GetUsers(); // 출력
        List<User> GetUsers(string _Id);
    }
}
