
class Program
{
    static void Main(string[] args)
    {
        // for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }


        // foreach
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // while
        int a = 0;
        while (a < 5)
        {
            Console.WriteLine($"a = {a}");
            a++;
        }


        // do while
        int b = 6;
        do
        {
            Console.WriteLine($"b = {b}");
            b++;
        } while (b < 5);

    }
}

/*
Dicas
- Use for quando souber o número exato de iterações.
- Use foreach para iterar sobre coleções sem precisar de um índice.
- Use while quando não souber exatamente quantas vezes deseja iterar, 
mas tem uma condição clara.
- Use do-while quando precisar garantir que o bloco de código seja 
executado pelo menos uma vez.
*/
