using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class FulfilledOrder
    {
        public Guid OrderId { get; } = Guid.NewGuid();
        public Guid PaymentReferenceId { get; set; }
        public DateTime ProductionFinishedTimeEstimate { get; set; }
        public Guid InvoiceId { get; set; }
        public bool IsPayed { get; set; }
    }
}