namespace DatoriumMerch.Models
{
    public class Storage
    {
        public long Id { get; set; }
        public string? Location { get; set; }
        public ICollection<Merch>? Merches { get; set; }
    }
}
