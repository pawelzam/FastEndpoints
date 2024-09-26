
using FastEndpoints;

namespace API.Orders;

public class Orders : Endpoint<OrderRequest, OrderResponse>
{
    public override void Configure()
    {
        Post("/orders");
        AllowAnonymous();
    }

    public override Task<OrderResponse> ExecuteAsync(OrderRequest req, CancellationToken ct)
    {
        return Task.FromResult(new OrderResponse(Guid.NewGuid()));
    }
}
