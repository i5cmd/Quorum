namespace Quorum
{
    public class Projekt
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string ImgLink { get; set; } = string.Empty;
    }
}
