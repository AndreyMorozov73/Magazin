namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.return_cheques")]
    public partial class return_cheques
    {
        [Key]
        [Column(Order = 0)]
        public int id_rech { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Shops_id_s { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Workers_THP { get; set; }
    }
}
