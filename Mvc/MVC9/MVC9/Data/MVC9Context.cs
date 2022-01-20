using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC9.Models;

namespace MVC9.Data
{
    public class MVC9Context : DbContext
    {
        public MVC9Context (DbContextOptions<MVC9Context> options)
            : base(options)
        {
        }

        public DbSet<MVC9.Models.Student> Student { get; set; }
    }
}
