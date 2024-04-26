do
        {
            // Solicita ao usuário que insira seus dados para o cáuculo do seu IMC
            Console.WriteLine("Informe o nome da pessoa:");
            string nome = Console.ReadLine();

            
            Console.WriteLine("Informe a idade da pessoa:");
            int idade = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Informe a altura da pessoa em metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("Informe o peso da pessoa em quilogramas:");
            double peso = Convert.ToDouble(Console.ReadLine());

            // Calcula o IMC usando a fórmula IMC = peso / (altura * altura)
            double imc = peso / (altura * altura);

            // Determina a categoria em que a pessoa se encontra na tabela do IMC de acordo com os dados da 
            //https://bvsms.saude.gov.br/bvs/dicas/215_obesidade.html
            string categoriaIMC;
            if (imc < 18.5)
            {
                categoriaIMC = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                categoriaIMC = "Normal";
            }
            else if (imc < 29.9)
            {
                categoriaIMC = "Sobrepeso";
            }
            else
            {
                categoriaIMC = "Obesidade";
            }

            // Determina a faixa etária da pessoa com base na idade de acordo com os dados da
            //https://bvsms.saude.gov.br/bvs/dicas/215_obesidade.html
            string faixaEtaria;
            if (idade < 10)
            {
                faixaEtaria = "Criança";
            }
            else if (idade < 20)
            {
                faixaEtaria = "Adolescente";
            }
            else if (idade < 60)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            // Exibe um relatório com o nome, idade, IMC e faixa etária da pessoa
            Console.WriteLine($"Relatório para {nome}:");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2} - {categoriaIMC}");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

            // Pergunta ao usuário se deseja gerar um novo relatório
            Console.WriteLine("Deseja gerar um novo relatório? (s/n)");
        } 
while (Console.ReadLine().ToLower() == "s"); // Continua o questionário se a resposta da pessoa for "s"