namespace SpelAPI
{
    public class PlayerLatestGame
    {
        public int game_id { get; set; }
        public DateTime timestamp { get; set; }
        public int score { get; set; }
        public int duration_minutes { get; set; }
        public string player_name { get; set; }
        public int ranking { get; set; }
    }
}
