namespace Domain;

class Podcast //abstract
{
    public list <string> Hosts { get; set; }
    public list <string> Guests { get; set; }
    public int EpisodeNumber { get; set; }
    public list <Language> Languages { get; set; }
}