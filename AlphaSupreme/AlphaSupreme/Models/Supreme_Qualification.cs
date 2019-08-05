namespace AlphaSupreme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supreme_Qualification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QualificationID { get; set; }

        [Required]
        public string QualificationName { get; set; }

        public bool IsActive { get; set; }
    }
}
