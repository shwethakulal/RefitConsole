using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RefitConsole
{
    public interface IAlbumAPI
    {
        [Get("/albums")]
        Task<List<Album>> GetAllAlbums();
    }
}
