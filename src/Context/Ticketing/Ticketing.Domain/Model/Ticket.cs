using Framework.EventSourcing.DomainModel;
using Ticketing.Domain.Events;
using Ticketing.Domain.ValueObjects;

namespace Ticketing.Domain.Model;

public record TicketState(decimal Price, int Count, ShowId ShowId, ShowTime ShowTime, TicketClientId ReserverClientId);

public class Ticket : AggregateRoot
{
    private TicketState _currentState;

    public Ticket(ShowId showId, ShowTime showTime, TicketClientId reserverClientId)
    {
        _currentState = new TicketState(0, 0, showId, showTime, reserverClientId);
    }

    public void ReserveTicket(TicketClientId clientId, decimal price)
    {
        var @event = TicketReservedEvent.From(clientId, price);
        Events.Add(@event);
        Apply(@event);
    }

    private void Apply(TicketReservedEvent @event)
    { 
        _currentState = _currentState with
        {
            Price = @event.Price + _currentState.Price,
            Count = _currentState.Count + 1
        };
    }
}