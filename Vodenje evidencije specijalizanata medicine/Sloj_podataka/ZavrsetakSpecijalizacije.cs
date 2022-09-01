namespace Sloj_podataka
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZavrsetakSpecijalizacije")]
    public partial class ZavrsetakSpecijalizacije
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int specijalizacija { get; set; }

        [StringLength(1000)]
        public string misljenje_gl_mentora { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_zavrsetka { get; set; }

        [StringLength(1000)]
        public string potpis_gl_mentor { get; set; }

        public virtual Specijalizacija Specijalizacija1 { get; set; }
    }
}
