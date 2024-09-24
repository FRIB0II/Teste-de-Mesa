namespace TesteMesa
{
    public class Atividade2
    {
        public static void Teste2()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Segundo exercício. \n");

            int a = 2;
            int i = 1;
            int[] v = new int[7];

            while(a < 6)
            {
                v[a] = 10 * a;

                Console.WriteLine($"{i}º Iteração.");
                Console.WriteLine($"Varíavel: A = {a}");
                Console.WriteLine($"Condição: a < 6");
                Console.WriteLine($"Valor: v[{a}] = {v[a]}");
                Console.WriteLine("Resultado: V (Verdadeiro).");
                Console.WriteLine("");
                Console.ReadKey();

                a++;
                i++;
            }

            v[a] = 10 * a;

            Console.WriteLine($"{i}º Iteração.");
            Console.WriteLine($"Varíavel: A = {a}");
            Console.WriteLine($"Condição: a < 6");
            Console.WriteLine($"Valor: v[{a}] = {v[a]}");
            Console.WriteLine("Resultado: F (Falso).");
            Console.WriteLine("");
            Console.ReadKey();
            Program.Menu();
        }
    }
}
