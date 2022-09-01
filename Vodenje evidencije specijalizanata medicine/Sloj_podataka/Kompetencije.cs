namespace Sloj_podataka
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kompetencije")]
    public partial class Kompetencije
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column("kompetencije")]
        [Required]
        [StringLength(1000)]
        public string kompetencije1 { get; set; }

        public int mentor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_mentor { get; set; }

        [StringLength(1000)]
        public string potpis_mentor { get; set; }

        public int? stupanj_napredovanja { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_gl_mentor { get; set; }

        [StringLength(1000)]
        public string potpis_gl_mentor { get; set; }

        public int specijalizacija { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Specijalizacija Specijalizacija1 { get; set; }
    }
}
