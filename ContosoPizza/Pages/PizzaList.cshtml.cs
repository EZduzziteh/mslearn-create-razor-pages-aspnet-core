using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages
{
    public class PizzaListModel : PageModel
    {

        private readonly PizzaService service;

        public IList<Pizza> pizzaList { get; set; } = default!;

        public PizzaListModel(PizzaService service)
        {
            this.service = service;
        }
        public void OnGet()
        {
            pizzaList = service.GetPizzas();
        }
    }
}
