using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DataAccess.Domain.Entities
{
    public partial class Modifier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ModifierId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Description { get; set; }
    }
}
