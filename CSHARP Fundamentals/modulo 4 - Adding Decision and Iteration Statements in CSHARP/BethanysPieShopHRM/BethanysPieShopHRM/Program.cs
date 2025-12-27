//// TRABALHANDO COM BOOLEANS E SINAIS LÓGICOS

//// Declaração de uma variável inteira chamada 'idade' e atribuição do valor 20
//int idade = 17;

///// Verificando se a idade é maior ou igual a 18 (se for o resultado vai ser true)
//bool a = idade >= 18;
//Console.WriteLine($"É maior ou igual a 18: {a}");

///// Verificado se a idade está entre 18 E 65 ano (se for false em alguma, o veredito final vai ser false)
//bool b = (idade >= 18) && (idade <= 65);
//Console.WriteLine($"É maior o igual a 18 E menor igual a 65: {b}");

///// Verificado se a idade está entre 18 OU 65 ano (se for false em alguma e verdadeira a outra, o veredito final vai ser true)
//bool c = (idade < 18) || (idade > 65);
//Console.WriteLine($"É maior o igual a 18 OU menor igual a 65: {c}");

//// TRABALHANDO COM BOOLEANS E SINAIS LÓGICOS


/// TRABALHANDO COM IF E ELSE

//Console.WriteLine("Digite sua idade para ver se é possível continuar com a candidatação do emprego");

//int idade = int.Parse(Console.ReadLine());

//if (idade <= 18){
//    Console.WriteLine("Você não pode continuar com a candidatura, pois é menor de idade.");
//}
//else if (idade >= 65)
//{
//    Console.WriteLine("Você não pode continuar com a candidatura, pois a sua idade ultrapassa as regras da vaga.");
//}
//else
//    Console.WriteLine("Você pode continuar com a candidatura, pois está na idade permitida.");

// SWITCH CASE AGORA

//Console.WriteLine("Calculadora simples");
//Console.WriteLine("+ opção 1");
//Console.WriteLine("- opção 2");
//Console.WriteLine("x opção 3");
//Console.WriteLine("/ opção 4");

//int opcao = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o primeiro valor");
//int numero1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o segundo valor");
//int numero2 = int.Parse(Console.ReadLine());

//switch (opcao)
//{
//    case 1:
//        int soma = numero1 +  numero2;
//        Console.WriteLine($"O resultado da soma é: {soma}");
//        break;
//    case 2:
//        int subtracao = numero1 - numero2;
//        Console.WriteLine($"O resultado da subtração é: {subtracao}");
//        break;
//    case 3:
//        int multiplicacao = numero1 * numero2;
//        Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
//        break;
//    default:
//        int divisao = numero1 / numero2;
//        Console.WriteLine($"O resultado da divisão é: {divisao}");
//        break;
//}

// LAÇO DE REPETIÇÃO - WHILE SIMPLES

// criando contador = 1 incianalizando no 0
//int i = 0;


//// criando o laço de repetição, enquanto o i for menor que 10, ele ira ficar se repetindo
//while(i < 10)
//{
//    Console.WriteLine(i);

//    // incrementando o valor do i em 1 a cada repetição
//    i++;
//}

//Console.WriteLine("Fim do loop");


//Aplicando laço na calculadora while (NÃO É MUITO BOA ESSA OPÇÃO, POIS TIVE Q USAR O MENU DUAS VEZES NO CÓDIGO)


//Console.WriteLine("Calculadora simples");
//Console.WriteLine("+ opção 1");
//Console.WriteLine("- opção 2");
//Console.WriteLine("x opção 3");
//Console.WriteLine("/ opção 4");
//Console.WriteLine("SAIR opção 99");

//int opcao = int.Parse(Console.ReadLine());

//while(opcao != 99){


//    Console.WriteLine("Digite o primeiro valor");
//    int numero1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Digite o segundo valor");
//    int numero2 = int.Parse(Console.ReadLine());

//    switch (opcao){
//        case 1:
//            int soma = numero1 + numero2;
//            Console.WriteLine($"O resultado da soma é: {soma}");
//            break;
//        case 2:
//            int subtracao = numero1 - numero2;
//            Console.WriteLine($"O resultado da subtração é: {subtracao}");
//            break;
//        case 3:
//            int multiplicacao = numero1 * numero2;
//            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
//            break;
//        case 4:
//            int divisao = numero1 / numero2;
//            Console.WriteLine($"O resultado da divisão é: {divisao}");
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//    Console.WriteLine("Calculadora simples");
//    Console.WriteLine("+ opção 1");
//    Console.WriteLine("- opção 2");
//    Console.WriteLine("x opção 3");
//    Console.WriteLine("/ opção 4");
//    Console.WriteLine("SAIR opção 99");

//    opcao = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Fim do programa");



//Aplicando DO-WHILE na calculadora (Melhor opcão, pois ela executa primeiro e depois verifica)
//int opcao;

//do
//{
//    Console.WriteLine("Calculadora simples");
//    Console.WriteLine("+ opção 1");
//    Console.WriteLine("- opção 2");
//    Console.WriteLine("x opção 3");
//    Console.WriteLine("/ opção 4");
//    Console.WriteLine("SAIR opção 99");
//    opcao = int.Parse(Console.ReadLine());


//    Console.WriteLine("Digite o primeiro valor");
//    int numero1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Digite o segundo valor");
//    int numero2 = int.Parse(Console.ReadLine());

//    switch (opcao)
//    {
//        case 1:
//            int soma = numero1 + numero2;
//            Console.WriteLine($"O resultado da soma é: {soma}");
//            break;
//        case 2:
//            int subtracao = numero1 - numero2;
//            Console.WriteLine($"O resultado da subtração é: {subtracao}");
//            break;
//        case 3:
//            int multiplicacao = numero1 * numero2;
//            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
//            break;
//        case 4:
//            int divisao = numero1 / numero2;
//            Console.WriteLine($"O resultado da divisão é: {divisao}");
//            break;
//        default:
//            Console.WriteLine("Opção inválida");
//            break;
//    }
//} while ( opcao != 99);

//    Console.WriteLine("Fim do programa");

// LAÇO DE REPETIÇÃO - FOR

//Solicitando ao usuário um número máximo para o loop
//int max = int.Parse(Console.ReadLine());

//Criando um loop que começa em 0 e vai até o número máximo fornecido pelo usuário
//for (int i = 0;  i < max; i++){
//    //Se o valor de i for igual a 5, exibe uma mensagem especial e continua para a próxima iteração do loop
//    if ( i == 5){
//        Console.WriteLine("Parabéns, o número sorteado foi " + i);
//        continue;
//    }
//    Console.WriteLine(i);
//}