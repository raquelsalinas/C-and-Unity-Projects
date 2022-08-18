using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Parameters
{
    public class Employee<T>
    {
        public Employee()
        {
            List<T> Things = new List<T>();
        }
        public List<T> Things { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }
    }
}
