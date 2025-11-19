namespace Domain;

class App //abstract
{
    public string Vesion { get; set; }
    public string Publisher { get; set; }
    public int FileSizeMB { get; set; }
    public List<SupportedPlatform> SupportedPlatforms { get; set; }
}