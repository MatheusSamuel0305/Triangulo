using System;

class Program {
    static void Main() {
        Console.Write("Digite o valor de X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de Y: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de Z: ");
        double z = double.Parse(Console.ReadLine());

        if (x < y + z && y < x + z && z < x + y) {
            if (x == y && y == z)
                Console.WriteLine("Triângulo Equilátero");
            else if (x == y || x == z || y == z)
                Console.WriteLine("Triângulo Isósceles");
            else
                Console.WriteLine("Triângulo Escaleno");
        }
        else {
            Console.WriteLine("Os valores não formam um triângulo");
        }
    }
}
