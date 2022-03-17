using ValueOf;

namespace Framework.EventSourcing.ValueObject;

public sealed class EventId: ValueOf<Guid, EventId>
{
}