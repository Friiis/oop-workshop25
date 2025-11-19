namespace DataAccess;

public class DataManager
{
    List<string[][]> eBooksTable;


    public DataManager()
    {
        string[][] strings = new string[][]
        {
                new string[]{"Title", "0"},
                new string[]{"ID", "0"},
                new string[]{"Description", "0"},
                new string[]{"Rating", "0"},
                new string[]{"ReleaseYear", "0"},
                new string[]{"BorrowedBy", "0"},
                new string[]{"PreviousUsers", "0"},
                new string[]{"Author", "0"},
                new string[]{"Languages", "0"},
                new string[]{"Pages", "0"},
                new string[]{"ISBN", "0"}
        };

        eBooksTable = new List<string[][]>()
        {
            new string[][]
            {
                new string[]{"Title", "0"},
                new string[]{"ID", "0"},
                new string[]{"Description", "0"},
                new string[]{"Rating", "0"},
                new string[]{"ReleaseYear", "0"},
                new string[]{"BorrowedBy", "0"},
                new string[]{"PreviousUsers", "0"},
                new string[]{"Author", "0"},
                new string[]{"Languages", "0"},
                new string[]{"Pages", "0"},
                new string[]{"ISBN", "0"}
            },
            new string[][]
            {
                new string[]{"Title", "1"},
                new string[]{"ID", "1"},
                new string[]{"Description", "1"},
                new string[]{"Rating", "1"},
                new string[]{"ReleaseYear", "1"},
                new string[]{"BorrowedBy", "1"},
                new string[]{"PreviousUsers", "1"},
                new string[]{"Author", "1"},
                new string[]{"Languages", "1"},
                new string[]{"Pages", "1"},
                new string[]{"ISBN", "1"}
            },
            new string[][]
            {
                new string[]{"Title", "2"},
                new string[]{"ID", "2"},
                new string[]{"Description", "2"},
                new string[]{"Rating", "2"},
                new string[]{"ReleaseYear", "2"},
                new string[]{"BorrowedBy", "2"},
                new string[]{"PreviousUsers", "2"},
                new string[]{"Author", "2"},
                new string[]{"Languages", "2"},
                new string[]{"Pages", "2"},
                new string[]{"ISBN", "2"}
            },
            new string[][]
            {
                new string[]{"Title", "3"},
                new string[]{"ID", "3"},
                new string[]{"Description", "3"},
                new string[]{"Rating", "3"},
                new string[]{"ReleaseYear", "3"},
                new string[]{"BorrowedBy", "3"},
                new string[]{"PreviousUsers", "3"},
                new string[]{"Author", "3"},
                new string[]{"Languages", "3"},
                new string[]{"Pages", "3"},
                new string[]{"ISBN", "3"}
            }
        };
    }

    public List<string[][]> LoadMediaEBooks()
    {
        return eBooksTable;
    }

    public void AddMediaEbook(string[][] newEBook)
    {
        eBooksTable.Add(newEBook);
    }

    public void RemoveMediaBook(string bookID)
    {
        for (int i = 0; i < eBooksTable.Count; i++)
        {
            //Remove media

        }
    }

}