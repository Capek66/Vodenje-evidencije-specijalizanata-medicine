namespace Vodenje_evidencije_specijalizanata_medicine.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zahvati")]
    public partial class Zahvati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zahvati()
        {
            Specijalizacija = new HashSet<Specijalizacija>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string naziv_zahvata { get; set; }

        public int broj_zahvata { get; set; }

        public int? mentor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_mentor { get; set; }

        [StringLength(1000)]
        public string potpis_mentor { get; set; }

        public int? stupanj_napredovanja { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_gl_mentor { get; set; }

        [StringLength(1000)]
        public string potpis_gl_mentor { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specijalizacija> Specijalizacija { get; set; }
    }
}
