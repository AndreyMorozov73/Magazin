namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.products")]
    public partial class products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public products()
        {
            count_products = new HashSet<count_products>();
            score_of_cheques = new HashSet<score_of_cheques>();
            score_of_delivery = new HashSet<score_of_delivery>();
            score_of_return_cheques = new HashSet<score_of_return_cheques>();
            score_of_return = new HashSet<score_of_return>();
        }

        [Key]
        public int id_Pr { get; set; }

        [Required]
        [StringLength(45)]
        public string Barcode { get; set; }

        [Required]
        [StringLength(45)]
        public string Group { get; set; }

        [Required]
        [StringLength(45)]
        public string Brend { get; set; }

        [StringLength(45)]
        public string Model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<count_products> count_products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<score_of_cheques> score_of_cheques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<score_of_delivery> score_of_delivery { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<score_of_return_cheques> score_of_return_cheques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<score_of_return> score_of_return { get; set; }
    }
}
