namespace LogicLib.CoreBasicVol2
{
    public class FunWithStructures
    {
        public static void PrintInfo()
        {
            Point point;
            point.X = 349;
            point.Y = 76;
            point.Display();
            point.Increment();
            point.Increment();
            point.Display();
            point.Decrement();
            point.Display();
        }
    }
}