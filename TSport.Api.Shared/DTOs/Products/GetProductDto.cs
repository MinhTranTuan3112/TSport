using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Shared.DTOs.Products
{
    public record GetProductDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public required string Size { get; set; } //Based on ShirtSize enum

        public string? Description { get; set; }

        public int ClubId { get; set; }
    }
}
