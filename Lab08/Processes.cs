using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lab08;

public class UserInterface
{
    public List<IGraphic2DFactory> availableShapeTypes = [];
    public List<IGraphic2D> builtShapes = [];

    public UserInterface()
    {
        availableShapeTypes = [new RectangleFactory(), new CircleFactory()];
    }

    public void Display()
    {
        Console.Clear();
        AbstractGraphic2D.Display(builtShapes);
        Console.ReadKey(true);
    }
    public void AddGraphic()
    {
        IGraphic2DFactory factory;
        for (int index = 0; index < availableShapeTypes.Count; index ++)
        {
            factory = availableShapeTypes[index];
            Console.Write($" | {index + 1}: {factory.Name} | ");        
        }

        int num = InputValidation.GetInt("Which shape would you like to create? ", availableShapeTypes.Count);
        factory = availableShapeTypes[num - 1];
        IGraphic2D shape = factory.Create();
        builtShapes.Add(shape);
    }

    public void RemoveGraphic()
    {
        IGraphic2D shape;
        for (int index = 0; index < builtShapes.Count; index ++)
        {
            shape = builtShapes[index];
            Console.WriteLine($" | {index + 1}: {shape} | ");
        }

        int num = InputValidation.GetInt("Which shape would you like to remove? ", builtShapes.Count);
        builtShapes.Remove(builtShapes[num - 1]);
    }

    public void Exit()
    {
        
    }
}