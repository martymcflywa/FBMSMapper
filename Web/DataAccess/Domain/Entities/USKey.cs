using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.DataAccess.Domain.Entities
{
    public partial class USKey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USKey()
        {
            Scancodes = new HashSet<Scancode>();
        }

        [Key]
        public long KeyId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Key { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scancode> Scancodes { get; set; }
    }
}
