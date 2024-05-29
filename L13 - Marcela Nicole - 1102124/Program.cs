using L13___Marcela_Nicole___1102124;

class Program
{
    public static void Main()
    {
        string opcion = "";
        OperacionesMatrices objOperacionesMatrices = new OperacionesMatrices();
        do{
            Console.WriteLine("Por favor, elija una opción");
            Console.WriteLine("1. Multiplicación de matriz por un escalar \n2. Devolver todas las posiciones por fila de un elemento menor  \n3. Vector de pares \n4. Salir");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    objOperacionesMatrices.PrintMatriz(objOperacionesMatrices.MatrizEscalar(objOperacionesMatrices.ConstruirMatriz()));
                    break;

                case "2":
                    objOperacionesMatrices.PrintMatriz(objOperacionesMatrices.MatrizEscalar(objOperacionesMatrices.ConstruirMatriz()));
                    break;

                case "3":
                    objOperacionesMatrices.PrintMatriz(objOperacionesMatrices.Pares(objOperacionesMatrices.ConstruirMatriz()));
                    break;

                case "4":
                    Console.WriteLine("Gracias.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }while(opcion != "4");
    }
}