using System;

namespace HW4
{
    class House
    {
        public House()
        {
            Basement = new Basement();
            Walls = new Wall[4] { new Wall(), new Wall(), new Wall(), new Wall() };
            Windows = new Window[4] { new Window(), new Window(), new Window(), new Window() };
            Door = new Door();
            Roof = new Roof();
        }

        public Basement Basement { get; set; }  //1
        public Wall[] Walls { get; set; }       //4
        public Window[] Windows { get; set; }   //4
        public Door Door { get; set; }          //1
        public Roof Roof { get; set; }          //1

        public void ShowHouse()
        {
            Console.WriteLine("The house is succesfully built!");

            Console.WriteLine("/----\\");
            Console.WriteLine("|    |");
            Console.WriteLine("|    |");
            Console.WriteLine("------");

        }
    }
    class Basement : IPart
    {
        public Basement()
        {
            Built = true;
        }

        public bool Built { get; set; }
    }
    class Wall : IPart
    {
        public Wall()
        {
            Built = true;
        }

        public bool Built { get; set; }
    }
    class Door : IPart
    {
        public Door()
        {
            Built = true;
        }

        public bool Built { get; set; }
    }
    class Window : IPart
    {
        public Window()
        {
            Built = true;
        }

        public bool Built { get; set; }
    }
    class Roof : IPart
    {
        public Roof()
        {
            Built = true;
        }

        public bool Built { get; set; }
    }

    class Team
    {

    } 
    class Worker : IWorker
    {

    }
    class TeamLeader : IWorker
    {
        public void Report(House house)
        {
            Console.WriteLine("Report: ");
            Console.WriteLine("Basement: " + house.Basement.Built);
            for(int i=0;i<house.Walls.Length;i++)
            {
                Console.WriteLine($"Wall {i+1}: " + house.Walls[i].Built);
            }
            for (int i = 0; i < house.Windows.Length; i++)
            {
                Console.WriteLine($"Window {i + 1}: " + house.Windows[i].Built);
            }
            Console.WriteLine("Door: " + house.Door.Built);
            Console.WriteLine("Roof: " + house.Roof.Built);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House();
            TeamLeader tl1 = new TeamLeader();
            tl1.Report(h1);
            h1.ShowHouse();
        }
    }
}
