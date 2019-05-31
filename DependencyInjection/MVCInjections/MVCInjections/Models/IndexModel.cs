using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MVCInjections.Models
{
    public class IndexModel : PageModel
    {
        IMyDependency _dependency;
        public IndexModel(IMyDependency myDependency)
        {
            _dependency = myDependency;
        }

        public async Task OnGetAsync()
        {
            await _dependency.WriteMessage(
            "IndexModel.OnGetAsync created this message.");
        }
    }
}
