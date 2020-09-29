namespace WpfApp1.Data_base
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<cheques> cheques { get; set; }
        public virtual DbSet<count_products> count_products { get; set; }
        public virtual DbSet<deliverry> deliverry { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<job_status> job_status { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<providers> providers { get; set; }
        public virtual DbSet<_return> _return { get; set; }
        public virtual DbSet<return_cheques> return_cheques { get; set; }
        public virtual DbSet<score_of_cheques> score_of_cheques { get; set; }
        public virtual DbSet<score_of_delivery> score_of_delivery { get; set; }
        public virtual DbSet<score_of_return> score_of_return { get; set; }
        public virtual DbSet<score_of_return_cheques> score_of_return_cheques { get; set; }
        public virtual DbSet<shops> shops { get; set; }
        public virtual DbSet<status_shop> status_shop { get; set; }
        public virtual DbSet<workers> workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<employee>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<job_status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<job_status>()
                .HasMany(e => e.employee)
                .WithRequired(e => e.job_status)
                .HasForeignKey(e => e.Job_status_Status_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.Brend)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.count_products)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.Products_id_Pr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.score_of_cheques)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.Products_id_Pr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.score_of_delivery)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.Products_id_Pr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.score_of_return_cheques)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.Products_id_Pr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.score_of_return)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.Products_id_Pr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<providers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<providers>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<providers>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<providers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<providers>()
                .HasMany(e => e.deliverry)
                .WithRequired(e => e.providers)
                .HasForeignKey(e => e.Providers_id_prov)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<providers>()
                .HasMany(e => e._return)
                .WithRequired(e => e.providers)
                .HasForeignKey(e => e.Providers_id_prov)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shops>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<status_shop>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<status_shop>()
                .HasMany(e => e.shops)
                .WithRequired(e => e.status_shop)
                .HasForeignKey(e => e.Status_Shop_id_st)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<workers>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<workers>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<workers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<workers>()
                .Property(e => e.Spec)
                .IsUnicode(false);
        }
    }
}
