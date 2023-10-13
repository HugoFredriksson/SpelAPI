namespace SpelAPI
{
    public class PlayerTopCharacters
    {
        public string player_name { get; set; }
        public int ranking { get; set; }
        public Character[] top_characters { get; set; } = new Character[5]; 
    }
}
