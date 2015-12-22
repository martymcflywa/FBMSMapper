namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Scancode
    {
        public long ScancodeId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Code { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string US { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string German { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string French { get; set; }
    }
}
