
class Program
{
    static void Main(string[] args)
    {

        //int[] numeros; // declaração 

        //quantidade = new int[5]; // inicialização com tamanho fixo

        int[] idades = new int[] {20, 19, 18, 23, 25}; // incializando com elementos
    
    
        Console.WriteLine(idades[1]); // 19        
        idades[0] = 30;
        Console.WriteLine(idades[0]); // 30

        for (int i = 0; i < idades.Length; i++) {
            Console.WriteLine(idades[i]);
        }

        foreach (int idade in idades) {
            Console.WriteLine(idade);
        }
    }
}