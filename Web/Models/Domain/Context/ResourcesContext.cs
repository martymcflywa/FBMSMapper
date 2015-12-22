using System.Data.Entity;
using Web.Models.Domain.Config;
using Web.Models.Domain.Entities;

namespace Web.Models.Domain.Context
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
        public virtual DbSet<Modifier> Modifiers { get; set; }
        public virtual DbSet<Scancode> Scancodes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sound> Sounds { get; set; }
        public virtual DbSet<UiAttribute> UiAttributes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CallbackConfig());
        }
    }
}
