namespace Domain;

class Song //abstract
{
    public string Composer { get; set; }
    public string singer { get; set; }
<<<<<<< HEAD
    public list <SongGenre> Genres { get; set; }
    public list <FileType> FileTypes { get; set; }
    public list <Language> Languages { get; set; }
    public int DurationInSeconds { get; set; }
=======
    public Language language { get; set; }
    public SongGenre genre;
>>>>>>> 067439c22d15e105ab3e2994e8c72fa4066636f8
}