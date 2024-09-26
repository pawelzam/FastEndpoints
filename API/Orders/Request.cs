namespace API.Orders;

public record OrderRequest(OrderItem[] Items);

public record OrderItem (string Name);
