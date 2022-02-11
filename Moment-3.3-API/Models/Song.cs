namespace Moment_3._3_API.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Artist { get; set; } = string.Empty;
        public int Length { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
