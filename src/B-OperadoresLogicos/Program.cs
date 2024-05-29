
class Program {
    static void Main(string[] args) {
            bool a = true;
            bool b = false;

            // Operadores Lógicos
            Console.WriteLine("Operadores Lógicos:");
            Console.WriteLine("a && b: " + (a && b));  // Saída: False
            Console.WriteLine("a || b: " + (a || b));  // Saída: True
            Console.WriteLine("!a: " + (!a));          // Saída: False

            // Operadores Bitwise
            int x = 5;  // 0101 em binário
            int y = 3;  // 0011 em binário

            Console.WriteLine("\nOperadores Bitwise:");
            Console.WriteLine("x & y: " + (x & y));  // Saída: 1 (0001 em binário)
            Console.WriteLine("x | y: " + (x | y));  // Saída: 7 (0111 em binário)
            Console.WriteLine("x ^ y: " + (x ^ y));  // Saída: 6 (0110 em binário)
            Console.WriteLine("~x: " + (~x));        // Saída: -6 (invertendo todos os bits de 0101, resultado é 1010 em complemento de dois)
    }
}