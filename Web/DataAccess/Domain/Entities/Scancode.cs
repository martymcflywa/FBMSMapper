using System.ComponentModel.DataAnnotations;

namespace Web.DataAccess.Domain.Entities
{
    public partial class Scancode
    {
        public long ScancodeId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Code { get; set; }

        public long USId { get; set; }

        public long GermanId { get; set; }

        public long FrenchId { get; set; }

        public virtual FrenchKey FrenchKey { get; set; }

        public virtual GermanKey GermanKey { get; set; }

        public virtual USKey USKey { get; set; }
    }
}
