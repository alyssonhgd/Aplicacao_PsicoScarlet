using Aplicacao_PsicoScarlet.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;

namespace Aplicacao_PsicoScarlet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Paciente",
                NormalizedName = "PACIENTE",
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),

            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }

        public DbSet<Agenda> Agenda  { get; set;}
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<NotaFiscal> NotaFiscal { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Prontuario> Prontuario { get; set;}
    }

 

    
}
