namespace TesteMesa
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();

            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(""); 
            Console.WriteLine("-------------------------");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Sair = 0");
            Console.WriteLine("Exercício 1 = 1");
            Console.WriteLine("Exercício 2 = 2");
            Console.WriteLine("Exercício 3 = 3");
            Console.WriteLine("-------------------------");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha < 0 || escolha > 3)
            {
                Console.WriteLine("Comando inválido. Clique qualquer tecla para tentar de novo.");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }

            switch (escolha)
            {
                case 0: 
                    Environment.Exit(1); 
                    break;

                case 1:
                    Atividade1.Teste1();
                    break;

                case 2:
                    Atividade2.Teste2();
                    break;

                case 3:
                    Atividade3.Teste3();
                    break;
            }
        }
    }
}
