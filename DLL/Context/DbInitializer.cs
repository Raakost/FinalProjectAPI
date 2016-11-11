using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Context
{
    class DbInitializer : DropCreateDatabaseAlways<FPContext>
    {
        protected override void Seed(FPContext ctx)
        {
            base.Seed(ctx);
        }
    }
}
