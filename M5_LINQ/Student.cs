using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5_LINQ
{
    class Student :IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public string GroupNumber { get; set; }

        public int CompareTo(object obj)
        {
            return this.FirstName.CompareTo((obj as Student).FirstName);
        }
    }
}
