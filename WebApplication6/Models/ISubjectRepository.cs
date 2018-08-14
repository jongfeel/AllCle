using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 


namespace ApiTest.Models
{
    public interface ISubjectRepository
    {
        string AddSubject(Subject model); // 입력
        List<Subject> GetSubjects(); // 출력
        List<Subject> GetSubjects(string _daylist);
        List<Subject> GetOnlySubjects(string _subjectName);
        List<Subject> GetSubjects(string _daylist, string _subjectName);
    }
}
