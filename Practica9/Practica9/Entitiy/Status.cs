namespace Practica9.Entitiy;

public class Status
{

    public int Id { get; set; }
    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime SharedDate { get; set; }


    public Status(string title,string content)
    {

        Title = title;
        Content = content;
        SharedDate = DateTime.Now;
    }
    public void GetStatusInfo()
    {


        Console.WriteLine($"Title: {Title} - Content: {Content} - shared {(DateTime.Now.Ticks - SharedDate.Ticks )/10000000} seconds ago");
    }
}
