using System;

namespace kata_gof_builder_pattern_shop_order_completion
{
    public class CreditCardPaymentProvider
    {
        public Guid ReservePayment(decimal amount)
        {
            return Guid.NewGuid();
        }
    }
}