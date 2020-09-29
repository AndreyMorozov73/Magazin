namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.workers")]
    public partial class workers
    {
        [Key]
        [Column(Order = 0)]
        public int THP { get; set; }

        [Required]
        [StringLength(45)]
        public string FIO { get; set; }

        [Required]
        [StringLength(45)]
        public string Tel { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        [StringLength(45)]
        public string Spec { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shops_id_s { get; set; }
    }
}
