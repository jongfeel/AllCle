using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiTest.Models;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/AllCle")]
    public class SubjectsController : Controller
    {
        private ISubjectRepository _repo;

        // 의존성 주입: ISubjectRepository의 인스턴스를 SubjectRepository의 인스턴스로
        public SubjectsController(ISubjectRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            return _repo.GetSubjects();
        }

        [HttpGet("{daylist}")]
        public IEnumerable<Subject> Get(string daylist)
        {
            return _repo.GetSubjects(daylist);
        }

        [Route("subject/{subjectName}")]
        [HttpGet]
        public IEnumerable<Subject> GetOnlySubjects(string subjectName)
        {
            return _repo.GetOnlySubjects(subjectName);
        }

        [Route("{daylist}/{subjectName}")]
        [HttpGet]
        public IEnumerable<Subject> Get(string daylist, string subjectName)
        {
            return _repo.GetSubjects(daylist, subjectName);
        }

        [HttpPost]
        public Subject PostSubject([FromBody] Subject Subject)
        {
            _repo.AddSubject(Subject);
            return Subject;
        }
    }
}
