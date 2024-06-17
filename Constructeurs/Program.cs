namespace Constructeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building firstBuilding = new Building(5, 6.8);
            Building secondBuilding = new Building(4);

            Console.WriteLine($"Nombre d'étages : {firstBuilding.GetFloorCount()} | Taille du bâtiment : {firstBuilding.GetSize()} | Taille de l'étage : {firstBuilding.GetFloorMaxSize()}");
            Console.WriteLine($"Nombre d'étages : {secondBuilding.GetFloorCount()} | Taille du bâtiment : {secondBuilding.GetSize()} | Taille de l'étage : {secondBuilding.GetFloorMaxSize()}");
        }
    }
}
