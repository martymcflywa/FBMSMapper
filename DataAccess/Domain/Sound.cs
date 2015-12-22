namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sound
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SoundId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string File { get; set; }
    }
}
