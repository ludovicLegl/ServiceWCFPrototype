namespace PrototypeBHost
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [Key]
        public Guid id_patient { get; set; }

        [StringLength(255)]
        public string pat_nom { get; set; }

        [StringLength(255)]
        public string pat_prenom { get; set; }

        public DateTime? pat_datenaissance { get; set; }

        [StringLength(255)]
        public string pat_adresse { get; set; }

        public int? pat_npa { get; set; }

        [StringLength(255)]
        public string pat_ville { get; set; }

        [StringLength(255)]
        public string pat_pays { get; set; }

        [StringLength(255)]
        public string pat_Natel { get; set; }

        [StringLength(255)]
        public string pat_Teleèhone { get; set; }

        [StringLength(255)]
        public string pat_nomMere { get; set; }

        [StringLength(255)]
        public string pat_prenomMere { get; set; }

        [StringLength(255)]
        public string pat_nomPere { get; set; }

        [StringLength(255)]
        public string pat_prenomPere { get; set; }

        public DateTime pat_creation { get; set; }

        public DateTime pat_update { get; set; }

        public Guid pat_id_cabinet { get; set; }

        public Guid pat_id_utilisateur { get; set; }
    }
}
