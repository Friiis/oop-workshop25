namespace Domain;

class EBooks //abstract
{
    public string Author { get; set; }
    public list <Language> language { get; set; }
    public int Pages { get; set; }
    public int ISBN { get; set; }
}