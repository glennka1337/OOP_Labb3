namespace OOP_Labb3
{
    internal class Square : Geometry
    {
        public double Side { get; set; }
        //Anpassar metoden för att passa kvadrater.
        public override double Area()
        {
            return Side * Side;
        }

        public Square()
        {
            Side = 9;
            Descriptor = "Square";
        }
    }
}
