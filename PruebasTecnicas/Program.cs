namespace PruebasTecnicas
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int[] S = { 7, 9, -4, 8, 11, 1, 2 };
            int v = 9;

            var resultado = EncontrarDosEnterosQueSumanV(S, v);
            if (resultado != null)
            {
                Console.WriteLine($"Los números que suman {v} son {resultado.Value.Item1} y {resultado.Value.Item2}.");
            }
            else
            {
                Console.WriteLine($"No existen números en el array que sumen {v}. Por favor, ingrese un número válido.");
            }
        }

        public static (int, int)? EncontrarDosEnterosQueSumanV(int[] S, int v)
        {
            Dictionary<int, int> complementosNecesarios = new Dictionary<int, int>();
            foreach (int numeroActual in S)
            {
                if (complementosNecesarios.ContainsKey(numeroActual))
                {
                    return (numeroActual, v - numeroActual);
                }
                int complemento = v - numeroActual;
                complementosNecesarios[complemento] = numeroActual;
            }
            return null;
        }

    }
    

}


