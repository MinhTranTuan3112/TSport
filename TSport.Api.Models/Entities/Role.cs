using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class Role : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }  //Based on Role enum

        //Navigators
        public virtual ICollection<Account> Accounts { get; set; } = [];
        
        public virtual ICollection<Permission> Permissions { get; set; } = [];

    }
}
