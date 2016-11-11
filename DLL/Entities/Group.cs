using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class Group : AbstractId
    {
        public string Name { get; set; }
        public List<User> Students { get; set; }
        public Project Project { get; set; }
    }
}
