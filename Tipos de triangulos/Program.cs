using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_triangulos
{
    class Program
    {
        public class TiposTriangulos
        {
            private int lado1, lado2, lado3;

            //Metodo que muestra los mensajes y obtiene los datos ingresados
            public void inicializar()
            {
                Console.Write("Jose Luis Perez Ramirez Mat: 15-EISN-1-184");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Introduzca los lados del triangulo y presione enter");
                Console.WriteLine();
                Console.WriteLine("Medida del lado 1");
                lado1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Medida del lado 2");
                lado2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Medida del lado 3");
                lado3 = Convert.ToInt32(Console.ReadLine());
            }

            //Metodo que busca el lado mayor de los tres lados del triangulo
            
            public void LadoMayor()
            {
                if(lado1>lado2 && lado1>lado3)
                {
                    Console.WriteLine("El lado mayor es: " + lado1);

                }
                else
                {
                    if(lado2>lado3)
                    {
                        Console.WriteLine("El lado mayor es: " + lado2);
                    }
                    else
                    {
                        Console.WriteLine("El lado mayor es: " + lado3  );
                    }
                }
            }
            //Metodo que busca los tipos de triangulo de acuerdo a los tipos de medidas ingresados

            public void Triangulos()
            {
                //Condiciones que evaluan los tipos de triangulos de acuerdo a los lados ingresados

                if (lado1 == lado2 && lado1 == lado3)
                    Console.WriteLine("El triangulo es equilatero");

                if(lado1==lado2 && lado1!=lado3 || lado2==lado3 && lado2!=lado1 || lado3==lado1 && lado3 != lado2)
                    Console.WriteLine("El triangulo es isosceles");

                if(lado1!=lado2 && lado1!=lado3 && lado2!=lado3)
                    Console.WriteLine("El triangulo es escaleno");
            }

        }

        static void Main(string[] args)
        {
            int repetir = 0;

            //Instruccion do while

            do
            {
                //Mandamos a llamar a la clase TiposTriangulos
                TiposTriangulos triangulos = new TiposTriangulos();
                triangulos.inicializar();
                triangulos.LadoMayor();
                triangulos.Triangulos();
                Console.WriteLine("Desea repetir el procedimiento? Coloque 1=Si o 2=no");
                repetir = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


            } while (repetir==1); 
        }
    }
}
