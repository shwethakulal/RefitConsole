using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefitConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadKey();
        }
        static async Task RunAsync()
        {
            //For displaying particulat album 
            //var gitHubApi = RestService.For<IAlbumAPI>("https://jsonplaceholder.typicode.com");
            //var albumName = await gitHubApi.GetUser(1);
            //Console.WriteLine(albumName.title);

            //For displaying all albums
            var gitHubApi = RestService.For<IAlbumAPI>("https://jsonplaceholder.typicode.com");
            List<Album> userId = await gitHubApi.GetAllAlbums();
            foreach (Album user in userId)
            {
                Console.WriteLine("{0} \t{1}\t {2}", user.userId, user.id, user.title);

            }

        }
    }
}
