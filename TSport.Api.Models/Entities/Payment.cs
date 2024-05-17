using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    [Table("Payment")]
    public class Payment : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string PaymentType { get; set; } //Based on PaymentType enum

        public required string ProviderName { get; set; }

        public required string Status { get; set; }

        public int? OrderId { get; set; }

        //Navigators
        public virtual Order? Order { get; set; } 

    }
}