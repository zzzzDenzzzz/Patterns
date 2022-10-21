using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car(new Engine(), new Transmission(), new Brake(), new Whell());

            Driver Driver = new Driver();
            Driver.Move(Car);

            Console.WriteLine();
        }
    }

    class Engine
    {
        public void Rotate1()
        {
            Console.WriteLine("Что - то вращает 1...");
        }
        public void Rotate2()
        {
            Console.WriteLine("Что - то вращает 2...");
        }
    }
    class Transmission
    {
        public void PassRotation()
        {
            Console.WriteLine("Передает вращение");
        }
    }
    class Brake
    {
        public void Stop()
        {
            Console.WriteLine("Остановливает машину");
        }
    }

    class Whell
    {
        public void Relocate()
        {
            Console.WriteLine("Перемещаемся куда - то...");
        }
    }

    class Car
    {
        Engine engine;
        Transmission transmission;
        Brake brake;
        Whell whell;
        public Car(Engine engine, Transmission transmission, Brake brake, Whell whell)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.brake = brake;
            this.whell = whell; 
        }

        public void Start()
        {
            engine.Rotate1();
            engine.Rotate2();
            transmission.PassRotation();
            whell.Relocate();
        }

        public void Stop()
        {
            brake.Stop();
        }
    }

    class Driver
    {
        public void Move(Car car)
        {
            car.Start();
            car.Stop();
        }
    }
}
