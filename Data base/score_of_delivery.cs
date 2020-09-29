namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.score_of_delivery")]
    public partial class score_of_delivery
    {
        [Key]
        [Column(Order = 0)]
        public int id_sd { get; set; }

        public int Count { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Deliverry_id_d { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Products_id_Pr { get; set; }

        public virtual products products { get; set; }
    }
}
