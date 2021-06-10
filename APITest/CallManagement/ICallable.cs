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

        Task<Result> UpdateFilm(string request);

        Task<Result> Request(string request);
    }
}