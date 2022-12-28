using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext:DbContext
    {

        public BancoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos {get;set;}
    }
}