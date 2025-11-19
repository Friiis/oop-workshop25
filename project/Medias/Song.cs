namespace Domain;

class Song //abstract
{
    public string Composer { get; set; }
    public string singer { get; set; }
    public List<SongGenre> Genres { get; set; }
    public List<FileType> FileTypes { get; set; }
    public List<Language> Languages { get; set; }
    public int DurationInSeconds { get; set; }
}