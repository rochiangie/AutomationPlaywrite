using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[TestFixture]
public class BusquedaTest : PageTest
{
    [Test]
    public async Task TestEjemploBusqueda()
    {
        // 1. Navegar a la página de Google
        await Page.GotoAsync("https://www.google.com");

        // 2. Localizar la barra de búsqueda y escribir
        var barraBusqueda = Page.GetByRole(AriaRole.Combobox, new() { Name = "Buscar" });
        await barraBusqueda.FillAsync("Playwright C#");
        await barraBusqueda.PressAsync("Enter");

        // 3. Validar que el título sea el correcto
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright C#"));
    }
}