namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.score_of_return_cheques")]
    public partial class score_of_return_cheques
    {
        [Key]
        [Column(Order = 0)]
        public int id_src { get; set; }

        public int Count { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Return_cheques_id_rech { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Products_id_Pr { get; set; }

        public virtual products products { get; set; }
    }
}
