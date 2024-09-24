namespace TesteMesa
{
    public class Atividade3
    {
        public static void Teste3()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Terceiro Exercício \n");

            int a = 7;
            int b = a - 6;
            int i = 1;
            int[] v = new int[8];

            while (b < a)
            {
                v[b] = b + a;

                Console.WriteLine($"{i}º Iteração.");
                Console.WriteLine($"variáveis: A = {a} B = {b}");
                Console.WriteLine($"Valor: v[{b}] = {v[b]}");
                Console.WriteLine("Condição: b < a");
                Console.WriteLine($"Resultado: V (Verdadeiro).");
                Console.WriteLine("");
                Console.ReadKey();
                
                b += 2;
                i++;
            }

            v[b] = b + a;

            Console.WriteLine($"{i}º Iteração.");
            Console.WriteLine($"variáveis: A = {a} B = {b}");
            Console.WriteLine($"Valor: v[{b}] = {v[b]}");
            Console.WriteLine($"Condição: b < a");
            Console.WriteLine($"Resultado: F (Falso).");
            Console.ReadKey();
            Program.Menu();
        }
    }
}
