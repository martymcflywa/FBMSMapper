using DataAccess.Config;

namespace DataAccess.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Resources : DbContext
    {
        public Resources()
            : base("name=Resources")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Callback> Callbacks { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Modifier> Modifiers { get; set; }
        public virtual DbSet<Scancode> Scancodes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sound> Sounds { get; set; }
        public virtual DbSet<UiAttribute> UiAttributes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CallbackConfig());
//            modelBuilder.Entity<Category>()
//                .HasMany(e => e.Callbacks)
//                .WithRequired(e => e.Category)
//                .WillCascadeOnDelete(false);
//
//            modelBuilder.Entity<Section>()
//                .HasMany(e => e.Callbacks)
//                .WithRequired(e => e.Section)
//                .WillCascadeOnDelete(false);
        }
    }
}
