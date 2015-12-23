using System.Data.Entity;
using Web.DataAccess.Domain.Entities;

namespace Web.DataAccess.Domain.Context
{
    public partial class ResourcesContext : DbContext
    {
        public ResourcesContext()
            : base("name=ResourcesContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Callback> Callbacks { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<FrenchKey> FrenchKeys { get; set; }
        public virtual DbSet<GermanKey> GermanKeys { get; set; }
        public virtual DbSet<Modifier> Modifiers { get; set; }
        public virtual DbSet<Scancode> Scancodes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sound> Sounds { get; set; }
        public virtual DbSet<UIAttribute> UIAttributes { get; set; }
        public virtual DbSet<USKey> USKeys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Callbacks)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FrenchKey>()
                .HasMany(e => e.Scancodes)
                .WithRequired(e => e.FrenchKey)
                .HasForeignKey(e => e.FrenchId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GermanKey>()
                .HasMany(e => e.Scancodes)
                .WithRequired(e => e.GermanKey)
                .HasForeignKey(e => e.GermanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Callbacks)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USKey>()
                .HasMany(e => e.Scancodes)
                .WithRequired(e => e.USKey)
                .HasForeignKey(e => e.USId)
                .WillCascadeOnDelete(false);
        }
    }
}
