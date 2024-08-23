
string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool isPlayer1Turn = true;
int numTurns = 0;


ShowSplashScreen();
while (!CheckVictory() && numTurns != 9)
{
    Console.Clear();
    
    PrintGrid();
    if (isPlayer1Turn)
        Console.WriteLine("Player 1 turn!");
    else
        Console.WriteLine("Player 2 turn!");

    string? input = Console.ReadLine();

    if(grid.Contains(input) && input != "X" && input != "O")
    {
        int gridIndex = Convert.ToInt32(input) - 1;
        if (isPlayer1Turn)
            grid[gridIndex] = "X";
        else 
            grid[gridIndex] = "O";

        numTurns++;
        
    }

    isPlayer1Turn = !isPlayer1Turn;
}

if (CheckVictory())
    Console.WriteLine("You Win!");
else
    Console.WriteLine("Tie!");

bool CheckVictory()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diagLR = grid[0] == grid[4] && grid[4] == grid[8];
    bool diagRL = grid[2] == grid[4] && grid[4] == grid[6];

    return row1 || row2 || col1 || col2 || diagLR || diagRL;
}

static void ShowSplashScreen()
{
    
    //Console.BackgroundColor = ConsoleColor.Green;
    //Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    
    Console.WriteLine("       .--\r\n       ==-   .\\#\\\r\n          ,-._\\\\ \\=- .\r\n          |#___\"\\ \\_);\r\n   =--      '  \\\\\\#\\\r\n      ==--      \\`--'\r\n                 \"\"         .--\r\n                     ==--   .\\#\\\r\n                         ,-._\\\\ \\=- .               )\r\n                  ==-    |#___\"\\ \\_);              (\r\n                           '  \\\\\\#\\                 ))\r\n                        ==-    \\`--'               ((\r\n                                \"\"                  ))\r\n      ______________                __              (  __\r\n    ,'              `.            ('__`>           , ) __`.\r\n   /                  \\____       /==(^)     ______ ( -'_--`.\r\n  |     All right!     ,-'        `\\_-/    |()|::::)= '_`.  .\r\n  |     All right!     |     _____ / /\\  /)____||____\\_-``.\r\n  |   You guys win!    |          `-------'            \\-`   ,\r\n   \\                  /      &  ,   .  &  ,   .  &  ,   | '\r\n    `.______________,'       _\\'     `/_\\'     `/_\\'    |\r\n                             _|`.   ,'|_|`.   ,'|_|`.   |\r\n                                                        |\\\r\n                             __________________________/__\\\r\n                                                     .`.-_-\\\r\n                                                    `_`.'_-_\\\r\n                                                       -- -");
    Console.WriteLine("888   d8b        888                   888                    \r\n888   Y8P        888                   888                    \r\n888              888                   888                    \r\n888888888 .d8888b888888 8888b.  .d8888b888888 .d88b.  .d88b.  \r\n888   888d88P\"   888       \"88bd88P\"   888   d88\"\"88bd8P  Y8b \r\n888   888888     888   .d888888888     888   888  88888888888 \r\nY88b. 888Y88b.   Y88b. 888  888Y88b.   Y88b. Y88..88PY8b.     \r\n \"Y888888 \"Y8888P \"Y888\"Y888888 \"Y8888P \"Y888 \"Y88P\"  \"Y8888  ");
    Console.WriteLine("\n");
    Console.WriteLine("\n");
    Console.WriteLine("Welcome to TicTacToe!");
    Console.WriteLine("Press 'S' to start the game.");
    while (Console.ReadKey(true).Key != ConsoleKey.S)
    {
        // Wait for the user to press 'S'
    }
}


void PrintGrid()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(grid[i * 3 + j] + " " + "|");
        }
        Console.WriteLine();
        Console.WriteLine("---------");
    }
}