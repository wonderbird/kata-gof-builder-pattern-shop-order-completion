namespace kata_gof_builder_pattern_shop_order_completion
{
    public abstract class FulfilledOrderBuilder
    {
        protected FulfilledOrder _fulfilledOrder;

        public void CreateFulfilledOrder()
        {
            _fulfilledOrder = new FulfilledOrder();
        }

        public FulfilledOrder GetFulfilledOrder()
        {
            return _fulfilledOrder;
        }

        public abstract void ReservePayment();

        public abstract void ProduceAndShipOrder();

        public abstract void SendInvoiceAndHandlePayment();
    }
}