using System;

namespace Quedar_libre
{
    public static class Program
    {
        public static int Asistencia(int asistotal, int asistalumno)
        {
            return  (asistalumno * 100) / asistotal;

            
        }
        public static void Main()
        {
            int asistotal = 1;
            int asistalumno = 1;
            

            Console.WriteLine("Ingrese la asistencia total en dias: ");
            asistotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la asistencia del alumno ");
            asistalumno = Convert.ToInt32(Console.ReadLine());
           
            int porcAlum = Asistencia(asistotal, asistalumno);


            if (porcAlum >= 75)
            {
                Console.WriteLine("El alumno no se encuentra libre Felicitaciones ");
            }
            else
            {
                Console.WriteLine("Te quedas libre!!!!!! Nos vemos el año que viene");
            }

            Console.ReadKey();
        }



    }



}
