namespace kata_gof_builder_pattern_shop_order_completion
{
    public class OrderFulfillmentDirector
    {
        private readonly FulfilledOrderBuilder _builder;

        public OrderFulfillmentDirector(FulfilledOrderBuilder builder)
        {
            _builder = builder;
        }

        public void FulfillOrder()
        {
            _builder.CreateFulfilledOrder();
            _builder.ReservePayment();
            _builder.ProduceAndShipOrder();
            _builder.SendInvoiceAndHandlePayment();
        }

        public FulfilledOrder GetFulfilledOrder()
        {
            return _builder.GetFulfilledOrder();
        }
    }
}