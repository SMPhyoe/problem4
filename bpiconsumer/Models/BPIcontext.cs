using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpiconsumer.Models
{
    public class BPIcontext : DbContext
    {
        public DbSet<BPI> bpi { get; set; }

        public BPIcontext(DbContextOptions options) : base(options)
        {
           
        }
    }
}
