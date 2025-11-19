namespace Domain;

class VideoGame //abstract
{
	public string Publisher { get; set; }
	public list <GameGenre> Genres { get; set; }
    public list <SupportedPlatform> SupportedPlatforms { get; set; }

}