public class Pallet
{
    private const int StartWeight = 30;
    public Pallet(int id, decimal width, decimal height, decimal depth)
    {
        Id = id;
        Width = width;
        Height = height;
        Depth = depth;
    }
    public ICollection<Box> Boxes { get; set; }=new List<Box>();


    public int Id { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Depth { get; set; }

    public decimal Weight => StartWeight + Boxes.Sum(b => b.Weight);

    public DateOnly? ExpiryDate => Boxes.Any() ? Boxes.Min(x => x.ExpiryDate) : null;

    public decimal Volume => Width * Height * Depth+Boxes.Sum(b=>b.Volume);

    public override string ToString()
    {
        string line =$"Паллет-{Id}: Height {Height}, Width {Width}, Depth {Depth}, Weight {Weight}, ExpiryDate {ExpiryDate}, Volume {Volume} ";
        return line;
    }
}
