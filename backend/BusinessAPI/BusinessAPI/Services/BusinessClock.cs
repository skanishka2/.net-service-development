namespace BusinessAPI.Services
{
    public class BusinessClock
    {
        public GetClockResponse GetClockResponse()
        {
            var response = new GetClockResponse(true, null);
            return response;
        }
    }
}
