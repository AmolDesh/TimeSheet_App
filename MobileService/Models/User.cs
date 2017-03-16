using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MobileService.Models
{
    [Table("AD_Customer")]
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar")]
        [DisplayFormat(DataFormatString="{0:d}")]
        public string Date { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar")]
        public string From { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar")]
        public string To { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(200)]
        public string Comments { get; set; }
    }
}