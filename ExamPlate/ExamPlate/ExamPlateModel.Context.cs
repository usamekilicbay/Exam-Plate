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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        public virtual DbSet<TBL_Grades> TBL_Grades { get; set; }
        public virtual DbSet<TBL_Students> TBL_Students { get; set; }
    
        public virtual ObjectResult<GRADE_LIST_Result> GRADE_LIST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GRADE_LIST_Result>("GRADE_LIST");
        }
    }
}
