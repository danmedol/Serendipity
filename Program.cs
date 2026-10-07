using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Globalization;

namespace Serendipity
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Serendipity 1.1\nPara consultar informações sobre asteroides próximos à terra, digite uma data (no formato AAAA-MM-DD): ");
            string dataInserida = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dataInserida))
            {
                Console.WriteLine("Data inválida. Por favor, digite uma data válida (no formato AAAA-MM-DD).");
                return;
            }

            HttpClient client = new HttpClient();

            Root root = await GetRootAsync(client: client, date: dataInserida);

            Console.WriteLine($"{root.ElementCount} objetos foram encontrados próximos à Terra nessa data.");

            foreach(var day in root.NearEarthObjects)
            {
                foreach(var asteroid in day.Value)
                {
                    
                    Console.WriteLine($"Nome: {asteroid.Name}");
                    Console.WriteLine($"Identificação: {asteroid.Id}");
                    Console.WriteLine($"Diâmetro: {asteroid.EstimatedDiameter?.Kilometers?.EstimatedDiameterMax:F2} KM");
                    Console.WriteLine($"Velocidade: {double.Parse(asteroid.CloseApproachData?[0]?.RelativeVelocity?.KilometersPerHour, CultureInfo.InvariantCulture):F2} KM/H");
                    Console.WriteLine($"Distância: {double.Parse(asteroid.CloseApproachData?[0]?.MissDistance?.Kilometers, CultureInfo.InvariantCulture):F2} KM");
                    
                    if(asteroid.IsPotentiallyHazardousAsteroid == true)
                    {
                        Console.WriteLine($"Risco de colisão: Sim");
                    }
                    else
                    {
                        Console.WriteLine($"Risco de colisão: Não");
                    }
                    
                    Console.WriteLine("----------------------------------------");

                }
            }

        }

        static async Task<Root> GetRootAsync(HttpClient client, string date)
        {
            string apiKey = Environment.GetEnvironmentVariable("NASA_API_KEY") ?? "";
            string url = $"https://api.nasa.gov/neo/rest/v1/feed?start_date={date}&end_date={date}&api_key={apiKey}";
            HttpResponseMessage response = await client.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                string neowsJson = await response.Content.ReadAsStringAsync();
                Root root = JsonSerializer.Deserialize<Root>(neowsJson);
                return root;
            }
            else
            {
                Console.WriteLine("Erro na requisição");
                return null;
            }
            
        }
    }
}
