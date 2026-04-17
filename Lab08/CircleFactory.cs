namespace Lab08;

class CircleFactory : IGraphic2DFactory
{
    public string Name => "Circle";

    public IGraphic2D Create()
    {
        int centerx = InputValidation.GetInt("What is the x coordinate of the circle's center? ");
        int centery = InputValidation.GetInt("What is the y coordinate of the circle's center? ");
        int radius = InputValidation.GetInt("What is the radius of the circle? ", Math.Min(centerx, centery));

        return new Circle(centerx, centery, radius) {BackgroundColor = ConsoleColor.DarkBlue, ForegroundColor = ConsoleColor.Green, DisplayChar = ' '}; 
    }
}