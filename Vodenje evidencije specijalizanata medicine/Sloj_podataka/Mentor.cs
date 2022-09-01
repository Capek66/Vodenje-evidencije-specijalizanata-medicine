namespace Sloj_podataka
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mentor")]
    public partial class Mentor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int korisnik { get; set; }

        [Required]
        [StringLength(500)]
        public string ustanova { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }
    }
}
