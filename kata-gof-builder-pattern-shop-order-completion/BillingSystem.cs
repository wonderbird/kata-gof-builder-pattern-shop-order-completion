using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class BillingSystem
    {
        public Guid SendInvoice(Guid orderId)
        {
            return Guid.NewGuid();
        }

        public bool BookPayment(Guid fulfilledOrderPaymentReferenceId)
        {
            return true;
        }
    }
}