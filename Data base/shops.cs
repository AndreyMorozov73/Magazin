namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.shops")]
    public partial class shops
    {
        [Key]
        [Column(Order = 0)]
        public int id_s { get; set; }

        [Required]
        [StringLength(45)]
        public string Adress { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status_Shop_id_st { get; set; }

        public virtual status_shop status_shop { get; set; }
    }
}
