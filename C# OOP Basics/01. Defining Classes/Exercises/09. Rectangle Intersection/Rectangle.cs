class Rectangle
{
    // ID, width, height and the coordinates of its top left corner (horizontal and vertical).
    // Create a method which receives as a parameter another Rectangle, checks if the two rectangles intersect and returns true or false. 

    private double width;
    private double height;
    private double x;
    private double y;

    public Rectangle(double width, double height, double x, double y)
    {
        this.width = width;
        this.height = height;
        this.x = x;
        this.y = y;
    }

    public bool IsIntersecting(Rectangle rect)
    {
        if (this.x < rect.x + rect.width && this.x + this.width >= rect.x &&
            this.y <= rect.y + rect.height && this.y + this.height >= rect.y)
        {
            return true;
        }

        return false;
    }
}
