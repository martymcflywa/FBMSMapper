using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.DataAccess.Domain.Entities
{
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Callbacks = new HashSet<Callback>();
        }

        public long CategoryId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Callback> Callbacks { get; set; }
    }
}
