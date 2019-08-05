namespace AlphaSupreme.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supreme_CourseMaster
    {
        [Key]
        public int CourseID { get; set; }

        [Required]
        public string CourseName { get; set; }

        public bool IsActive { get; set; }
    }
}
