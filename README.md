An order is processed using the following steps:

1. Reserve the payment on the credit card
1. Create bill of materials for order
1. Block available parts
1. Order missing parts
1. Allocate manufacturing time
1. Produce ordered item
1. Ship order
1. Book money to order

You have the following APIs:

class BillOfMaterials {
  public 
}

interface IPaymentProvider {
  bool hasSufficientBalance(decimal amount);
}

interface IEnterpriseResourcePlanning {
  List<Guid> assembleBillOfMaterials(Guid productId)
}

interface IWarehouse {
  bool blockPart(Guid partId)
}

Your program should

1. Print the step name for each step
