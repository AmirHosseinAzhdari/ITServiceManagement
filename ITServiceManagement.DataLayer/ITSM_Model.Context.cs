﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITServiceManagement.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ITServiceManagement_DBEntities : DbContext
    {
        public ITServiceManagement_DBEntities()
            : base("name=ITServiceManagement_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TicketStatus> TicketStatus { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTickets> UserTickets { get; set; }
    }
}
