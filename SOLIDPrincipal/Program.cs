using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SRP-------------------------------------------------------------
            //EmailService emailService = new EmailService();
            //UserService userService = new UserService(emailService);
            //userService.AddUser("ajay@gmail.com","2193msd4");

            // OCP-------------------------------------------------------------
            //AreaCalculator calculator = new AreaCalculator();

            //IShape rectangle = new Rectangle { Width = 5, Height = 4 };
            //IShape circle = new Circle { Radious = 3 };
            //IShape triangle = new Triangle { Base = 4, Height = 3 };

            //Console.WriteLine($"Rectangle Area: {calculator.CalculatArea(rectangle)}");
            //Console.WriteLine($"Circle Area: {calculator.CalculatArea(circle)}");
            //Console.WriteLine($"Triangle Area: {calculator.CalculatArea(triangle)}");

            //ISP---------------------------------------------------------------

            //List<IWorkable> workables = new List<IWorkable> { new HumanWorker(), n ew RobotWorker() };
            //foreach (var item in workables)
            //{
            //    item.Work();
            //}

            //List<IFeedable> feedables = new List<IFeedable> { new HumanWorker()};
            //foreach (var item in feedables)
            //{
            //    item.Eat();
            //}

            //DIP---------------------------------------------------------------
            ISwitchable light = new Light();
            ElectricPowerSwitch electricPowerSwitch = new ElectricPowerSwitch(light);
            electricPowerSwitch.Press();
            electricPowerSwitch.Press();
            Console.ReadLine();
        }
    }
}
