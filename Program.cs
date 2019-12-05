using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu1.Clases;
namespace menu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("(1) Usuario Administrador");
            Console.WriteLine("(2) Usuario Comun");
            int opus = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese Contraseña");
            string contraseña = Console.ReadLine();

            if (opus==1)
            {

            


            Console.WriteLine("(1) Archivo");
            Console.WriteLine("(2) Maestro");
            Console.WriteLine("(3) Proceso");




            Console.WriteLine("Ingrese una Opción");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("(1) Abrir");
                    int op2 = int.Parse(Console.ReadLine());

                    switch (op2)
                    {
                        case 1:
                            Console.WriteLine("(1) Reciente");
                            int op3 = int.Parse(Console.ReadLine());

                            switch (op3)
                            {
                                case 1:

                                  Console.WriteLine(  new Ejemplo().Ejemploooo());
                                    break;
                            }
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("(1) Insertar");
                    Console.WriteLine("(2) Modificar");
                    Console.WriteLine("(3) Eliminar");


                    int op4 = int.Parse(Console.ReadLine());

                    switch (op4)
                    {
                        case 1:
                            Console.WriteLine(new UsuarioAdmi().Insertar());
                            break;
                        case 2:
                            Console.WriteLine(new UsuarioAdmi().Modificar());
                            break;
                        case 3:
                            Console.WriteLine(new UsuarioAdmi().Eliminar());
                            break;
                          
        
                        
                    }
                    break;

                case 3:
                    Console.WriteLine("(1) Consultar");
                    Console.WriteLine("(2) Procesar");

                    int op5 = int.Parse(Console.ReadLine());

                    switch (op5)
                    {
                        case 1:
                            Console.WriteLine(new UsuarioAdmi().Consultar());
                            break;
                        case 2:
                            Console.WriteLine(new UsuarioAdmi().Procesar());
                            break;
                        
                        



                    }
                    break;
                }
            }
            else
            {

                Console.WriteLine("(1) Archivo");
                Console.WriteLine("(2) Proceso");




                Console.WriteLine("Ingrese una Opción");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("(1) Abrir");
                        int op2 = int.Parse(Console.ReadLine());

                        switch (op2)
                        {
                            case 1:
                                Console.WriteLine("(1) Reciente");
                                int op3 = int.Parse(Console.ReadLine());

                                switch (op3)
                                {
                                    case 1:

                                        Console.WriteLine(new Ejemplo().Ejemploooo());
                                        break;
                                }
                                break;
                        }
                        break;

                    

                    case 2:
                        Console.WriteLine("(1) Insertar");
                        Console.WriteLine("(2) Procesar");

                        int op5 = int.Parse(Console.ReadLine());

                        switch (op5)
                        {
                            case 1:
                                Console.WriteLine(new UsuarioAdmi().Insertar());
                                break;
                            case 2:
                                Console.WriteLine(new UsuarioAdmi().Procesar());
                                break;





                        }
                        break;
                }
            }
            Console.ReadKey();
        }
        
    }
}
