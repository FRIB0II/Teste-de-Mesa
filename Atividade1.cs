namespace TesteMesa
{
    public class Atividade1
    {
        public static void Teste1()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Primeiro exercíco. \n");

            int a = 10;
            int b = 20;
            int c = (a + b) / 2;
            c = c - 40;

            int[] v = new int[4];
            v[3] = a + b + c;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}º Iteração.");
                Console.WriteLine($"Variáveis: A = {a} B = {b} C = {c} ");
                Console.WriteLine($"Valor de V[{i}] é {v[i]}");
                Console.WriteLine($"Condição: v[{i}] == 5");
                if (v[i] == 5)
                {
                    Console.WriteLine("Resultado: V (Verdadeiro).");
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Resultado: F (Falso).");
                    Console.WriteLine("");
                    Console.ReadKey();
                }
            }
            Program.Menu();
        }
    }
}
