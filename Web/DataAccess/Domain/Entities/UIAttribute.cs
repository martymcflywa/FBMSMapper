using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DataAccess.Domain.Entities
{
    public partial class UIAttribute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UIAttributeId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Description { get; set; }
    }
}
