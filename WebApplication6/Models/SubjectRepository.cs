﻿using System;
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

        public SubjectRepository(IConfiguration config)                                             // db 설정하는 메소드
        {
            _config = config;

            // IConfiguration 개체를 통해서 
            // appsettings.json의 데이터베이스 연결 문자열을 읽어온다. 
            db = new SqlConnection(
                _config.GetSection("ConnectionStrings").GetSection(
                    "DefaultConnection").Value);
        }

        // 입력
        public string AddSubject(Subject model)                                                     // 로그인할 때 사용하는 메소드. (인수 생각)
                                                                                                    // 로그인할 때 쓰는 거라면, 계정 DB와 과목DB 구분해야되니까, 이건 계정 DB 연결되있는 다른 Class 만들어서 거기서 구현해야되지 않을까?
        {
            string sql = "Insert Into Subjects (Id, Pw) Values (@Id, @Pw)";
            var id = this.db.Execute(sql, model);
            return "successfully add";
        }

        public List<Subject> GetSubjects()                                                          // 기본 출력화면
        {
            string sql = "Select * From SubjectTable$ Order by NO Asc";
            return this.db.Query<Subject>(sql).ToList();
        }
        public List<Subject> GetOnlySubjects(string _subjectName)                                   // 클라이언트에서 과목명 검색할 때 사용
        {
            string sql = "Select * From SubjectTable$ Where ClassName Like N'%"+_subjectName + "%'";
            return this.db.Query<Subject>(sql).ToList();
        }

        public List<Subject> GetSubjects(string _daylist)                                           // daylist = 과목 시간을 "|"를 기준으로 merge한 string
        {
            string[] parser = new string[60];
            int index = 0,i=0;
            for (i = 0; _daylist.Contains("|"); i++)                                                // daylist string을 "|"를 기준으로 다시 나눈뒤, 과목시간 데이터를 배열원소로 저장한다.
            {
                index = _daylist.IndexOf("|");
                parser[i] = _daylist.Substring(0, index);
                _daylist = _daylist.Remove(0, index + 1);
            }
            string sql = "Select * From SubjectTable$ Where Time1 <> N'"+parser[0]+ "' ";           // 위에서 배열원소로 저장한 과목시간 데이터를 따로 출력해준다.
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
        public List<Subject> GetSubjects(string _daylist, string _subjectName)                                  // daylist = 과목 시간을 "|"를 기준으로 merge한 string
        {
            string[] parser = new string[60];
            int index = 0, i = 0;
            for (i = 0; _daylist.Contains("|"); i++)                                                            // daylist string을 "|"를 기준으로 다시 나눈뒤, 과목시간 데이터를 배열원소로 저장한다.
            {
                index = _daylist.IndexOf("|");
                parser[i] = _daylist.Substring(0, index);
                _daylist = _daylist.Remove(0, index + 1);
            }
            string sql = "Select * From SubjectTable$ Where Time1 <> N'" + parser[0] + "' ";                    // 위에서 배열원소로 저장한 과목시간 데이터를 따로 출력해준다.
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