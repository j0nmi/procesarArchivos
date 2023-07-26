using Newtonsoft.Json;

namespace ImportarJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

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
                Console.WriteLine($" Moneda: {name} | Codigo: {code} | Valor en USD: {value}.");
            }
        }
    }
}