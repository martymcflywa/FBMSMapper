using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.DataAccess.Domain.Entities
{
    public partial class Sound
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SoundId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string File { get; set; }
    }
}
