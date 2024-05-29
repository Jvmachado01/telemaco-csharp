class Program {
    static void Main(string[] args) {
        int a = 10;
        int b = 20;

        bool isEqual = (a == b);
        Console.WriteLine("a == b: " + isEqual);  // Saída: False

        bool isNotEqual = (a != b);
        Console.WriteLine("a != b: " + isNotEqual);  // Saída: True

        bool isGreater = (a > b);
        Console.WriteLine("a > b: " + isGreater);  // Saída: False

        bool isLesser = (a < b);
        Console.WriteLine("a < b: " + isLesser);  // Saída: True

        bool isGreaterOrEqual = (a >= b);
        Console.WriteLine("a >= b: " + isGreaterOrEqual);  // Saída: False

        bool isLesserOrEqual = (a <= b);
        Console.WriteLine("a <= b: " + isLesserOrEqual);  // Saída: True
    }
}