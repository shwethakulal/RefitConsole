using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RefitConsole
{
    public interface IGitHubApi
    {
        [Get("/albums/{userId}")]
        Task<Album> GetUser(int userId);
    }
}

