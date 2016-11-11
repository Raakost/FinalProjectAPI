using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class Company : AbstractId
    {
        public string CompanyName { get; set; }        
        public List<Project> Projects { get; set; }
    }
}
