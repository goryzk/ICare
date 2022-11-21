using ICare.Application.Common.Interfaces;

namespace ICare.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
