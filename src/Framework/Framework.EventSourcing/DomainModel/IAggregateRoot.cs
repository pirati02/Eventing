using Framework.EventSourcing.ValueObject;

namespace Framework.EventSourcing.DomainModel;

public interface IAggregateRoot
{
    public AggregateId Id { get; }
}