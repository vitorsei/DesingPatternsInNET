namespace CascadingFactories
{
    public interface IHotelSelector
    {
        HotelInfo SelectHotel(string town, string hotelName);
    }
}
