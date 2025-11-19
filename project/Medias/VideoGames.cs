namespace Domain;

class VideoGame //abstract
{
	public string Publisher { get; set; }
	public GameGenre Genre { get; set; }
    public list <SupportedPlatform> SupportedPlatforms { get; set; }

}