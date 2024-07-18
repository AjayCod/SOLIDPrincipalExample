using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipal
{
    public interface IWorkable
    {
        void Work();
    }
    public interface IFeedable
    {
        void Eat();
    }
    public class HumanWorker: IWorkable,IFeedable
    {
        public void Work()
        {
            Console.WriteLine("Human Working");
        }
        public void Eat()
        {
            Console.WriteLine("Human Eating");
        }
    }
    public class RobotWorker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot Working");
        }
    }
}
