namespace Vodenje_evidencije_specijalizanata_medicine.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RasporedPrograma")]
    public partial class RasporedPrograma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RasporedPrograma()
        {
            Specijalizacija = new HashSet<Specijalizacija>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string naziv_ustanove { get; set; }

        [Required]
        [StringLength(150)]
        public string naziv_odjela { get; set; }

        public int? godisnji_odmor { get; set; }

        [Column(TypeName = "date")]
        public DateTime trajanje_od { get; set; }

        [Column(TypeName = "date")]
        public DateTime trajanje_do { get; set; }

        [Required]
        [StringLength(150)]
        public string pravna_fizicka_osoba { get; set; }

        [Required]
        [StringLength(150)]
        public string ustrojstvena_jedinica { get; set; }

        public int mentor { get; set; }

        [StringLength(1000)]
        public string potpis_mentor { get; set; }

        [StringLength(1000)]
        public string potpis_gl_mentor { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specijalizacija> Specijalizacija { get; set; }
    }
}