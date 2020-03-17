namespace kata_gof_builder_pattern_shop_order_completion
{
    public class OrderFulfillmentDirector
    {
        private readonly ClothingFulfilledOrderBuilder _builder;

        public OrderFulfillmentDirector(ClothingFulfilledOrderBuilder builder)
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