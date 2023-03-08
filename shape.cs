using System.Collections.Generic;
using System.Security.Cryptography;

string shape(int name, char toReplace)
{
    string str;
    switch (name)
    {
        case 0:
            str = "*****\n*   *\n*   *\n*   *\n*****\n";
            break;
        case 1:
            str = "*****\n*****\n*****\n*****\n*****\n"; ;
            break;
        case 2:
            str = "********\n********\n********\n";
            break;
        case 3:
            str = "********\n*      *\n*      *\n********\n";
            break;
        case 4:
            str = "*\n**\n***\n****\n*****\n";
            break;
        case 5:
            str = "*\n**\n* *\n****\n*****\n";
            break;
        case 6:
            str = "   *\n  ***\n *****\n*******\n *****\n  ***\n   *\n";
            break;
        case 7:
            str = "   *\n  * *\n *   *\n*     *\n *   *\n  * *\n   *\n";
            break;
        case 8:
            str = "    ********\n   **********\n  ************\n **************\n****************\n";
            break;
        case 9:
            str = "    ********\n   *        *\n  *          *\n *            *\n****************\n";
            break;
        default:
            str = "There is no such shape";
            break;
    }
    return str.Replace('#', toReplace);
}

int ChoseShape()
{
    string me = "0 - square hollow\n1 - square filled\n2 - rectangle filled\n" +
        "3 - rectangle hollow\n4 - triangle filled\n5 - triangle_hollow\n6 - " +
        "rhombus filled\n7 - rhombus hollow\n8 - trapezoid filled\n9 - trapezoid hollow ";
    Console.WriteLine(me);
    string shape = Console.ReadLine();
    //string 
    return Convert.ToInt32(shape);
}

void ClearLine()
{

    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop - 1);
}
void program()
{
    char c = '#';
    while (true)
    {

        string me = "1 - Create a new shape\r\n2 - Update shape data\r\n" +
                    "3 - Deleting an existing shape\r\n4 - shape printing";
        Console.WriteLine(me);
        string chose = Console.ReadLine();
        switch (chose)
        {
            case "1":
                break;
            case "2":
                ClearLine();
                break;
            case "3":
                Console.WriteLine("Select a new character to be the base of the shape");
                c = Console.ReadLine().ToCharArray()[0];
                break;
            case "4":
                Console.WriteLine(shape(ChoseShape(), c));
                break;
            default:
                me = "Select again";
                break;
        }
    }

}