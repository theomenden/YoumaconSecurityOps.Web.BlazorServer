﻿namespace YoumaconSecurityOps.Core.Mediatr.Handlers.NotificationHandlers;

internal class ShiftLogQueriedEventHandler : INotificationHandler<ShiftLogQueriedEvent>
{
    private readonly IEventStoreRepository _eventStore;

    private readonly IMediator _mediator;

    private ILogger<ShiftLogQueriedEventHandler> _logger;

    public ShiftLogQueriedEventHandler(IEventStoreRepository eventStore, IMediator mediator, ILogger<ShiftLogQueriedEventHandler> logger)
    {
        _eventStore = eventStore;
        _mediator = mediator;
        _logger = logger;
    }


    public async Task Handle(ShiftLogQueriedEvent notification, CancellationToken cancellationToken)
    {
        var @event = new EventReader
        {
            Aggregate = notification.Aggregate,
            Data = notification.DataAsJson,
            MajorVersion = notification.MajorVersion,
            MinorVersion = notification.MinorVersion,
            Name = notification.Name
        };

        var previousEventsOnAggregate = new List<EventReader> { @event };

        await _eventStore.SaveAsync(notification.Id, notification.MinorVersion, previousEventsOnAggregate.ToList().AsReadOnly(),
            notification.Aggregate, cancellationToken);
    }
}