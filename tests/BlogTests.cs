using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Diagnostics;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BlogTests : PageTest
{
    [Test]
    public async Task Main_Page()
    {
        const string url = "https://christianhelle.com";

        var browser = await Playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions { Headless = !Debugger.IsAttached });
        var context = await browser.NewContextAsync(new BrowserNewContextOptions { AcceptDownloads = true });
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);
        await page.ClickAsync("a[id='cookie-notice-accept']");
        await page.ClickAsync("span[class='IL_AD']");
    }

    [Test]
    public async Task Autofaker()
    {
        const string url = "https://christianhelle.com/2022/10/autofaker";

        var browser = await Playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions { Headless = !Debugger.IsAttached });
        var context = await browser.NewContextAsync(new BrowserNewContextOptions { AcceptDownloads = true });
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);
        await page.ClickAsync("a[id='cookie-notice-accept']");
        await page.ClickAsync("span[class='IL_AD']");
    }

    [Test]
    public async Task Orchestrated_ETL()
    {
        const string url = "https://christianhelle.com/2022/09/orchestrated-etl";

        var browser = await Playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions { Headless = !Debugger.IsAttached });
        var context = await browser.NewContextAsync(new BrowserNewContextOptions { AcceptDownloads = true });
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);
        await page.ClickAsync("a[id='cookie-notice-accept']");
        await page.ClickAsync("span[class='IL_AD']");
    }
}