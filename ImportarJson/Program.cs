using Newtonsoft.Json;

namespace ImportarJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
              'Name': 'Bad Boys',
              'ReleaseDate': '1995-4-7T00:00:00',
              'Genres': [
                'Action',
                'Comedy'
              ]
            }";


            // Deserializa y guarda el objeto de tipo Movie en la variable m
            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            // Se extrae el nombre de la pelicula y se guarda en la variable name
            string name = m.Name;

            Console.WriteLine(name);
            // Bad Boys
        }
    }
}