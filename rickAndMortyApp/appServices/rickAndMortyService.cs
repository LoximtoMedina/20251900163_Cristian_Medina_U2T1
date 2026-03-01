using _20251900163_Cristian_Medina_U2T1.rickAndMortyApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace _20251900163_Cristian_Medina_U2T1.rickAndMortyApp.appServices{
    public class characterService{
        private readonly HttpClient _httpClient;

        public characterService(){
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
        }

        public async Task<List<character>> getCharacter(){
            try{
                HttpResponseMessage httpResponse = await _httpClient.GetAsync("character");

                if (!httpResponse.IsSuccessStatusCode) { return new List<character>();}

                var apiResponse = await httpResponse.Content.ReadFromJsonAsync<ApiResponse>();

                return apiResponse?.Results ?? new List<character>();

            }catch (Exception ex){
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return new List<character>();
            }
        }
    }
}