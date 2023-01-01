using MediatR;

namespace MediatorSample;

public class Notification2 : INotification
{
    public Notification2()
    {
        Id = 2;
    }

    public int Id { get; }
}