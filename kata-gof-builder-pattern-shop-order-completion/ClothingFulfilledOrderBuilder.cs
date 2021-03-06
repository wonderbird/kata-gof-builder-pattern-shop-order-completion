﻿using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class ClothingFulfilledOrderBuilder : FulfilledOrderBuilder
    {
        public override void ReservePayment()
        {
            // Reserve a payment using your payment provider
            _fulfilledOrder.PaymentReferenceId = Guid.NewGuid();
        }

        public override void ProduceAndShipOrder()
        {
            // Use a production system to order the necessary goods
            // and to produce the order
            _fulfilledOrder.ProductionFinishedTimeEstimate = DateTime.Now.AddHours(3.0);
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