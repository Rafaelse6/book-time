namespace BookTime.Shared.DTOs
{
    public record PagedResult<TRecords>(TRecords[] Records, int TotalCount);
}
