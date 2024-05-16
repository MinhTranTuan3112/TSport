﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }

        public int ShirtEditionId { get; set; }

        public int Quantity { get; set; }

        public double OrderDetailsTotal { get; set; }

        public required string Status { get; set; }

        //Navigators
        public virtual Order Order { get; set; } = null!;

        public virtual ShirtEdition ShirtEdition { get; set; } = null!;


    }
}
