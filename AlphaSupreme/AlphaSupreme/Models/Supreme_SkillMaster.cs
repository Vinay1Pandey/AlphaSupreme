namespace AlphaSupreme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supreme_SkillMaster
    {
        [Key]
        public int SkillID { get; set; }

        [Required]
        public string SkillName { get; set; }

        public bool IsActive { get; set; }
    }
}
