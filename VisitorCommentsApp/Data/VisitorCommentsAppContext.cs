using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisitorCommentsApp.Models;

namespace VisitorCommentsApp.Data
{
    public class VisitorCommentsAppContext : DbContext
    {
        public VisitorCommentsAppContext (DbContextOptions<VisitorCommentsAppContext> options)
            : base(options)
        {
        }

        public DbSet<VisitorCommentsApp.Models.Visitor>? Visitors { get; set; }
    }
}
