namespace ResourcesApi.Models
{
    public class ResourceApplicationPeriod
    {
        public int Id { get; set; }
        public string? Month { get; set; }
        public Resource Resource { get; set; } = null!;
    }
}