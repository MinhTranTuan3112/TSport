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
    [Table("Order")]
    public class Order : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public DateTime OrderDate { get; set; }

        public double Total { get; set; }

        public required string Status { get; set; } //Based on OrderStatus enum

       
        //Navigators
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

        public virtual ICollection<Payment> Payments { get; set; } = [];

    }
}
