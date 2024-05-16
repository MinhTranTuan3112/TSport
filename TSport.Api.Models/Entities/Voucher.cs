using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class Voucher : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Type { get; set; } //Based on VoucherType enum

        public double DiscountPercentage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //Navigators
        public virtual ICollection<Account> Accounts { get; set; } = [];
    }
}