namespace Web.Models.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UiAttribute
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UiAttributeId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Description { get; set; }
    }
}
