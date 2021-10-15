using MediatR;

namespace Ignite.Mediatr.Events
{
    public class EmployeeCreatedEvent : INotification
    {
        public EmployeeCreatedEvent(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}