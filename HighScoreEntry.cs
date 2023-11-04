[Serializable]
public class HighScoreEntry
{
    public string PlayerName { get; set; }
    public int Score { get; set; }

    public HighScoreEntry(string playerName, int score)
    {
        PlayerName = playerName;
        Score = score;
    }
}









