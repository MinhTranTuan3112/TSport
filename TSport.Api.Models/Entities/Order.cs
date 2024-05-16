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
    public class Order : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public double TotalPrice { get; set; }

        public required string OrderApiCode { get; set; }

        public required string Status { get; set; } //Based on OrderStatus enum

        public int AccountId { get; set; }

        public int PaymentId { get; set; }


        //Navigators
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

        public virtual Donation? Donation { get; set; }

        public virtual Account Account { get; set; } = null!;

        public virtual Payment Payment { get; set; } = null!;

    }
}
