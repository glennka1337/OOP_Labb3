namespace OOP_Labb3
{
    internal class Rectangle : Geometry
    {
        public double X { get; set; }
        public double Y { get; set; }
        //Anpassar metoden för att passa rektanglar.
        public override double Area()
        {
            return X * Y;
        }

        public Rectangle()
        {
            X = 6;
            Y = 4;
            Descriptor = "Rectangle";
        }
    }
}
