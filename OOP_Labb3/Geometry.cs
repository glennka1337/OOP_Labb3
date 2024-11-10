namespace OOP_Labb3
{
    internal abstract class Geometry
    {

        //Skapar en string som kan användas för att beskriva vad för typ av geometrisk form det är, skapar även en metod som kan initialiseras i underklasser.
        public string Descriptor;
        public abstract double Area();
    }
}
