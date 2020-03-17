An order is processed using the following steps:

1. Reserve the payment on the credit card
1. Produce and ship ordered item
1. Send invoice and book payment to order

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
