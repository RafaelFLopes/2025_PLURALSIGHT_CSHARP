// agora seguindo a versão do código anterior v1 só que em C#

//invés de utilizar um loop trandicional, vamos usar o métódo de agregação Aggregate que evita erros por usar loops infinitos

using System;

class Program
{
    static void Main()
    {
        var numbers = new int[]  { 1, 2, 3, 4, 5 }; // array criada
        
        var sum = numbers.Aggregate(0, (total, num) => total + num); //utilizando o método de agregação é possivel somar os numeros da array sem utilizar um loop
        // 0 = semente, total =  semente inicial, num = cada elemento da array. até o elemento acabar array acabar

        Console.WriteLine(sum); // printa no terminal
    }
}   