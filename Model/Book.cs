namespace Model;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateOnly PublicationDate { get; set; }
    public required string ISBN { get; set; }
}