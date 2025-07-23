namespace DeadlyDiamondOfDeathProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Display();                      //calls Child's display

            //Explicit calls
            ((IParent1)obj).Display();          //calls IParent1's Display
            ((IParent2)obj).Display();          //calls IParent2's Display
        }
    }
}
