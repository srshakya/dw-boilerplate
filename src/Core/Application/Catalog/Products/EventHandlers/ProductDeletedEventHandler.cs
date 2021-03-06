using FSH.WebApi.Domain.Common.Events;

namespace FSH.WebApi.Application.Catalog.Products.EventHandlers;

public class ProductDeletedEventHandler : IEventNotificationHandler<EntityDeletedEvent<Product>>
{
    private readonly ILogger<ProductDeletedEventHandler> _logger;

    public ProductDeletedEventHandler(ILogger<ProductDeletedEventHandler> logger) => _logger = logger;

    public Task Handle(EventNotification<EntityDeletedEvent<Product>> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.Event.GetType().Name);
        return Task.CompletedTask;
    }
}