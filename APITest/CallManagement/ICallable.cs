using DataModel;
using System.Threading.Tasks;
namespace APITest
{
    public interface ICallable
    {
        int StatusCode { get; }
        string StatusDescription { get; }
        //Task<IResult> Query<IResult>(string input);
        Task<Film[]> Request(string input);
    }
}