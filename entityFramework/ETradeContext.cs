using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace entityFramework
{
    public class ETradeContext:DbContext
    {//dbset:jenerik
        public DbSet<Product> products { get; set; }
        //context olustu
    }
}
