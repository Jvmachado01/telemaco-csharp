


class Program
{
    static void Main(string[] args)
    {
         // Tipos de Valor
            byte b = 255;
            int i = 42;
            long l = 1234567890L;
            float f = 3.14F;
            double d = 3.14159;
            decimal dec = 12345.6789M;
            char c = 'A';
            bool isTrue = true;

            // Tipo de Referência
            string str = "Hello, World!";
            object obj = 123;  // Pode ser qualquer tipo

            // Exibir os valores
            Console.WriteLine("byte: " + b);
            Console.WriteLine("int: " + i);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("char: " + c);
            Console.WriteLine("bool: " + isTrue);
            Console.WriteLine("string: " + str);
            Console.WriteLine("object: " + obj);

            // Tipo Dinâmico
            dynamic dyn = 100;
            Console.WriteLine("dynamic: " + dyn);
            dyn = "Agora é uma string";
            Console.WriteLine("dynamic: " + dyn);



    }
}