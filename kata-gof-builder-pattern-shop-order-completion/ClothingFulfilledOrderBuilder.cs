namespace kata_gof_builder_pattern_shop_order_completion
{
    public class ClothingFulfilledOrderBuilder
    {
        private FulfilledOrder _fulfilledOrder;

        public void CreateFulfilledOrder()
        {
            _fulfilledOrder = new FulfilledOrder();
        }

        public void ReservePayment()
        {
            var paymentProvider = new CreditCardPaymentProvider();
            _fulfilledOrder.PaymentReferenceId = paymentProvider.ReservePayment(42.0m);
        }

        public void ProduceAndShipOrder()
        {
            var productionSystem = new ProductionSystem();
            _fulfilledOrder.ProductionFinishedTimeEstimate =
                productionSystem.ProduceAndShipOrder(_fulfilledOrder.OrderId);
        }

        public void SendInvoiceAndHandlePayment()
        {
            var billingSystem = new BillingSystem();
            _fulfilledOrder.InvoiceId =
                billingSystem.SendInvoice(_fulfilledOrder.OrderId);

            _fulfilledOrder.IsPayed = billingSystem.BookPayment(_fulfilledOrder.PaymentReferenceId);
        }


        public FulfilledOrder GetFulfilledOrder()
        {
            return _fulfilledOrder;
        }
    }
}