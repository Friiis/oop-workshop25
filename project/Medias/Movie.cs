namespace Domain;

class Movie //abstract
{
    public string Director { get; set; }
    public list <MovieGenre> Genres { get; set; }
    public list <Language> Languages { get; set; }
    public int DurationInSeconds { get; set; }
}