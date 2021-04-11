using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using test_blazor.Data.Repository;
using test_models.Tables;

namespace test_blazor.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        [Parameter]
        public int id { get; set; }
        protected Employee employee { get; set; } = new Employee();
        [Inject]
        protected IEmployeeRepo context { get; set; }

        protected override async Task OnInitializedAsync()
        {
            employee = await context.GetEmployee(id);
        }
    }
}