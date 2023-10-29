namespace TABLAS_DE_MULTIPLICACION_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, RESUL;
            string linea;
            Console.Write("DIGITE NUMERO: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            I = 1;
            while ((I <= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
                I = I + 1;
            }
            Console.Write("Pulse una tecla: "); Console.ReadLine();
        }
    }
}