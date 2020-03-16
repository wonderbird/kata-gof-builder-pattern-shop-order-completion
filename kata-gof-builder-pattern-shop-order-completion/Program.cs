using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class Program
    {
        public static FulfilledOrder FulfilledOrder;

        public static void Main(string[] args)
        {
            FulfilledOrder = new FulfilledOrder();

            var paymentProvider = new CreditCardPaymentProvider();
            FulfilledOrder.IsPaymentReserved = paymentProvider.ReservePayment(42.0m);
        }
    }
}
