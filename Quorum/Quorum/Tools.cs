namespace Quorum
{
    public class Tools
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Desc { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public required string Category { get; set; }
    }
}
