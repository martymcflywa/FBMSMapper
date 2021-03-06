using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.DataAccess.Domain.Entities
{
    public partial class Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            Callbacks = new HashSet<Callback>();
        }

        public long SectionId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Callback> Callbacks { get; set; }
    }
}
