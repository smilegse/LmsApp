using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Common;

namespace Model
{
    public class Course : Entity
    {
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string ImageUrl { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string TrainerName { get; set; }

        //public string TrainerId { get; set; }

        public double AverageRating { get; set; }
        public int EnrolledCount { get; set; }
        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
        public bool IsFree { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Topic { get; set; }
        public int TotalDurationHour { get; set; }
        public int TotalLectureCount { get; set; }
        public StudentLevel StudentLevel { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Language { get; set; }
        public int ViewCount { get; set; }

    }

    public enum StudentLevel
    {
        Beginner=0,
        Intermediate,
        Expert
    }
}
