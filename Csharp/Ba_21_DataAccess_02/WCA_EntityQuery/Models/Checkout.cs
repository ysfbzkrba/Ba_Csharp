using System;
using System.Collections.Generic;

#nullable disable

namespace WCA_EntityQuery.Models
{
    public partial class Checkout
    {
        public int OrderId { get; set; }
        public double? CheckoutTotal { get; set; }
    }
}
