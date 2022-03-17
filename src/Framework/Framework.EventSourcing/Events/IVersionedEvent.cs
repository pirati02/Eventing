namespace Framework.EventSourcing.Events;

public interface IVersionedEvent : IEvent
{
    public int Version { get; }
}