using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) All courses
            var couse = new List<Course>() {
                new Course{ Id=1, Canal= Canal.DotNet, Hours=24, PublishedDate = DateTime.Now,Title="Test"},
                new Course{ Id=1, Canal= Canal.DotNet, Hours=30, PublishedDate = DateTime.Now,Title="Test2"}
            };

            //2) ORDER BY Publication date
            var course = couse.OrderBy(x => x.PublishedDate);

        }
    }
}
