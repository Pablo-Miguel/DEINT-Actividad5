using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {

            return String.Join("", vs);

            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {

            Array.Sort(vs);
            return devolverString(vs);

            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {
            int contador = 0; 

            foreach (String cadena in vs) {
                
                if (cadena.Contains(v)) {
                   contador += cadena.Count(caracter => (caracter == v));
                }
                
            }

            return contador;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {

            int[] suma = new int[vs1.Length]; 
            for (int i = 0; i < vs1.Length; i++) { 
                suma[i] = vs1[i] + vs2[i]; 
            }

            return suma;

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            int[] mult = new int[vs1.Length];
            for (int i = 0; i < vs1.Length; i++)
            {
                mult[i] = vs1[i] * vs2[i];
            }

            return mult;

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {

            String temp = entrada.Replace(" ", String.Empty);
            temp = temp.ToLower();
            return temp.SequenceEqual(temp.Reverse());

            throw new NotImplementedException();

        }

        public static int contarPalabras(string entrada)
        {

            if (entrada.Length >= 1) {
                string[] palabras = entrada.Split(' ');
                return palabras.Length;
            }
            else {
                return 0;
            }
            

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            
            return entrada.Replace(" ", String.Empty).Length;

            throw new NotImplementedException();
        }
    }
}
