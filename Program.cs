using System;

namespace Proyecto_Final
{
    /*Con la siguiente informacion:
     * -Nombres de 5 empleados.
     * -Salario,cobrado por cada empleado, en los 3 ultimos meses.
     * 
     * Crear un programa para:
     * a)Cargsr la informacion de los empleados y sus respectivos sueldos.
     * b)Generar un vector que contenga el ingreso acumulado en salariod en los ultimos 3 meses.
     * c)Mostrar por pantalla el total pagado del salario a todos los empleados en los ultimos tres meses.
     * d)Obtenerel nombre del empleado que tuvo el mayor ingreso acumulado.
     */
    class Empleado 
    {
        //Total de todos los salarios
        private float total;
        //Informacion del primer empleado
        private string nombre;
        private float[] sueldo1;
        private float totalsueldo1;
        //Informacion del segundo empleado
        private string nombre2;
        private float[] sueldo2;
        private float totalsueldo2;
        //Informacion del tercer empleado
        private string nombre3;
        private float[] sueldo3;
        private float totalSueldo3;
        //Informacion del cuarto empleado
        private string nombre4;
        private float[] sueldo4;
        private float totalSueldo4;
        //Informacion del quinto empleado
        private string nombre5;
        private float[] sueldo5;
        private float totalSueldo5;

        public Empleado() 
        {
            //Primer Empleado
            Console.WriteLine("Introducir el nombre del empleado: ");
            nombre = Console.ReadLine();
            sueldo1 = new float[3];
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Introducir el sueldo de los ultimos 3 meses: ");
                sueldo1[i] = int.Parse(Console.ReadLine());
            }
            totalsueldo1 = sueldo1[0] + sueldo1[1] + sueldo1[2];
            //Segundo Empleado
            Console.WriteLine("Introducir el nombre del empleado: ");
            nombre2 = Console.ReadLine();
            sueldo2 = new float[3];
            for(int f = 0; f < 3; f++) 
            {
                Console.WriteLine("Introducir el sueldo de los ultimos 3 meses: ");
                sueldo2[f] = int.Parse(Console.ReadLine());
            }
            totalsueldo2 = sueldo2[0] + sueldo2[1] + sueldo2[2];
            //Tercer empleado
            Console.WriteLine("Introducir el nombre del empleado: ");
            nombre3 = Console.ReadLine();
            sueldo3 = new float[3];
            for (int a = 0; a < 3; a++) 
            {
                Console.WriteLine("Introducir el sueldo de los ultimos 3 meses: ");
                sueldo3[a] = int.Parse(Console.ReadLine());
            }
            totalSueldo3 = sueldo3[0] + sueldo3[1] + sueldo3[2];
            //Cuarto Empleado
            Console.WriteLine("Introducir el nombre del empleado: ");
            nombre4 = Console.ReadLine();
            sueldo4 = new float[3];
            for(int b = 0; b < 3; b++) 
            {
                Console.WriteLine("Introducir el sueldo de los 3 ultimos meses: ");
                sueldo4[b] = int.Parse(Console.ReadLine());

            }
            totalSueldo4 = sueldo4[0] + sueldo4[1] + sueldo4[2];
            //Quinto Empleado
            Console.WriteLine("Introducir el nombre del empleado: ");
            nombre5 = Console.ReadLine();
            sueldo5 = new float[3];
            for (int c = 0; c < 3; c++) 
            {
                Console.WriteLine("Introducir el sueldo de los 3 ultimos meses: ");
                sueldo5[c] = int.Parse(Console.ReadLine());
            }
            totalSueldo5 = sueldo5[0] + sueldo5[1] + sueldo5[2];
        
        }
        
        public void Comparar() 
        {
            //Comparacion del sueldo total del primer empleados con los otros 4.
        if ((totalsueldo1 > totalsueldo2) && (totalsueldo1 > totalSueldo3) && (totalsueldo1 > totalSueldo4) && (totalsueldo1 > totalSueldo5)) 
            {
                Console.WriteLine("El empleado de mayor ingreso total fue: " + nombre);
                Console.WriteLine("Con un sueldo total de: " + totalsueldo1);
            }
            //Comparacion del sueldo total del segundo empleado con los otros 4.
            else if ((totalsueldo2>totalsueldo1)&&(totalsueldo2>totalSueldo3)&&(totalsueldo2>totalSueldo4)&&(totalsueldo2>totalSueldo5)) 
            {
                Console.WriteLine("El empleado de mayor ingreso en total fue: " + nombre2);
                Console.WriteLine("Con un sueldo total de: " + totalsueldo2);
            }
            //Comparacion del sueldo total del tercer empleado con los otros 4.
            else if ((totalSueldo3>totalsueldo1)&&(totalSueldo3>totalsueldo1)&&(totalSueldo3>totalSueldo4)&&(totalSueldo3>totalSueldo5)) 
            {
                Console.WriteLine("El empleado de mayor ingreso en total fue: " + nombre3);
                Console.WriteLine("Con un sueldo total de: " + totalSueldo3);
            }
            //Comparacion del sueldo total del cuarto empleado con los otros 4.
            else if ((totalSueldo4>totalsueldo1)&&(totalSueldo4>totalsueldo2)&&(totalSueldo4>totalSueldo3)&&(totalSueldo4>totalSueldo5)) 
            {
                Console.WriteLine("El empleado de mayor ingreso en total fue: " + nombre4);
                Console.WriteLine("Con un sueldo total de: " + totalSueldo4);
            }
            //Comparacion del sueldo total del quinto empleado con los otros 4.
            else
            {
                Console.WriteLine("El empleado de mayor ingreso en total fue: " + nombre5);
                Console.WriteLine("Con un sueldo total de: " + totalSueldo5);
            }
        }
        public void Imprimir() 
        {
            Console.WriteLine("El nombre del primer empleado es: " + nombre + " Su sueldo total es: " + totalsueldo1);
            Console.WriteLine("El nombre del segundo empleado es: " + nombre2 + " Su sueldo total es: " + totalsueldo2);
            Console.WriteLine("El nombre del tercer empleado es: " + nombre3 + " Su sueldo total es: " + totalSueldo3);
            Console.WriteLine("El nombre del cuarto empleado es: " + nombre4 + " Su sueldo total es: " + totalSueldo4);
            Console.WriteLine("El nombre del quinto empleado es: " + nombre5 + " Su sueldo total es: " + totalSueldo5);
            total = totalsueldo1 + totalsueldo2 + totalSueldo3 + totalSueldo4 + totalSueldo5;
            Console.WriteLine("El total de todos los sueldo juntos es: " + total);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Imprimir();
            empleado.Comparar();
            Console.ReadKey();
        }
    }
}
