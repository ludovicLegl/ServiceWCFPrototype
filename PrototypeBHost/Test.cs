namespace PrototypeBHost
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Test")]
    public partial class Test
    {
        [Key]
        public Guid Id_test { get; set; }

        [StringLength(50)]
        public string tes_test { get; set; }
    }
}
