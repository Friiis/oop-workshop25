namespace Domain;

class Movie //abstract
{
    public string Director { get; set; }
    public List<MovieGenre> Genres { get; set; }
    public List<Language> Languages { get; set; }
    public int DurationInSeconds { get; set; }
}