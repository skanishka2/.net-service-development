namespace BusinessAPI.Models
{
    public record GetClockResponse(bool IsOpen, DateTime? NextOpenTime);
}
