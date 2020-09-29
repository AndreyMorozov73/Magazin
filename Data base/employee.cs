namespace WpfApp1.Data_base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("magazin.employee")]
    public partial class employee
    {
        [Key]
        [Column("№", Order = 0)]
        public int C_ { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_end { get; set; }

        [StringLength(45)]
        public string Reason { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Job_status_Status_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Workers_THP { get; set; }

        public virtual job_status job_status { get; set; }
    }
}
