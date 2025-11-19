namespace Domain;

class VideoGame //abstract
{
	public string Publisher { get; set; }

	public List<GameGenre> Genres { get; set; }
    public List<SupportedPlatform> SupportedPlatforms { get; set; }
}