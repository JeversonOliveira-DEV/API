using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Dio.Entities;
using API_Dio.Context;

namespace API_Dio.Context
{
    public class AgendaContext : DbContext
    {
        public  AgendaContext (DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contat> Contatos { get; set; }
    }
}