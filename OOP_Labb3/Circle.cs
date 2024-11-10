namespace OOP_Labb3
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        //Anpassar metoden för att passa cirklar.
        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

        public Circle()
        {
            Radius = 8;
            Descriptor = "Circle";
        }
    }
}
