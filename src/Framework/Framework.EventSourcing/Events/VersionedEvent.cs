using Framework.EventSourcing.ValueObject;

namespace Framework.EventSourcing.Events;

public record VersionedEvent: IVersionedEvent
{
    public EventId Id { get; set; } = new();
    public int Version { get; }
}