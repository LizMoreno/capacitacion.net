namespace ABMwithMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_Users
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? Active { get; set; }
    }
}
