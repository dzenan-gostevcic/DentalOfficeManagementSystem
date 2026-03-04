namespace MedicoDent.Application.Filters
{
    public class PacijentSearchFilter
    {
        public string? SearchTerm { get; set; }
        public int Page { get; set; } 
        public int PageSize { get; set; } 

        public int? GroupId { get; set; }
        public int PageNumber { get; set; }
    }
}
