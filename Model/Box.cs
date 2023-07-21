public class Box
{
    public Box(long id, decimal width, decimal height, decimal depth, decimal weight)
    {
        Id = id;
        Width = width;
        Height = height;
        Depth = depth;
        Weight = weight;
    }

    public long Id { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Depth { get; set; }

    public decimal Weight { get; set; }

    public DateOnly? DateOfProdaction { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public decimal Volume { get; set; }

    public override string ToString()
    {
        string line = $"Коробка-{Id}: Height {Height}, Width {Width}, Depth {Depth}, Weight {Weight}, ExpiryDate {ExpiryDate}, Volume {Volume} ";
        return line;
    }
}
