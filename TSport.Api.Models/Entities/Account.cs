using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Models.Entities
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpireTime { get; set; }

        public required string Role { get; set; } //Based on Role enum

        //Navigators
        

    }
}
