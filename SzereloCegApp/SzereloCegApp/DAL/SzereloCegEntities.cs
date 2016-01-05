﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using SzereloCegApp.Models;

namespace SzereloCegApp.DAL
{
    public class SzereloCegEntities : DbContext
    {
        public DbSet<Szerelo> Szerelok { get; set; }
        public DbSet<Ugyfel> Ugyfelek { get; set; }
        public DbSet<Diagnosztika> Diagnosztikák { get; set; }
        public DbSet<GepJarmu> GepJarmuvek { get; set; }



        //
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {                     
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //TODO: ErrorHandling -> controller(fkey adatbázispusztulásos)
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}