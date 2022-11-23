using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BlogTests : PageTest
{
    private readonly BrowserTypeLaunchOptions browserTypeLaunchOptions = new BrowserTypeLaunchOptions
    {
        ChromiumSandbox = true,
#if DEBUG
        Headless = false,
#endif
    };

    [Test]
    public async Task Main_Page_Open_AutoFaker()
    {
        const string url = "https://christianhelle.com";

        var browser = await Playwright.Firefox.LaunchAsync(browserTypeLaunchOptions);
        var context = await browser.NewContextAsync(new BrowserNewContextOptions { AcceptDownloads = true });
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);
        await page.ClickAsync("a[id='cookie-notice-accept']");
        await page.ClickAsync("a[href='/2022/10/autofaker.html']");
        await page.ClickAsync("span[class='IL_AD']");
    }

    [Test]
    public async Task Main_Page_Open_Orchestrated_ETL()
    {
        const string url = "https://christianhelle.com";

        var browser = await Playwright.Firefox.LaunchAsync(browserTypeLaunchOptions);
        var context = await browser.NewContextAsync(new BrowserNewContextOptions { AcceptDownloads = true });
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);        
        await page.ClickAsync("a[id='cookie-notice-accept']");
        await page.ClickAsync("a[href='/2022/09/orchestrated-etl.html']");
        await page.ClickAsync("span[class='IL_AD']");
    }

    [Test]
    public async Task Crawl_Archive()
    {
        const string url = "https://christianhelle.com/archives";

        var browser = await Playwright.Firefox.LaunchAsync(browserTypeLaunchOptions);
        var context = await browser.NewContextAsync(new BrowserNewContextOptions { AcceptDownloads = true });
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);
        var selectors = await page.QuerySelectorAllAsync("a");
    }
}