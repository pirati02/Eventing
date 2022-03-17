using Framework.EventSourcing.Events;
using Ticketing.Domain.ValueObjects;

namespace Ticketing.Domain.Events;

public record TicketReservedEvent : VersionedEvent
{
    private readonly ReservationId _reservationId;
    private readonly ReservationTime _reservedAt;
    private readonly TicketClientId _reservedBy;
    public decimal Price { get; } 

    private TicketReservedEvent(
        ReservationId reservationId, 
        ReservationTime reservedAt,
        TicketClientId reservedBy,
        decimal price)
    {
        _reservationId = reservationId;
        _reservedAt = reservedAt;
        _reservedBy = reservedBy;
        Price = price;
    }

    public static TicketReservedEvent From(TicketClientId clientId, decimal price)
    {
        return new TicketReservedEvent(
            ReservationId.From(Guid.NewGuid()),
            ReservationTime.From(DateTimeOffset.UtcNow),
            clientId,
            price
        );
    }
}