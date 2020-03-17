using System;
using kata_gof_builder_pattern_shop_order_completion;
using Xunit;

namespace kata_gof_builder_shop_order_completion_tests
{
    public class ProgramTests
    {
        [Fact]
        public void BuyNewClothes_PerformsAllBuildSteps()
        {
            var fulfilledOrder = Program.BuyNewClothes();

            Assert.NotEqual(Guid.Empty, fulfilledOrder.PaymentReferenceId);
            Assert.True(fulfilledOrder.ProductionFinishedTimeEstimate >= DateTime.Now);
            Assert.NotEqual(Guid.Empty, fulfilledOrder.InvoiceId);
        }

        [Fact]
        public void BuyVoucher_PerformsAllBuildSteps()
        {
            var fulfilledOrder = Program.BuyVoucher();

            Assert.NotEqual(Guid.Empty, fulfilledOrder.PaymentReferenceId);
            Assert.True(fulfilledOrder.ProductionFinishedTimeEstimate >= DateTime.Now);
            Assert.NotEqual(Guid.Empty, fulfilledOrder.InvoiceId);
        }
    }
}
