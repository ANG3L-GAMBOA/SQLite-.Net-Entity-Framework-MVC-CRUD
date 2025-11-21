using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQliteEFSample.Models;

namespace SQliteEFSample.Data
{
    public class MySqliteContext : DbContext
    {
        public MySqliteContext (DbContextOptions<MySqliteContext> options)
            : base(options)
        {
        }

        public DbSet<SQliteEFSample.Models.Car> Car { get; set; } = default!;
    }
}
