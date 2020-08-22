using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Common;
using Common.Model;

namespace Model
{
    public class Course : Entity
    {
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string CourseName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string TrainerName { get; set; }

        //public string TrainerId { get; set; }

        [DefaultValue(0.00)]
        [Column(TypeName = "numeric(18,2)")]
        public double? AverageRating { get; set; }

        [DefaultValue(0)]
        public int? EnrolledCount { get; set; }

        [DefaultValue(0.00)]
        [Column(TypeName = "numeric(18,2)")]
        public double? RegularPrice { get; set; }

        [DefaultValue(0.00)]
        [Column(TypeName = "numeric(18,2)")]
        public double? DiscountPrice { get; set; }

        [DefaultValue("False")]
        public bool IsFree { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Topic { get; set; }

        [DefaultValue(0)]
        public int? TotalDurationHour { get; set; }

        [DefaultValue(0)]
        public int? TotalLectureCount { get; set; }

        public StudentLevel? StudentLevel { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Language { get; set; }

        [DefaultValue(0)]
        public int? ViewCount { get; set; }

    }

    public enum StudentLevel
    {
        Beginner=0,
        Intermediate,
        Expert
    }
}
