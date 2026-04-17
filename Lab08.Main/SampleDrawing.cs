using Lab08;

Console.Clear();

UserInterface userInterface = new();

bool loop = true;

while (loop)
{
    Console.Clear();
    string message = "What would you like to do? \n 1. Display Drawings \n 2. Add Shape \n 3. Remove Shape \n 4. Exit \n ";
    int num = InputValidation.GetInt(message, 4);
    switch (num)
    {
        case 1:
            userInterface.Display();
            break;
        case 2:
            userInterface.AddGraphic();
            break;
        case 3:
            userInterface.RemoveGraphic();
            break;
        case 4:
            loop = false;
            break;
    }
}




