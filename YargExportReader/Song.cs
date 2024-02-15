namespace YargExportReader;

public class Song
{
    private int _songLength;

    public string Artist { get; set; } = "";

    public string Name { get; set; } = "";

    public string Album { get; set; } = "";

    public string Genre { get; set; } = "";

    public string Charter { get; set; } = "";

    public string Year { get; set; } = "";

    public string SongLength
    {
        get
        {
            var seconds = _songLength / 1000;
            var minutes = seconds / 60;
            seconds %= 60;
            return $"{minutes}:{seconds:D2}";
        }
        set => _songLength = int.Parse(value);
    }
}