namespace Web.Models.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Callback
    {
        public long CallbackId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Command { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Description { get; set; }

        public long CategoryId { get; set; }

        public long SectionId { get; set; }

        public virtual Section Section { get; set; }

        public virtual Category Category { get; set; }
    }
}
