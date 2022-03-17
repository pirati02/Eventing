using Framework.EventSourcing.Events;
using Framework.EventSourcing.ValueObject;

namespace Framework.EventSourcing.DomainModel;

public class AggregateRoot: IAggregateRoot
{
    public AggregateId Id { get; init; }
    protected readonly IList<IEvent> Events = new List<IEvent>();
    
    
}