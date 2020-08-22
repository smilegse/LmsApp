using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common
{
    public class Entity
    {
        public Entity()
        {
            Created = DateTime.Now;
        }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Id { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Created { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? Modified { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ModifiedBy { get; set; }
    }
}
