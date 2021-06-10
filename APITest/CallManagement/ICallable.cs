using DataModel;
using System.Threading.Tasks;
namespace APITest
{
    public interface ICallable
    {
        int StatusCode { get; }
        string StatusDescription { get; }
        Task DeleteFilm(string request);

        Task AddFilm(Film film);

        Task<Film> UpdateFilm(string request, Film upDate);

        Task<Result> Request(string request);
        Task<Result> RequestFilmography(string v);
    }
}