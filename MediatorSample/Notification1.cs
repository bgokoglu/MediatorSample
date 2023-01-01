using MediatR;

namespace MediatorSample;

public class Notification1 : INotification
{
    public Notification1()
    {
        Id = 1;
    }

    public int Id { get; }
}