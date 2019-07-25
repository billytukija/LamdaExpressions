using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        public DateTime PublishedDate { get; set; }
        public Canal Canal { get; set; }
    }
}
