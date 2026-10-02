namespace ConsoleApp2_Inventaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir le nombre d'ojets a stoker dans le sac");
            int nombreObjets = int.Parse(Console.ReadLine());

            decimal poidsTotal = 0;
            int objetLourds = 0;
            int objetLegers = 0;

            for (int i = 0; i < nombreObjets; i++)
            {
                Console.WriteLine($"Saisir le poids de l'objet {i}:");
                decimal poids = decimal.Parse(Console.ReadLine());
                poidsTotal += poids;

                if (poids > 5)
                {
                    objetLourds++;
                }
                else
                {
                    objetLegers++;
                }
            }

            Console.WriteLine($" Nombres d'objets lourds: {objetLourds}");
            Console.WriteLine($" Nombres d'objets légers: {objetLegers}");
            Console.WriteLine($" Poids total: {poidsTotal} kg");

            if (poidsTotal > 30)
            {
                Console.WriteLine("Le sac est trop lourd, il faut le vider.");
            }
            else
            {
                Console.WriteLine("Le sac est à un poids acceptable.");
            }
        }       
    }
}
