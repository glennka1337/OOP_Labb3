namespace OOP_Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapar en lista på de olika objekten.
            List<Geometry> geometryList = new List<Geometry>();
            geometryList.Add(new Circle());
            geometryList.Add(new Square());
            geometryList.Add(new Rectangle());
            //Loopar igenom listan av geometriska objekt.
            foreach (Geometry g in geometryList)
            {
                Console.WriteLine($"Area of {g.Descriptor}: {g.Area()}");
            }
        }
    }
}
