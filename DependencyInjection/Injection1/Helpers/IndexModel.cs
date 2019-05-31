using Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace Helpers
{
    public class IndexModel
    {
        var logger = new Logger<MyDependency>();

        MyDependency _dependency = new MyDependency();

        public async Task OnGetAsync()
        {
            await _dependency.WriteMessage(
                "IndexModel.OnGetAsync created this message.");
        }
    }
}
