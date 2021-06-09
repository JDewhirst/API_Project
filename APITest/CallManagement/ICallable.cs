using DataModel;
using System.Threading.Tasks;

namespace APITest
{
    public interface ICallable
    {
        int StatusCode { get; }
        string StatusDescription { get; }

        Task<Result> DeleteFilm(string request);
    }
}