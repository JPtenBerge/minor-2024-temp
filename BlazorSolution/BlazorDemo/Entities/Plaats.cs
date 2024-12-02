namespace BlazorDemo.Entities;

public class Plaats
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required int Rating { get; set; }

    public required string PhotoUrl { get; set; }
}
