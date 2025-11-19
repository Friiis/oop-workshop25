namespace Domain;

class App //abstract
{
    public string Vesion { get; set; }
    public string Publisher { get; set; }
    public int FileSizeMB { get; set; }
    public list <SupportedPlatform> SupportedPlatforms { get; set; }
}