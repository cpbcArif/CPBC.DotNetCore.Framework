using CPBC.DotNetCore.Common.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPBC.DotNetCore.DAL.Core
{
    public class CPBCDataContext : DbContext
    {        
        //protected CPBCDataContext(): base()
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=CPBC-TSQL003;Initial Catalog=Experiment;Integrated Security=true; Timeout=500000;");
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {           
            base.OnModelCreating(modelbuilder);

            //modelbuilder.Entity<QuestionBank>()
            //    .HasOne(q => q.MasterItem).w
                
        }

        //entities
        public DbSet<QuestionBank> QuestionBanks { get; set; }
    }
}
