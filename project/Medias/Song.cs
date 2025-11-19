namespace Domain;

class Song //abstract
{
    public string Composer { get; set; }
    public string singer { get; set; }
    public list <SongGenre> Genres { get; set; }
    public list <FileType> FileTypes { get; set; }
    public list <Language> Languages { get; set; }
    public int DurationInSeconds { get; set; }
}