using System;

namespace PracticasExcepciones
{
    class program
    {
        static void Main(string[] args)
        {
            
            Random numero = new Random();  

            int aleatorio = numero.Next(0,100);

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un n° entre el 0 y el 100");

            do
            {
                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                
                catch (Exception ex) when (ex.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error. Se toma como n° introduciodo el numero 0");
                    //Console.WriteLine(ex.Message);

                    minumero = 0;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Has introducido texto");
                    minumero = 0;
                }
                
                if (minumero > aleatorio) Console.WriteLine("El n° es más bajo");

                if (minumero < aleatorio) Console.WriteLine("El n° es más alto");

            } while (aleatorio != minumero);

                Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            Console.WriteLine("A partir de esta línea de código el programa continuaría");
           
            
            //Expreciones checked y andchecked

            
                int numero2 = int.MaxValue;

                int resultado = checked(numero2 + 20);

                Console.WriteLine(resultado);




                int numero3 = int.MaxValue;

                int resultado2 = unchecked(numero3 + 20);

                Console.WriteLine(resultado2);
            

            //NOMBRE DEL MES

            Console.WriteLine("Introduce un n° de mes");

            int NumeroMes = int.Parse(Console.ReadLine());

            try
            {

                Console.WriteLine(NombreDelMes(NumeroMes));

            }catch(Exception e)
            {
                Console.WriteLine("Mensaje de la excepción " + e.Message);
            }

            Console.WriteLine("Aquí continuaria la ejecución del resto del programa");
            
        }


        
        public static string NombreDelMes(int mes)
        {

            switch (mes)
            {

                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default:

                    throw new ArgumentOutOfRangeException();
            }
            

        }
    }
}
