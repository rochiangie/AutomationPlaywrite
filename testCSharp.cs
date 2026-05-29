using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[TestFixture]
public class ContactoAngieTest : PageTest
{
    [Test]
    public async Task TestContactoAngierochi()
    {
        await Page.GotoAsync("https://www.angierochi.com");
        await Page.WaitForSelectorAsync("#contactForm");

        await Page.FillAsync("#name", "Angie Test");
        await Page.FillAsync("#email", "angie.test@example.com");
        await Page.SelectOptionAsync("#service", new SelectOptionValue { Label = "QA Testing / Automatización" });
        await Page.FillAsync("#message", "Hola Angie, este es un mensaje de prueba desde Playwright.");

        await Page.ClickAsync("button[type='submit']");
        await Page.WaitForTimeoutAsync(3000);
    }
}