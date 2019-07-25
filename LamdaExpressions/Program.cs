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
            // All courses
            var courses = new List<Course>() {
                new Course{ Id=1, Canal= Canal.DotNet, Hours=24, PublishedDate = DateTime.Now,Title="Test"},
                new Course{ Id=1, Canal= Canal.DotNet, Hours=30, PublishedDate = DateTime.Now,Title="Test2"}
            };

            //ORDER BY Publication date
            var courses = courses.OrderBy(x => x.PublishedDate);

            // ORDER BY DataPublicacao, CargaHoraria
            //var courses = db.courses.OrderBy(c => c.PublishedDate).ThenBy(c => c.Hours);

            // ORDER BY DataPublicacao, CargaHoraria DESC
            //var courses = db.courses.OrderBy(c => c.PublishedDate).ThenByDescending(c => c.Hours);

            //WHERE Canal = Python
            //var courses = db.courses.Where(c => c.Canal == Canal.Python);

            //WHERE CargaHoraria
            //var courses = db.courses.Where(c => c.Hours > 20);

            //TOP 5 + ORDER BY DATA DESC
            //var courses = db.courses.OrderByDescending(c => c.PublishedDate).Take(5);            

            //foreach (Course c in courses)
            //{
            //    Console.WriteLine(c);
            //}

            //TOP 1 + ORDER BY DATA DESC
            //var courses = db.courses.OrderByDescending(c => c.PublishedDate).ThenByDescending(c => c.Id).FirstOrDefault();
            //Console.WriteLine(curso);

            // COUNT(*) WHERE CANAL = Engenharia de Software
            //int total = db.Course.Count(c => c.Canal == Canal.EngenhariaDeSoftware);
            //Console.WriteLine(total);


        }
    }
}
