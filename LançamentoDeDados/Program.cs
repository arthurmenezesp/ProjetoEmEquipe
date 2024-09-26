// See https://aka.ms/new-console-template for more information
Random random = new Random();
        string continuar;
        do
        {
            Console.Write("Quantas vezes você deseja rodar dado? ");
            int numerorodadas;
            
            while (!int.TryParse(Console.ReadLine(), out numerorodadas ) || numerorodadas <= 0)
            {
                Console.Write("Número inválido, digite um número maior que zero: ");
            }
            for (int i = 0; i < numerorodadas; i++)
            {
                int resultado = random.Next(1, 7); 
                Console.WriteLine($"Lançamento {i + 1}: {resultado}");
            }
            Console.Write("Deseja rodar o dado novamente? (sim/não): ");
            continuar = Console.ReadLine();
        } 
		while (continuar == "sim");
        Console.WriteLine("Obrigado por jogar!"); 
