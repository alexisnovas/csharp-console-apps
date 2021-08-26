/*Una ONG tiene puntos de reparto de vacunas que se pretende funcionen de la siguiente manera.
 Cada día, empezar con 1000 vacunas disponibles y a través de un programa que controla las entregas
avisar si el inventario baja de 200 unidades. Desarrollar pseudocódigo y diagrama de flujo.*/

using System;

namespace OngVaccinesDeliverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int stockVaccines = 1000;
            int deliveredVaccines = 0;

            while (stockVaccines >= 200)
            {
                try
                {
                    Console.Write("Please, enter the number of vaccines to deliver: ");
                    deliveredVaccines = int.Parse(Console.ReadLine());

                    stockVaccines = stockVaccines - deliveredVaccines;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }


            Console.Write("\nThe are less than 200 vaccines left, the stock needs to be refill");

        }
    }
}
