namespace kata_gof_builder_pattern_shop_order_completion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuyNewClothes();
            BuyVoucher();
        }

        public static FulfilledOrder BuyNewClothes()
        {
            var builder = new ClothingFulfilledOrderBuilder();
            var director = new OrderFulfillmentDirector(builder);

            director.FulfillOrder();
            return director.GetFulfilledOrder();
        }

        public static FulfilledOrder BuyVoucher()
        {
            var builder = new VoucherFulfilledOrderBuilder();
            var director = new OrderFulfillmentDirector(builder);

            director.FulfillOrder();
            return director.GetFulfilledOrder();
        }
    }
}
