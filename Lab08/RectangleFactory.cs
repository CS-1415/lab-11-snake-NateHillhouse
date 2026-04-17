

using Lab08;

public class RectangleFactory : IGraphic2DFactory
{
    public string Name => "Rectangle";

    public IGraphic2D Create()
    {
        int left = InputValidation.GetInt("What x coordinate is the left side of the rectangle located? ");
        int top = InputValidation.GetInt("What y coordinate is the top of the rectangle located? ");
        int centerx = InputValidation.GetInt("What x coordinate is the center of the rectangle located? ");
        int centery = InputValidation.GetInt("What y coordinate is the center of the rectangle located? ");

        return new Rectangle(left, top, centerx, centery) {BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.Green, DisplayChar = ' '};
    }
}