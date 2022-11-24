using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BlogTests : PageTest
{
    private readonly BrowserTypeLaunchOptions browserTypeLaunchOptions = new BrowserTypeLaunchOptions
    {
#if DEBUG
        Headless = false,
#endif
    };

#if DEBUG
    private readonly int MaxAttempts = 1;
#else
    private int MaxAttempts = 100;
#endif

    [Test]
    public async Task Main_Page_Open_AutoFaker()
    {
        const string startUrl = "https://christianhelle.com";

        var length = new Random().Next(1, MaxAttempts);
        for (int i = 0; i < length; i++)
            await Launch(startUrl, i, "a[href='/2022/10/autofaker.html']");
    }

    [Test]
    public async Task Main_Page_Open_Orchestrated_ETL()
    {
        const string startUrl = "https://christianhelle.com";

        var length = new Random().Next(1, MaxAttempts);
        for (int i = 0; i < length; i++)
            await Launch(startUrl, i, "a[href='/2022/09/orchestrated-etl.html']");
    }

    private async Task Launch(string url, int index, params string[] selectors)
    {
        var browser = await Playwright.Firefox.LaunchAsync(browserTypeLaunchOptions);
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);
        for (int i = 0; i < 100; i++)
        {
            await page.Mouse.WheelAsync(0, 10);
        }
        if (index == 0)
            await page.ClickAsync("a[id='cookie-notice-accept']");
        foreach (var selector in selectors)
            await page.ClickAsync(selector);
    }
}
