using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Context
{
    public class EFContext : IdentityDbContext
    {
        public EFContext(DbContextOptions options) : base(options)
        {
        }
    }
}
