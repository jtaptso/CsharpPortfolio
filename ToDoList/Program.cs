// implements the main entry point for the application
// Date: 2021-04-07
// Version: 1.0
public class Program
{
    // create a new list of ToDo items
    static List<string> toDos = new List<string>();

    //TODO - Add a method to display the menu
    static void displayMenu()
    {
        Console.WriteLine("Hallo! What do you want to do?");
        Console.WriteLine("[S]ee all ToDos");
        Console.WriteLine("[A]dd a ToDo");
        Console.WriteLine("[R]emove a ToDo");
        System.Console.WriteLine("[E]xit");
    }
    //TODO - Add a method to get the user's choice
    static char getUserChoice()
    {
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        if (choice != 'S' && choice != 'A' && choice != 'R' && choice != 'E')
        {
            return ' ';
        }
        return choice;
    }
    //TODO - Add a method to display all ToDo items
    static void displayAllToDos()
    {
        if (toDos.Count == 0)
        {
            Console.WriteLine("No ToDo have been added yet.");
        }
        else
        {
            for (int i = 0; i < toDos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDos[i]}");
            }
        }
    }
    //TODO - Add a method to add a ToDo item
    static void AddToDo()
    {
        var validInput = false;
        do
        {
            validInput = true;
            Console.WriteLine("Enter the TODO description.");
            string newToDo = Console.ReadLine();
            if (string.IsNullOrEmpty(newToDo))
            {
                Console.WriteLine("The description cannot be empty.");
                validInput = false;
            }
            else if (toDos.Contains(newToDo))
            {
                Console.WriteLine("The description must be unique.");
                validInput = false;
            }
            else
            {
                toDos.Add(newToDo);
                validInput = true;
            }

        } while (!validInput);

    }
    //TODO - Add a method to remove a ToDo item
    static void RemoveToDo()
    {
        System.Console.WriteLine("Select the index of the ToDo you want to remove.");
        displayAllToDos();

        if (toDos.Count == 0)
        {
            Console.WriteLine("No ToDo have been added yet.");
        }
        else
        {
            bool validInput = false;
            do
            {
                validInput = true;
                if (string.IsNullOrWhiteSpace(Console.ReadLine()))
                {
                    Console.WriteLine("The index cannot be empty.");
                    validInput = false;
                }
                else
                {
                    int index = int.Parse(Console.ReadLine());
                    if (index > toDos.Count || index < 1)
                    {
                        Console.WriteLine("The given index is not valid.");
                        validInput = false;
                    }
                    else
                    {
                        System.Console.WriteLine($"ToDO removed: {toDos[index - 1]}");
                        toDos.RemoveAt(index - 1);
                        validInput = true;
                    }
                }
            } while (true);
        }
    }
    //TODO - Add a method to mark a ToDo item as completed    
}
