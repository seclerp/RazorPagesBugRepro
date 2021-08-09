using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication5.Pages.SomeView
{
    public class SomeView : PageModel
    {
        public string[] Strings { get; set; }

        public void OnGet()
        {

        }
    }
}