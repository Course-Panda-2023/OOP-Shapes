using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace FiguresProject
{
    internal class Helper
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Add new figure");
            Console.WriteLine("2. Change Figure parameters");
            Console.WriteLine("3. Remove figure");
            Console.WriteLine("4. Draw the figure");
            Console.WriteLine("5. Exit");
        }

        public static void AddFigure(List<Figures> figureList)
        {
            string[] userChoice = CollectNewFigureData();
            int figureType = Convert.ToInt32(userChoice[0]);
            int isCustom = Convert.ToInt32(userChoice[1]);
            const int isFillParam = 2, figurePointParam = 3;
            switch (figureType)
            {
                case 1:
                    Console.WriteLine("Enter the height of the triangle");
                    int height = Convert.ToInt32(Console.ReadLine());
                    if (isCustom == (int)YN.NO)
                    {
                        figureList.Add(new Triangle(height));
                    }
                    else
                    {
                        figureList.Add(new Triangle(height, Convert.ToBoolean(Convert.ToInt32(userChoice[isFillParam])), Convert.ToChar(userChoice[figurePointParam])));
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the height of the rhombus");
                    height = Convert.ToInt32(Console.ReadLine());
                    if (isCustom == (int)YN.NO)
                    {
                        figureList.Add(new Rhombus(height));
                    }
                    else
                    {
                        figureList.Add(new Rhombus(height, Convert.ToBoolean(Convert.ToInt32(userChoice[isFillParam])),
                            Convert.ToChar(userChoice[figurePointParam])));
                    }

                    break;
                case 3:
                    Console.WriteLine("Enter the height of the rectangle");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the width of the rectangle");
                    int width = Convert.ToInt32(Console.ReadLine());
                    if (isCustom == (int)YN.NO)
                    {
                        figureList.Add(new Rectangle(width, height));
                    }
                    else
                    {
                        figureList.Add(new Rectangle(width, height, Convert.ToBoolean(Convert.ToInt32(userChoice[isFillParam])),
                            Convert.ToChar(userChoice[figurePointParam])));
                    }

                    break;
                case 4:
                    Console.WriteLine("Enter the height of the trapezoid");
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the upper side size of the trapezoid");
                    width = Convert.ToInt32(Console.ReadLine());
                    if (isCustom == (int)YN.NO)
                    {
                        figureList.Add(new Trapezoid(width, height));
                    }
                    else
                    {
                        figureList.Add(new Trapezoid(width, height, Convert.ToBoolean(Convert.ToInt32(userChoice[isFillParam])), Convert.ToChar(userChoice[figurePointParam])));
                    }

                    break;
                default:
                    Console.WriteLine("Wrong figure type");
                    break;
            }
        }

        static string[] CollectNewFigureData()
        {
            const int MAXPARAMSNUM = 4;
            string[] userFigureParams = new string[MAXPARAMSNUM];
            const int MINFIGCHOICE = 1, MAXFIGCHOICE = 4;
            string figurePoint;//, isFilled;
            Console.WriteLine("Choose the figure you like to add");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Rhombus");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Trapezoid");
            int figureType = Convert.ToInt32(Console.ReadLine());
            while (figureType < MINFIGCHOICE || figureType > MAXFIGCHOICE)
            {
                Console.WriteLine("Wrong input. Try again");
                figureType = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Would you like to customize the figure?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("0. No");
            int isCustom = Convert.ToInt32(Console.ReadLine());
            while (isCustom != (int)YN.NO && isCustom != (int)YN.YES)
            {
                Console.WriteLine("Wrong input. Try again", isCustom);
                isCustom = Convert.ToInt32(Console.ReadLine());
            }

            if (isCustom == (int)YN.YES)
            {
                Console.WriteLine("Please enter figure point character");
                figurePoint = Console.ReadLine();
                while (figurePoint.Length != 1)
                {
                    Console.WriteLine("Wrong input. Try again");
                    figurePoint = Console.ReadLine();
                }

                Console.WriteLine("Would you like to fill the figure?");
                Console.WriteLine("1. Yes \n0. No");
                
                int isFilled = Convert.ToInt32(Console.ReadLine());
                while (isFilled != (int)YN.YES && isFilled != (int)YN.NO)
                {
                    Console.WriteLine("Wrong input. Try again");
                    isFilled = Convert.ToInt32(Console.ReadLine());
                }

                
                userFigureParams[2] = isFilled.ToString();
                userFigureParams[3] = figurePoint;
            }

            userFigureParams[0] = figureType.ToString();
            userFigureParams[1] = isCustom.ToString();
            return userFigureParams;
        }

        public static void ChangeFigureParameters(List<Figures> figureList)
        {
            Console.WriteLine("Enter the id of the figure you want to remove");
            int figureID = Convert.ToInt32(Console.ReadLine());
            Figures figure = FindFigure(figureList, figureID);

            if (figure != null)
            {
                Console.WriteLine("Enter the new height of the figure");
                int newHeight = Convert.ToInt32(Console.ReadLine());
                figure.Height = newHeight;
                if (figure is Rectangle)
                {
                    Console.WriteLine("Enter the new width of the figure");
                    int newWidth = Convert.ToInt32(Console.ReadLine());
                    (figure as Rectangle).Width = newWidth;
                }else if (figure is Trapezoid)
                {
                    Console.WriteLine("Enter the new upper side size of the figure");
                    int newUpperSide = Convert.ToInt32(Console.ReadLine());
                    (figure as Trapezoid).UpperSide = newUpperSide;
                }
            }
            else
            {
                Console.WriteLine("Figure not found!");
            }
        }

        public static void RemoveFigure(List<Figures> figureList)
        {
            Console.WriteLine("Enter the id of the figure you want to remove");
            int figureID = Convert.ToInt32(Console.ReadLine());
            Figures figure = FindFigure(figureList, figureID);
            if (figure != null)
            {
                Console.WriteLine("Removing the figure:");
                Console.WriteLine(figureList[figureID].ToString());
                figureList.Remove(figure);
            }
            else
            {
                Console.WriteLine("Figure not found!");
            }
        }

        public static void DrawFigure(List<Figures> figureList)
        {
            Console.WriteLine("Enter the id of the figure you want to draw");
            int figureID = Convert.ToInt32(Console.ReadLine());
            Figures figure = FindFigure(figureList, figureID);
            if (figure != null)
            {
                Console.WriteLine("Drawing the figure...");
                figure.Draw();
            }
            else
            {
                Console.WriteLine("Figure not found!");
            }
        }

        static void PrintFigures(List<Figures> figureList)
        {
            Console.WriteLine("Printing the figures...");
            foreach (Figures figure in figureList)
            {
                Console.WriteLine(figure.ToString());
            }
        }

        public static void RunMenu(List<Figures> figureList)
        {
            PrintMenu();
            int userChoice = Convert.ToInt32(Console.ReadLine());
            while (userChoice - 1 != (int)MenuOptions.EXIT)
            {
                switch (userChoice - 1)
                {
                    case (int)MenuOptions.ADD:
                        AddFigure(figureList);
                        break;
                    case (int)MenuOptions.CHANGE:
                        ChangeFigureParameters(figureList);
                        break;
                    case (int)MenuOptions.REMOVE:
                        RemoveFigure(figureList);
                        break;
                    case (int)MenuOptions.DRAW:
                        DrawFigure(figureList);
                        break;
                    case (int)MenuOptions.EXIT:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Wrong input. Try again");
                        break;
                }

                PrintMenu();
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static Figures FindFigure(List<Figures> figureList, int figureId)
        {
            foreach (var figure in figureList)
            {
                if (figureId == figure.GetID())
                {
                    return figure;
                }
            }
            return null;
        }
    }
}



