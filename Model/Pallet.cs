public class Pallet
{
    private const int StartWeight = 30;
    public Pallet(long id, decimal width, decimal height, decimal depth)
    {
        Id = id;
        Width = width;
        Height = height;
        Depth = depth;
    }
    public ICollection<Box> Boxes { get; set; }=new List<Box>();

    public long Id { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Depth { get; set; }

    public decimal Weight { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public decimal Volume { get; set; }

    public override string ToString()
    {
        string line =$"Паллет-{Id}: Height {Height}, Width {Width}, Depth {Depth}, Weight {Weight}, ExpiryDate {ExpiryDate}, Volume {Volume} ";
        return line;
    }
}
