namespace MedicoDent.Application.Filters
{
    public class PacijentSearchFilter
    {
        public string? SearchTerm { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;

        public int? GroupId { get; set; }
    }
}
