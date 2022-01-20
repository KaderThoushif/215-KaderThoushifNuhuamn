using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCD.Models;

namespace MVCD.Data
{
    public class MVCDContext : DbContext
    {
        public MVCDContext (DbContextOptions<MVCDContext> options)
            : base(options)
        {
        }

        public DbSet<MVCD.Models.Department> Department { get; set; }
    }
}
