﻿using System;
using System.Text.Json;
using System.Threading.Tasks;
using lesson.Dto.PrayerTime;
using lesson.Dto.User;
using lesson.Services;

namespace lesson
{
    class Program
    {
        private static string usersApi = "https://randomuser.me/api/";
        private static string prayerTimeApi = "http://api.aladhan.com/v1/timingsByCity?city=Tashkent&country=Uzbekistan&method=8";
        static async Task Main(string[] args)
        {
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<PrayerTime>(prayerTimeApi);

            if(result.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                var json = JsonSerializer.Serialize(result.Data, settings);
                Console.WriteLine($"{json}");
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
        static async Task Main_user(string[] args)
        {
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<User>(usersApi);

            if(result.IsSuccess)
            {
                Console.WriteLine($"{result.Data.Results[0].Name.First}");
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
    }
}