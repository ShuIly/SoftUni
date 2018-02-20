class Box
{
    private decimal length;
    private decimal width;
    private decimal height;

    public decimal SurfaceArea => 2 * this.length * this.width +
        2 * this.length * this.height +
        2 * this.width * this.height;

    public decimal LateralSurfaceArea => 2 * this.length * this.height +
        2 * this.width * this.height;

    public decimal Volume => this.length * this.width * this.height;

    public Box(decimal length, decimal width, decimal height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
}
