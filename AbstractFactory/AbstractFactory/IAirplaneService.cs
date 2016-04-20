using System;

namespace CascadingFactories
{
    public interface IAirplaneService
    {
        IVacationPart SelectFlight(string companyName, string origin, string destination, DateTime travelDate);
    }
}
