﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GibddApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GIBDDDatabaseEntities : DbContext
    {
        public GIBDDDatabaseEntities()
            : base("name=GIBDDDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Автомобили> Автомобили { get; set; }
        public virtual DbSet<Взыскания> Взыскания { get; set; }
        public virtual DbSet<Водители> Водители { get; set; }
        public virtual DbSet<Инспектора> Инспектора { get; set; }
        public virtual DbSet<НарушенияВодителей> НарушенияВодителей { get; set; }
        public virtual DbSet<НарушенияПДД> НарушенияПДД { get; set; }
    }
}
