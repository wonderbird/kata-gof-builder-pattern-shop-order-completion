using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class VoucherFulfilledOrderBuilder : FulfilledOrderBuilder
    {
        public override void ReservePayment()
        {
            // Reserve a payment using your payment provider
            _fulfilledOrder.PaymentReferenceId = Guid.NewGuid();
        }

        public override void ProduceAndShipOrder()
        {
            // Use a voucher management system to create the voucher
            // and to send it to the customer
            _fulfilledOrder.ProductionFinishedTimeEstimate = DateTime.Now.AddMinutes(5.0);
        }

        public override void SendInvoiceAndHandlePayment()
        {
            // Use a billing system to send the invoice and
            // to book the incoming money to the order later
            _fulfilledOrder.InvoiceId = Guid.NewGuid();
            _fulfilledOrder.IsPayed = true;
        }
    }
}