using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlyDiamondOfDeathProblem
{
    public interface IGrandParent
    {
        void Display();
    }

    public interface IParent1 : IGrandParent
    {
        void Display();
    }

    public interface IParent2 : IGrandParent
    {
        void Display();
    }

    public class Child : IParent1, IParent2
    {
        void IParent1.Display()
        {
            Console.WriteLine("Display from IParent1");
        }

        void IParent2.Display()
        {
            Console.WriteLine("Display from IParent2");
        }

        public void Display()
        {
            Console.WriteLine("Display from Child");
        }
    }
}
