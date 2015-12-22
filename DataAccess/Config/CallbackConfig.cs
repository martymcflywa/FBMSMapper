using System.Data.Entity.ModelConfiguration;
using DataAccess.Domain;

namespace DataAccess.Config
{
    public class CallbackConfig : EntityTypeConfiguration<Callback>
    {
        public CallbackConfig()
        {
            Property(c => c.Command)
                .IsRequired()
                .HasMaxLength(2000);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            HasRequired(c => c.Category)
                .WithMany(c => c.Callbacks)
                .HasForeignKey(c => c.CategoryId)
                .WillCascadeOnDelete(true);

            HasRequired(c => c.Section)
                .WithMany(c => c.Callbacks)
                .HasForeignKey(c => c.SectionId)
                .WillCascadeOnDelete(true);
        }
    }
}
