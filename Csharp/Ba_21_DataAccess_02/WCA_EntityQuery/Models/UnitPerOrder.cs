using System;
using System.Collections.Generic;

#nullable disable

namespace WCA_EntityQuery.Models
{
    public partial class UnitPerOrder
    {
        public int OrderId { get; set; }
        public int? UnitCount { get; set; }
    }
}
