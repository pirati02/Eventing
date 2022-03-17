using Framework.EventSourcing.ValueObject;

namespace Framework.EventSourcing.Events;

public interface IEvent
{
    public EventId Id { get; }
}