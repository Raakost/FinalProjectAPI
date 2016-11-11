using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class Project : AbstractId
    {
        public string Name { get; set; }
        public string Descripstion { get; set; }
        public Company Company { get; set; }
    }
}
