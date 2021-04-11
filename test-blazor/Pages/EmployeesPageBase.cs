using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using test_blazor.Data.Repository;
using test_models.Tables;

namespace test_blazor.Pages
{
    public class EmployeesPageBase : ComponentBase
    {
        protected IEnumerable<Employee> Employees { get; set; }
        [Inject]
        protected IEmployeeRepo context { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await context.GetEmployees()).ToList();
        }
    }
}