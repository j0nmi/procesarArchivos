using Newtonsoft.Json;

namespace ImportarJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");


            string rutaJson = "..\\..\\..\\monedas.json";
            string json = File.ReadAllText(rutaJson);
            List<Monedas> listaMonedas = JsonConvert.DeserializeObject<List<Monedas>>(json);

            foreach (Monedas moneda in listaMonedas) 
            {
                string name = moneda.nombre;
                string code = moneda.codigo;
                float value = moneda.valorEnDolares;
                Console.WriteLine($" Moneda: {name} + Codigo: {code} + Valor: {value}.");
            }
        }
    }
}