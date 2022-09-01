namespace Sloj_podataka
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specijalizant")]
    public partial class Specijalizant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int korisnik { get; set; }

        public int godina_specijalizacije { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }
    }
}
