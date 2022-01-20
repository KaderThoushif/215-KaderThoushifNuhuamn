using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi3.Models;

namespace WebApi3.Data
{
    public class WebApi3Context : DbContext
    {
        public WebApi3Context (DbContextOptions<WebApi3Context> options)
            : base(options)
        {
        }

        public DbSet<WebApi3.Models.Department> Department { get; set; }
    }
}
