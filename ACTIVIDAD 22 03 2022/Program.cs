using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicamentosEnf med = new MedicamentosEnf();
            med.MedicamentosGripe();
        }
    }

    public class MedicamentosEnf
    {
        public string enfermedad;
        public int medicamento;
        public string Nombre;
        public void MedicamentosGripe()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HOLA, BIENVENIDO A LA FARMACIA DEL NORTE \n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DINOS EL NOMBRE DE LA ENFERMEDAD PARA MOSTRARTE MEDICAMENTOS ACORDE A ELLA ");
            Console.ForegroundColor = ConsoleColor.White;
            enfermedad =Console.ReadLine();
            Console.Clear();
            if (enfermedad == "gripe" || enfermedad == "resfriado")
            {
                Console.WriteLine("ID            NOMBRE                       gr                  PRECIO/UNIT");
                Console.WriteLine("1-            ACETAMINOFEN                 500                 $2.50");
                Console.WriteLine("2-            VIROGRIP                     250                 $0.50");
                Console.WriteLine("3-            PALAGRIP                     150                 $0.70");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ESCOJA UN MEDICAMENTO POR FAVOR. ");
                Console.ForegroundColor= ConsoleColor.White;
                medicamento=Convert.ToInt32(Console.ReadLine());
                if(medicamento == 1)
                {
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         ACETAMINOFEN        500GR           $2.50\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                           $2.50\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");

                }
                if (medicamento == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         VIROGRIP        250GR           $0.50\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                       $0.50\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");
                }
                if (medicamento == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         PALAGRIP        150GR           $0.70\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                       $0.70\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");
                }
            }
            if (enfermedad == "alergia")
            {
                Console.WriteLine("ID            NOMBRE                       gr                  PRECIO/UNIT");
                Console.WriteLine("1-            ACETAMINOFEN                 500                 $2.50");
                Console.WriteLine("2-            LORATADINA                   200                 $1.50");
                Console.WriteLine("3-            ANADEN                       100                 $2.70");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ESCOJA UN MEDICAMENTO POR FAVOR. ");
                Console.ForegroundColor = ConsoleColor.White;
                medicamento = Convert.ToInt32(Console.ReadLine());
                if (medicamento == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         ACETAMINOFEN        500GR           $2.50\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                           $2.50\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");

                }
                if (medicamento == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         LORATADINA      200GR           $1.50\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                       $1.50\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");
                }
                if (medicamento == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         ANADEN          100GR           $2.70\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                       $2.70\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");
                }
            }
            if (enfermedad == "lesion")
            {
                Console.WriteLine("ID            NOMBRE                       gr/°                  PRECIO/UNIT");
                Console.WriteLine("1-            ACETAMINOFEN                 500                   $2.50");
                Console.WriteLine("2-            ALCOHOL                      90                    $5.50");
                Console.WriteLine("3-            VENDAS                       -                     $1.70");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ESCOJA UN MEDICAMENTO POR FAVOR. ");
                Console.ForegroundColor = ConsoleColor.White;
                medicamento = Convert.ToInt32(Console.ReadLine());
                if (medicamento == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         ACETAMINOFEN        500GR           $2.50\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                           $2.50\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");

                }
                if (medicamento == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:          ACOHOL         90°             $5.50\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                       $5.50\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");
                }
                if (medicamento == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DINOS TU NOMBRE POR FAVOR, ESTO ES PARA GENERAR LA FACTURA.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Nombre = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TU ORDEN ES:         VENDAS          -               $1.70\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TOTAL A PAGAR:                                       $1.70\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("MUCHAS GRACIAS REGRESA PRONTO.!");
                }
            }
        }
    }



}
