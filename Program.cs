namespace COMP003A.LectureActivity6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demonstrating method overloading
            ShapeCalculator calculator = new ShapeCalculator();
            Console.WriteLine($"Circle Area: {calculator.CalculateArea(5)}");
            Console.WriteLine($"Rectangle Area: {calculator.CalculateArea(5, 10)}");
            Console.WriteLine($"Triangle Area: {calculator.CalculateArea(5, 10, true)}");

            //Demonstrate class overiding
            //Creating a base class reference to a derived class object for polymorphism 
            Shape myCircle = new Circle(7);
            //Creating a base class reference to a derived class object for polymorphism
            Shape myRectangle = new Rectangle(4, 8);

            //Calling displayarea method for the cirlce and rectangle objecs
            myCircle.DisplayArea();
            myRectangle.DisplayArea();
        }
    }
}
