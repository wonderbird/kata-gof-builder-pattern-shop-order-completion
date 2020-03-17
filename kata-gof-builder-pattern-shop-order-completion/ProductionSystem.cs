using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class ProductionSystem
    {
        public DateTime ProduceAndShipOrder(Guid orderId)
        {
            return DateTime.Now.AddHours(3.0);
        }
    }
}