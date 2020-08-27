using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Dao
{
    public class Student_testDao
    {
        public static List<string> PeopleList { get; } = new List<string>()
        {
            "Jason", "Kevin", "Eric", "David", "James", "Alex", "Jerry", "Andy", "Jack", "Allen", "Vincent", "Sam", "Ken", "Chris", "Tony",
            "Leo", "Peter", "Ryan", "Daniel", "Emily", "Amy", "Alice", "Grace", "Tina", "Joyce", "Vivian", "Cindy", "Ivy", "Jenny", "Claire",
            "Annie", "Vicky", "Jessica", "Peggy", "Sandy", "Irene", "Iris", "Maggie", "Winnie", "Tony"
        };
        public List<string> PeopleSearch(string keyword)
        {
            return PeopleList.Where(s => s.Contains(keyword)).ToList();
        }
    }
}
