using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnMyStudy.Dao;
using slnMyStudy.Models;

namespace slnMyStudy.Service
{
    public class PersonService
    {
        public List<string> PeopleSearch(string keyword)
        {
            //Student_testDao student_TestDao = new Student_testDao();
            //return student_TestDao.PeopleSearch(keyword);
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var nameList = Student_testDao.PeopleList.ConvertAll(s => s.ToLower());
                keyword = keyword.ToLower();
                return nameList.Where(m => m.Contains(keyword)).ToList();
            }
            else
            {
                return new List<string>();
            }
        }
        public List<string> GetPeople()
        {
            return Student_testDao.PeopleList;
        }
    }
}
