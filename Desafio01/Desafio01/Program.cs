namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000000; i++)
            {
                if (i % 10 != 0)
                {
                    var numero = i;
                    var invertido = 0;
                    while (numero > 0)
                    {
                        invertido = invertido * 10 + numero % 10;
                        numero /= 10;
                    }

                    var soma = i + invertido;
                    var impar = soma % 2;

                    if (impar > 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
