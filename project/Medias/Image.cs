namespace Domain;

class Image //abstract
{
    public int[][] Resolution { get; set; }
    public list <Filetype> FileTypes { get; set; }
    public int FileSize;
}