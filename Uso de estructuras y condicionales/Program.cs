using System;

class Program
{
    static void Main(String[] args)
    {

        try
        {
            Console.WriteLine(">>¿Cual es el mayor de los 3 numeros?<<");
            Console.WriteLine("\nIngrese su primer numero. ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su tercer numero");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor = num1;


            if (num2 > mayor)
            {
                mayor = num2;
            }
            if (num3 > mayor)
            {
                mayor = num3;
            }
            Console.WriteLine("el mayor es: " + mayor);


            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Los tres numero son iguales. ");
            }
            else if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Dos de los numeros son iguales los cuales son el: " + mayor);

            }

        }
        catch (Exception error)
        {
            Console.WriteLine("Por favor solo ingresar numeros: " + error.Message);
        }

        try
        {
            Console.WriteLine("\n>>Edad para ingresar al club<<");
            Console.WriteLine("\nIngrese su edad: ");
            int edadClub = Convert.ToInt32(Console.ReadLine());

            if (edadClub >= 18)
            {
                Console.WriteLine(" eres mayor de edad puedes ingresar al club. ");
            }
            else
            {
                Console.WriteLine(" Usted es menor de edad su acceso al club a sido denegado, lo sentimos. ");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Por favor solo ingresar tu edad en numeros: " + error.Message);
        }

        try
        {
            Console.WriteLine("\n>>Decuento en producto mayor a 100 Quetzale<< ");
            Console.WriteLine("\nIngrese el precio original del producto. ");
            double Precio = Convert.ToDouble(Console.ReadLine());

            if (Precio > 100)
            {
                double descuento = Precio * 0.10;
                double precioFinal = Precio - descuento;
                Console.WriteLine("El precio del producto aplicando el descuento es de: " + precioFinal);
            }
            else
            {
                Console.WriteLine("El precio del producto sin aplicar el descuento por ser menor a 100 es: " + Precio);
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Por favor ingresar solo numeros " + error.Message);
        }

        try
        {
            string usuario = "usuario";
            string contra = "contraseña";

            Console.WriteLine("\n>>Ingresar con su usuario y contraseña (nombre: usuario, contraseña: contraseña<<");
            Console.WriteLine("\nIngrese su nombre de usuario: ");
            string NombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu contraseña: ");
            string contraseña = Console.ReadLine();

            if (NombreUsuario == usuario && contraseña == contra)
            {
                Console.WriteLine("Acceso concedido Bienvenido " + usuario);
            }
            else
            {
                Console.WriteLine("Acceso denegado. ");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }

        try
        {
            Console.WriteLine("\n>>Determina si un numero es par o impar<< ");
            Console.WriteLine("\nIntroduzca su numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Tu numero es par: ");
            }
            else
            {
                Console.WriteLine("El numero es un impar: ");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Por favor solo ingresar numeros: " + error.Message);
        }

        try
        {
            Console.WriteLine("\n>>Solicitar un Prestamo<<");
            Console.WriteLine("\nIngrese la cantidad dle prestamo que desea solicitar: ");
            int Prestamo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su edad:  ");
            int Edad = Convert.ToInt32(Console.ReadLine());

            if (Prestamo < 5000 || Edad >= 60)
            {
                Console.WriteLine("Su prestamo a sido aprovado: ");
            }
            else
            {
                Console.WriteLine("SU prestamo asido rechazado: ");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Porfavor ingresar solo numeros para realizar el proceso: " + error.Message);
        }

        try
        {
            Console.WriteLine("\nCalcula el area de una figura geometrica<<");
            Console.WriteLine("\nIngrese la figura geometrica que desea calcular (triangulo, circulo o cuadrado: ");
            string tipoFigura = Console.ReadLine().ToLower();

            double area = 0;

            switch (tipoFigura)
            {
                case "triangulo":
                    Console.WriteLine("\nIngrese la base del triangulo: ");
                    double Base = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    area = Base * altura / 2;
                    break;
                case "cuadrado":
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                    area = ladoCuadrado * ladoCuadrado;
                    break;
                case "circulo":
                    Console.WriteLine("Ingrese el radio del circulo:");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * Math.Pow(radio, 2);
                    break;
                default:
                    Console.WriteLine("La figura no pertenece a las permitidas: ");
                    return;
            }

            Console.WriteLine("El area de la figura es:  " + area);


        }
        catch (Exception error)
        {
            Console.WriteLine("Por favor ingresar las dimenciones en numeros:" + error.Message);
        }




    }


}

