
class Program
{
    // if and if else
    static void Main(string[] args)
    {
        int a = 10;
        int b = 10;

        if (a < b)
        {
            Console.WriteLine("a é menor que b");
        }
        else if (a > b)
        {
            Console.WriteLine("a é maior que b");
        }
        else
        {
            Console.WriteLine("a é igual a b");
        }

        // ternario
        string resultado = (a < b) ? "a é menor que b" : "a não é menor que b";
        Console.WriteLine(resultado);

        // switch case
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Segunda-feira");
                break;
            case 2:
                Console.WriteLine("Terça-feira");
                break;
            case 3:
                Console.WriteLine("Quarta-feira");
                break;
            case 4:
                Console.WriteLine("Quinta-feira");
                break;
            case 5:
                Console.WriteLine("Sexta-feira");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Dia inválido");
                break;
        }
    }



}

