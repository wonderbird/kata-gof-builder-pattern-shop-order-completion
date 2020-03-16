using System;
using kata_gof_builder_pattern_shop_order_completion;
using Xunit;

namespace kata_gof_builder_shop_order_completion_tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_PerformsAllBuildSteps()
        {
            Program.Main(null);
            var fulfilledOrder = Program.FulfilledOrder;
            Assert.True(fulfilledOrder.IsPaymentReserved);
        }
    }
}
