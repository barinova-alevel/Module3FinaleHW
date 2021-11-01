using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersOrders
{
    public class Order
    {
        public string OrderId { get; init; }
        public string UserId { get; init; }
        public string OrderNumber { get; init; }
        public string OrderDate { get; init; }
        public string Total { get; init; }

    }
}
