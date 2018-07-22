using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ApiTest.Models
{
    public class UserRepository : IUserRepository
    {
        private IConfiguration _config;
        private SqlConnection db;

        public UserRepository(IConfiguration config)
        {
            _config = config;

            // IConfiguration 개체를 통해서 
            // appsettings.json의 데이터베이스 연결 문자열을 읽어온다. 
            db = new SqlConnection(
                _config.GetSection("ConnectionStrings").GetSection(
                    "DefaultConnection").Value);
        }

        // 입력
        public void AddUser(User model)
        {
            string sql = "Insert Into Users (Pw) Values (@Pw)";
            var id = this.db.Execute(sql, model);
        }

        // 출력
        public List<User> GetUsers()
        {
            string sql = "Select * From Users Order By No Asc";
            return this.db.Query<User>(sql).ToList();
        }
   
        public List<User> GetUsers(string _Id)
        {
            string sql = "Select * From Users Where Id like '"+_Id+"'";
            return this.db.Query<User>(sql).ToList();
        }
    }
}
