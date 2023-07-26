using Newtonsoft.Json;

namespace ImportarJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = string.Empty;

            while (opcion != "3")
            {
                Console.Clear();
                Console.WriteLine($"\n\t MONEDAS.JSON\n");
                Console.WriteLine($"\t 1-. Listar monedas");
                Console.WriteLine($"\t 2-. Crear monedas");
                Console.WriteLine($"\t 3-. Salir");

                Console.Write($"\n\n\t Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"\n\t LISTADO MONEDAS (monedas.json)\n");
                        // Ruta del fichero .json
                        string rutaJson = "..\\..\\..\\monedas.json";

                        // Guarda el contenido de monedas.json en la variable json
                        string json = File.ReadAllText(rutaJson);

                        // Deserializa el json en la lista de monedas
                        List<Monedas> listaMonedas = JsonConvert.DeserializeObject<List<Monedas>>(json);

                        foreach (Monedas moneda in listaMonedas)
                        {
                            string name = moneda.nombre;
                            string code = moneda.codigo;
                            float value = moneda.valorEnDolares;
                            Console.WriteLine($"\t Moneda: {name} | Codigo: {code} | Valor en USD: {value}.");
                        }
                        Thread.Sleep(2000);
                            break;
                    case "2":
                        // Pedimos valores
                        Console.Write($" Nombre de la nueva moneda: ");
                        string nombreNuevaMoneda = Console.ReadLine();
                        Console.Write($" Codigo de la nueva moneda: ");
                        string codigoNuevaMoneda = Console.ReadLine();
                        Console.Write($" Valor de la nueva moneda: ");
                        float valorEnDolares = float.Parse(Console.ReadLine());


                        break;
                    case "3":
                        break;
                }
                
            }
        }
    }
}