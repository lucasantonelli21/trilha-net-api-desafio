using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api_desafio.Models;
namespace api_desafio.Context
{
   public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {    }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}