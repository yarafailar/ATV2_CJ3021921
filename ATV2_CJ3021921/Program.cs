namespace ATV2_CJ3021921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 3
            
                float bolsa;

                bolsa = 1.000f;

                bolsa = (bolsa - ((bolsa / 100f) * 3.4f));
                bolsa = (bolsa + ((bolsa / 100f) * 2.8f));
                bolsa = (bolsa + ((bolsa / 100f) * 14f));
                bolsa = (bolsa - ((bolsa / 100f) * 8.5f));

                Console.WriteLine("A nova bolsa é:{0}", bolsa);
            


            //Exercicio 1
            
                float salario;

                //Leitura do salário
                salario = float.Parse(Console.ReadLine());

                salario = salario + (25.0f / 100.0f) * salario;

                Console.WriteLine("O novo salários é R${0}", salario);

           


            //Exercicio 2
            
                int numero;
                Console.WriteLine("Digite um número inteiro: ");

            numero = int.Parse(Console.ReadLine());
            numero = (((numero * 3) + 1) + ((numero * 2) - 1));

                Console.WriteLine("O seu resultado é:{0} ", numero );


            //Exercicio 1 da lista

            float metros, centimetros, milimetros;

            Console.WriteLine("Digite o valor em metros: ");

            metros = float.Parse(Console.ReadLine());


            centimetros = (metros * 100f);
            milimetros = (metros * 1000f);

            Console.WriteLine("O valor em centimetros é:{0}", centimetros);
            Console.WriteLine("O valor em milimetros é:{0}", milimetros);


            //Exercicio 2 da lista (a)

            float f, c;

            Console.WriteLine("Digite a temperatura em fahrenheit: ", f);

            c 






















            }
    }
}

 

            