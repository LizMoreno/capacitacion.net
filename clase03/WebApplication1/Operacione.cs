namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operacione
    {
        [Key]
        [StringLength(50)]
        public string order_id { get; set; }

        [StringLength(50)]
        public string account { get; set; }

        [StringLength(50)]
        public string symbol { get; set; }

        [StringLength(50)]
        public string transact_time { get; set; }

        [StringLength(50)]
        public string side { get; set; }

        [StringLength(50)]
        public string ord_type { get; set; }

        [StringLength(50)]
        public string order_price { get; set; }

        [StringLength(50)]
        public string order_size { get; set; }

        [StringLength(50)]
        public string exec_inst { get; set; }

        [StringLength(50)]
        public string time_in_force { get; set; }

        [StringLength(50)]
        public string expire_date { get; set; }

        [StringLength(50)]
        public string stop_px { get; set; }

        [StringLength(50)]
        public string last_cl_ord_id { get; set; }

        [StringLength(50)]
        public string text { get; set; }

        [StringLength(50)]
        public string exec_type { get; set; }

        [StringLength(50)]
        public string ord_status { get; set; }

        [StringLength(50)]
        public string last_price { get; set; }

        [StringLength(50)]
        public string last_qty { get; set; }

        [StringLength(50)]
        public string avg_price { get; set; }

        [StringLength(50)]
        public string cum_qty { get; set; }

        [StringLength(50)]
        public string leaves_qty { get; set; }
    }
}
