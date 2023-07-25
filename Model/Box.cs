public class Box
{
    private const int EndOfExpirationDate = 100;
    public Box(long id, decimal width, decimal height, decimal depth, decimal weight, long palletId)
    {
        Id = id;
        Width = width;
        Height = height;
        Depth = depth;
        Weight = weight;
        PalletId = palletId;
    }
    public long Id { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Depth { get; set; }

    public decimal Weight { get; set; }

    public DateOnly? DateOfProdaction { get; set; }

    public DateOnly? ExpiryDate => DateOfProdaction?.AddDays(EndOfExpirationDate);

    public decimal Volume => Width * Height * Depth;

    public Pallet? Pallet { get; set; }
    public long PalletId { get; set; }


    public override string ToString()
    {
        string line = $"Коробка-{Id}: Height {Height}, Width {Width}, Depth {Depth}, Weight {Weight}, ExpiryDate {ExpiryDate}, Volume {Volume} ";
        return line;
    }
}
