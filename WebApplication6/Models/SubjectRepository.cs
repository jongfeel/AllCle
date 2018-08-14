using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace ApiTest.Models
{
    public class SubjectRepository : ISubjectRepository
    {
        private IConfiguration _config;
        private SqlConnection db;

        public SubjectRepository(IConfiguration config)
        {
            _config = config;

            // IConfiguration 개체를 통해서 
            // appsettings.json의 데이터베이스 연결 문자열을 읽어온다. 
            db = new SqlConnection(
                _config.GetSection("ConnectionStrings").GetSection(
                    "DefaultConnection").Value);
        }

        // 입력
        public string AddSubject(Subject model)
        {
            string sql = "Insert Into Subjects (Id, Pw) Values (@Id, @Pw)";
            var id = this.db.Execute(sql, model);
            return "successfully add";
        }

        public List<Subject> GetSubjects()
        {
            string sql = "Select * From SubjectTable$ Order by NO Asc";
            return this.db.Query<Subject>(sql).ToList();
        }
        public List<Subject> GetOnlySubjects(string _subjectName)
        {
            string sql = "Select * From SubjectTable$ Where ClassName Like N'%"+_subjectName + "%'";
            return this.db.Query<Subject>(sql).ToList();
        }

        public List<Subject> GetSubjects(string _daylist)
        {
            string[] parser = new string[60];
            int index = 0,i=0;
            for (i = 0; _daylist.Contains("|"); i++)
            {
                index = _daylist.IndexOf("|");
                parser[i] = _daylist.Substring(0, index);
                _daylist = _daylist.Remove(0, index + 1);
            }
            string sql = "Select * From SubjectTable$ Where Time1 <> N'"+parser[0]+ "' ";
            for (int j = 1; j < i; j++)
            {
                sql = sql + "and Time1 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time2 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time3 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time4 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time5 <> N'" + parser[j] + "'";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time6 <> N'" + parser[j] + "'";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time7 <> N'" + parser[j] + "'";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time8 <> N'" + parser[j] + "'";
            }
            return this.db.Query<Subject>(sql).ToList();
        }
        public List<Subject> GetSubjects(string _daylist, string _subjectName)
        {
            string[] parser = new string[60];
            int index = 0, i = 0;
            for (i = 0; _daylist.Contains("|"); i++)
            {
                index = _daylist.IndexOf("|");
                parser[i] = _daylist.Substring(0, index);
                _daylist = _daylist.Remove(0, index + 1);
            }
            string sql = "Select * From SubjectTable$ Where Time1 <> N'" + parser[0] + "' ";
            for (int j = 1; j < i; j++)
            {
                sql = sql + "and Time1 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time2 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time3 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time4 <> N'" + parser[j] + "' ";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time5 <> N'" + parser[j] + "'";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time6 <> N'" + parser[j] + "'";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time7 <> N'" + parser[j] + "'";
            }
            for (int j = 0; j < i; j++)
            {
                sql = sql + "and Time8 <> N'" + parser[j] + "'";
            }
            sql = sql + "and ClassName Like N'%" + _subjectName + "%'";
            return this.db.Query<Subject>(sql).ToList();
        }
    }
}