using _20251900163_Cristian_Medina_U2T1.appServices;
using _20251900163_Cristian_Medina_U2T1.models;

namespace _20251900163_Cristian_Medina_U2T1{
    internal class Program{
        static async Task Main(string[] args){

            characterService servicio = new characterService();

            Console.WriteLine("--- Cargando personajes de Rick and Morty ---");
            var personajes = await servicio.getCharacter();

            if (personajes.Any()){
                foreach (var c in personajes){
                    Console.WriteLine($"ID: {c.Id} | Nombre: {c.Name} | Especie: {c.Species}");
                }
            }else{
                Console.WriteLine("No se encontraron personajes o hubo un error de conexión.");
            }
        }
    }
}
