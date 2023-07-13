var play = true;
Random random = new Random();

while (play)
{
    var player = (char)default;
    var comp = (char)default;

    var board = new char[3, 3]
    {
        {' ', ' ', ' ' },
        {' ', ' ', ' ' },
        {' ', ' ', ' ' }
    };

    while (true)
    {
        Console.Write("Please select one of the following (x, 0): ");
        player = Convert.ToChar(Console.ReadLine());
        if (player == 'x')
        {
            comp = '0';
            break;
        }
        else if (player == '0')
        {
            comp = 'x';
            break;
        }
    }

    //Game
    while (true)
    {
        //Console clear
        Console.Clear();

        //Computer turn
        while (true)
        {
            var x = random.Next(0, 3);
            var y = random.Next(0, 3);
            if (board[x, y] == ' ')
            {
                board[x, y] = comp;
                break;
            }
        }



        //draw
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    Console.Write("[ ]");
                }
                else
                {
                    Console.Write($"[{board[i,j]}]");
                }
            }
            Console.WriteLine();

        }

        //G'olibni tekshirish
        if ((board[0, 0] == 'x' && board[0, 1] == 'x' && board[0, 2] == 'x') || (board[1, 0] == 'x' && board[1, 1] == 'x' && board[1, 2] == 'x') || (board[2, 0] == 'x' && board[2, 1] == 'x' && board[2, 2] == 'x') || (board[0, 0] == 'x' && board[1, 0] == 'x' && board[2, 0] == 'x') || (board[0, 1] == 'x' && board[1, 1] == 'x' && board[2, 1] == 'x') || (board[0, 2] == 'x' && board[1, 2] == 'x' && board[2, 2] == 'x') || (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x') || (board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x'))
        {
            if(comp == 'x')
            {
                Console.WriteLine("Dastur yutdi!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;
            }
            else
            {
                Console.WriteLine("Siz yutdingiz!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;
            }
        }

        if ((board[0, 0] == '0' && board[0, 1] == '0' && board[0, 2] == '0') || (board[1, 0] == '0' && board[1, 1] == '0' && board[1, 2] == '0') || (board[2, 0] == '0' && board[2, 1] == '0' && board[2, 2] == '0') || (board[0, 0] == '0' && board[1, 0] == '0' && board[2, 0] == '0') || (board[0, 1] == '0' && board[1, 1] == '0' && board[2, 1] == '0') || (board[0, 2] == '0' && board[1, 2] == '0' && board[2, 2] == '0') || (board[0, 0] == '0' && board[1, 1] == '0' && board[2, 2] == '0') || (board[0, 2] == '0' && board[1, 1] == '0' && board[2, 0] == '0'))
        {
            if (player == '0')
            {
                Console.WriteLine("Siz yutdingiz!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;

            }
            else
            {
                Console.WriteLine("Dastur yutdi!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;
            }
        }

        //Durrangligini tekshirish
        var count = 0;
        for (int i = 0; i<3; i++)
        {
            for (int j = 0; j<3; j++)
            {
                if (board[i, j] == ' ')
                {
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Durrang!!!");
            Console.Write("Yana o'ynaymizmi (y/n)? ");
            var check = Convert.ToChar(Console.ReadLine());
            if (check == 'n')
            {
                play = false;
            }
            break;
        }
        

        //Player turn
        while (true)
        {
            Console.Write("Qator: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Katak: ");
            var y = Convert.ToInt32(Console.ReadLine());

            if (x > 3 || y > 3 || x < 0 || y < 0)
            {
                Console.WriteLine("O'yin doskasi o'chamidan oshib ketti, qaytadan kiriting!");
            }else if (board[x-1, y-1] != ' ')
            {
                Console.WriteLine("U yer band, qaytadan kiriting!");
            }
            else
            {
                board[x - 1, y - 1] = player;
                break;
            }
        }

        Console.Clear();
        //draw
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    Console.Write("[ ]");
                }
                else
                {
                    Console.Write($"[{board[i, j]}]");
                }
            }
            Console.WriteLine();

        }

        //G'olibni tekshirish
        if ((board[0, 0] == 'x' && board[0, 1] == 'x' && board[0, 2] == 'x') || (board[1, 0] == 'x' && board[1, 1] == 'x' && board[1, 2] == 'x') || (board[2, 0] == 'x' && board[2, 1] == 'x' && board[2, 2] == 'x') || (board[0, 0] == 'x' && board[1, 0] == 'x' && board[2, 0] == 'x') || (board[0, 1] == 'x' && board[1, 1] == 'x' && board[2, 1] == 'x') || (board[0, 2] == 'x' && board[1, 2] == 'x' && board[2, 2] == 'x') || (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x') || (board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x'))
        {
            if (comp == 'x')
            {
                Console.WriteLine("Dastur yutdi!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;
            }
            else
            {
                Console.WriteLine("Siz yutdingiz!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;
            }
        }

        if ((board[0, 0] == '0' && board[0, 1] == '0' && board[0, 2] == '0') || (board[1, 0] == '0' && board[1, 1] == '0' && board[1, 2] == '0') || (board[2, 0] == '0' && board[2, 1] == '0' && board[2, 2] == '0') || (board[0, 0] == '0' && board[1, 0] == '0' && board[2, 0] == '0') || (board[0, 1] == '0' && board[1, 1] == '0' && board[2, 1] == '0') || (board[0, 2] == '0' && board[1, 2] == '0' && board[2, 2] == '0') || (board[0, 0] == '0' && board[1, 1] == '0' && board[2, 2] == '0') || (board[0, 2] == '0' && board[1, 1] == '0' && board[2, 0] == '0'))
        {
            if (player == '0')
            {
                Console.WriteLine("Siz yutdingiz!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;

            }
            else
            {
                Console.WriteLine("Dastur yutdi!!!");
                Console.Write("Yana o'ynaymizmi? (y/n): ");
                var check = Convert.ToChar(Console.ReadLine());
                if (check == 'n')
                {
                    play = false;
                }
                break;
            }
        }

        //Durrangligini tekshirish
        count = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Durrang!!!");
            Console.Write("Yana o'ynaymizmi (y/n)? ");
            var check = Convert.ToChar(Console.ReadLine());
            if (check == 'n')
            {
                play = false;
            }
            break;
        }
    }
}
