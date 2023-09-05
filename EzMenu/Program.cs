using EzMenu;

Menu menu = new Menu(new List<string>
{
    "Option 1",
    "Option 2",
    "Option 3",
    "Option 4",
    "Option 5",
    "Settings",
    "Exit"
});

while (true)
{
    int option = menu.Start();
    switch (option)
    {
        case 0:
            Console.WriteLine("Option 1 chosen!");
            Console.ReadKey(false);
            break;

        case 1:
            Console.WriteLine("Option 2 chosen!");
            Console.ReadKey(false);
            break;

        case 2:
            Console.WriteLine("Option 3 chosen!");
            Console.ReadKey(false);
            break;

        case 3:
            Console.WriteLine("Option 4 chosen!");
            Console.ReadKey(false);
            break;

        case 4:
            Console.WriteLine("Option 5 chosen!");
            Console.ReadKey(false);
            break;

        case 5:
            Menu settingsMenu = new Menu(new List<string> 
                                        { "Black", "White", "Red", "Green", "Yellow", "Blue", "Exit" });

            while (true)
            {
                int settingsMenuOpt = settingsMenu.Start();
                if (settingsMenuOpt == 6) break;
                menu.ChangeColor(settingsMenuOpt);
            }

            //Console.ReadKey(false);
            break;

        case 6:
            Console.WriteLine("Exiting...");
            Thread.Sleep(2000);
            return;

        case (-1):
            Console.WriteLine("EExiting...");
            Thread.Sleep(2000);
            return;

        default:
            break;
    }
}