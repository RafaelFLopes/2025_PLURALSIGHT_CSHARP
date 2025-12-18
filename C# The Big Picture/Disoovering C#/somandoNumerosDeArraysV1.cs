// Código comum  para somar números em um array usando um loop for

class Program
{
    static void Main()
    {
        var numbers = new int[]  { 1, 2, 3, 4, 5 }; // cria uma array de números inteiros do 1 ao 5 ocupando apartir do indice 0
        int sum = 0; // cria uma variavel para armazenar a soma dos número da array

        for (int n = 0; n < numbers.Length; n++) // cria um loop for que e utiliza a propriedade Length para determinar o tamanho da array (5), enquanto n for menor que 5, ele vai repetir
        {
            sum += numbers[n]; // o n é usado como indice para acessar cada elemento da array e somar ao valor atual de sum
        }

        System.Console.WriteLine(sum); // ostra o valor da soma no console
    }
}