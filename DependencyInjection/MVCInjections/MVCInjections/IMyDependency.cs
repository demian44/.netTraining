using System.Threading.Tasks;

namespace MVCInjections
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}