﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamPlate
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExamPlateEntities : DbContext
    {
        public ExamPlateEntities()
            : base("name=ExamPlateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_Classes> TBL_Classes { get; set; }
        public virtual DbSet<TBL_Marks> TBL_Marks { get; set; }
        public virtual DbSet<TBL_Students> TBL_Students { get; set; }
    }
}
