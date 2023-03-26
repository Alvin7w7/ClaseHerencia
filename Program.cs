using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseHerencia
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Cuenta = "Ajhon";
            estudiante.Password = "523456";
            estudiante.Nombre = "Alan";
            estudiante.Matricula = "57CF3";

            estudiante.login("Ajhon", "523456");
            estudiante.login();

            List<Estudiante> listE = new List<Estudiante>();
            listE.Add(new Estudiante()
            {
                Cuenta = "CarmenJ",
                Password = "Car321",
                Nombre = "Carmen",
                Matricula = "JO456",
                Edad = 24,
            });
            listE.Add(new Estudiante()
            {
                Cuenta = "AdanK",
                Password = "Ada345",
                Nombre = "Adan",
                Matricula = "AN234",
                Edad = 20,
            });
            listE.Add(new Estudiante()
            {
                Cuenta = "SaulP",
                Password = "Sau890",
                Nombre = "Saul",
                Matricula = "SO098",
                Edad = 22,
            });
            listE.Add(new Estudiante()
            {
                Cuenta = "ChayanC",
                Password = "Cha385",
                Nombre = "Chayane",
                Matricula = "JI326",
                Edad = 20,
            });
            listE.Add(new Estudiante()
            {
                Cuenta = "CristianoR",
                Password = "Bic567",
                Nombre = "Cristiano",
                Matricula = "JR789",
                Edad = 25,
            });

            MostrarL(listE);

            Double promE = getPromE(listE);
            Console.WriteLine("\n--- Primer Promedio: {0}", promE.ToString("##.##"));

            double promE2 = getPromED(listE);
            Console.WriteLine("\n--- Segundo Promedio: {0}", promE2.ToString("##.##"));

            double promE3 = getPromET(listE);
            Console.WriteLine("\n--- Tercer Promedio: {0}", promE3.ToString("##.##"));

            double promE4 = getPromEC(listE);
            Console.WriteLine("\n--- Cuarto Promedio: {0}", promE4.ToString("##.##"));

            List<Docente> listaD = new List<Docente>();
            listaD.Add(new Docente()
            {
                Cuenta = "ArielJ",
                Password = "65478",
                Nombre = "Ariel",
                Sueldo = 20000,
            });
            listaD.Add(new Docente()
            {
                Cuenta = "MaximoK",
                Password = "36784",
                Nombre = "Maximo",
                Sueldo = 18000,
            });
            listaD.Add(new Docente()
            {
                Cuenta = "SamP",
                Password = "03758",
                Nombre = "Sam",
                Sueldo = 15000,
            });

            MostrarL(listaD);

            Double prom = getProm(listaD);
            Console.WriteLine("\n--- Primer Promedio: {0}", prom.ToString("##.##"));

            double prom2 = getPromD(listaD);
            Console.WriteLine("\n--- Segundo Promedio: {0}", prom2.ToString("##.##"));

            double prom3 = getPromT(listaD);
            Console.WriteLine("\n--- Tercer Promedio: {0}", prom3.ToString("##.##"));

            double prom4 = getPromC(listaD);
            Console.WriteLine("\n--- Cuarto Promedio: {0}", prom4.ToString("##.##"));

            Console.Read();
        }



        private static double getPromC(List<Docente> listaD)
        {

            decimal prom = (

                from item in listaD
                where item.Sueldo < 30000
                select item.Sueldo

                ).Average();
            return (double)prom;
        }

        private static double getPromT(List<Docente> listaD)
        {

            decimal sum = listaD.Sum(x => x.Sueldo);
            int total = listaD.Count;
            return (double)(sum / total);
        }

        private static double getPromD(List<Docente> listaD)
        {

            decimal prom = listaD.Average(x => x.Sueldo);
            return (double)prom;
        }

        private static double getProm(List<Docente> listaD)
        {
            Decimal sum = 0;
            foreach (Docente item in listaD)
            {
                sum += item.Sueldo;
            }
            return (double)(sum / listaD.Count()); //Cast
        }

        private static void MostrarL(List<Docente> listaD)
        {
            Console.WriteLine("\n---------LISTA DE DOCENTES---------\n");
            foreach (Docente item in listaD)
            {
                Console.WriteLine(item.ToString());
            }
        }



        private static double getPromEC(List<Estudiante> listE)
        {

            decimal prom = (

                from item in listE
                where item.Edad < 23
                select item.Edad

                ).Average();
            return (double)prom;
        }

        private static double getPromET(List<Estudiante> listE)
        {

            decimal sum = listE.Sum(x => x.Edad);
            int total = listE.Count;
            return (double)(sum / total);
        }

        private static double getPromED(List<Estudiante> listE)
        {

            decimal prom = listE.Average(x => x.Edad);
            return (double)prom;
        }

        private static double getPromE(List<Estudiante> listE)
        {
            Decimal sum = 0;
            foreach (Estudiante item in listE)
            {
                sum += item.Edad;
            }
            return (double)(sum / listE.Count()); //Cast
        }

        private static void MostrarL(List<Estudiante> listE)
        {
            Console.WriteLine("\n---------LISTA DE ESTUDIANTES---------\n");
            foreach (Estudiante item in listE)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
