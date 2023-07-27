public class Box
{
    private const int EndOfExpirationDate = 100;

    public Box() { }
    public Box(int palletId ,int id, decimal width, decimal height, decimal depth, decimal weight)
    {
        PalletId = palletId;
        Id = id;
        Width = width;
        Height = height;
        Depth = depth;
        Weight = weight;
    }
    public int Id { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Depth { get; set; }

    public decimal Weight { get; set; }

    public DateOnly? DateOfProduction { get; set; }

    private DateOnly? expiryDate;
    public DateOnly? ExpiryDate 
    { 
        get=> DateOfProduction?.AddDays(EndOfExpirationDate) ?? expiryDate;
        set => expiryDate = value;
    } 


    public decimal Volume => Width * Height * Depth;

    public Pallet? Pallet { get; set; }
    public int PalletId { get; set; }


    public override string ToString()
    {
        string line = $"Коробка-{Id}: Height {Height}, Width {Width}, Depth {Depth}, Weight {Weight}, ExpiryDate {ExpiryDate}, Volume {Volume} ";
        return line;
    }
}
