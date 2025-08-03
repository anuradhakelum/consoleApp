namespace RandomTextGenerator.Models
{
    public class Options
    {
        public int Length { get; set; } = 10;
        public bool Numeric { get; set; } = false;
        public bool SpecialCharacter { get; set; } = false;
    }
}
