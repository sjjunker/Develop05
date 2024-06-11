public class Menu
{
    private int _menuChoice;

    //Constructor
    public Menu()
    {
        this._menuChoice = 0;
    }

    //Display the menu
    public void DisplayMenu(int score, string level)
    {
        //Menu
        Console.WriteLine("Welcome To Eternal Quest");
        Console.WriteLine("Please choose from the following options");
        Console.WriteLine("1 - Create New Goal");
        Console.WriteLine("2 - List Goals");
        Console.WriteLine("3 - Save Goals");
        Console.WriteLine("4 - Load Goals");
        Console.WriteLine("5 - Record Event");
        Console.WriteLine("6 - Quit");
        Console.WriteLine($"Your current score is {score}");
        Console.WriteLine($"Level: {level}");
    }

    //Get the user menu selection
    public int GetMenuChoice()
    {
        int menuChoice = 0;

        while (!(menuChoice > 0 && menuChoice <= 6))
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                menuChoice = choice;
            }
            else
            {
                Console.WriteLine("Please choose a number 1 through 6.");
            };

            if (!(menuChoice > 0 && menuChoice <= 6))
            {
                Console.WriteLine("Please choose a number 1 through 6.");
            }
        }
        return menuChoice;
    }
}