using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App_Piemonte.Models;

namespace App_Piemonte.Data
{
    public class App_PiemonteContext : DbContext
    {
        public App_PiemonteContext (DbContextOptions<App_PiemonteContext> options)
            : base(options)
        {
        }

        public DbSet<App_Piemonte.Models.Departamento> Departamento { get; set; }
    }
}
