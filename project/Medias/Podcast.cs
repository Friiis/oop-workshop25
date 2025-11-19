namespace Domain;

class Podcast //abstract
{
    public List<string>? Hosts { get; set; }
    public List<string>? Guests { get; set; }
    public int EpisodeNumber { get; set; }
    public List<Language>? Languages { get; set; }
	public SongGenre? genre;
}