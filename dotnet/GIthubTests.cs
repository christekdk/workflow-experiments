using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class GithubTests : PageTest
{
    private readonly BrowserTypeLaunchOptions browserTypeLaunchOptions = new BrowserTypeLaunchOptions
    {
        ChromiumSandbox = true,
#if DEBUG
        Headless = false,
#endif
    };

    private readonly BrowserNewContextOptions options =
        new BrowserNewContextOptions
        {
            AcceptDownloads = true
        };

#if DEBUG
    private readonly int MaxAttempts = 1;
#else
    private int MaxAttempts = 50;
#endif

    [Test]
    public async Task SqlCeQueryAnalyzer_Download()
    {
        var random = new Random();
        var length = random.Next(1, MaxAttempts);
        for (int i = 0; i < length; i++)
        {
            var browser = await (i % 2 == 0 ? Playwright.Firefox : Playwright.Chromium).LaunchAsync(browserTypeLaunchOptions);
            var context = await browser.NewContextAsync(options);

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://github.com/christianhelle");

            await page.GetByRole(AriaRole.Link, new() { NameString = "sqlcequery" }).ClickAsync();
            await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery");

            await page.GetByRole(AriaRole.Link, new() { NameString = "1.2.6626 Latest May 1, 2021on May 1, 2021" }).ClickAsync();
            await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.2.6626");

            await page.Mouse.WheelAsync(0, 1000);

            await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "SQL.Compact.Query.Analyzer.Setup.v1.2.6626.exe" }).ClickAsync();
            });
            await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.2.6626");

            await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "SQL.Compact.Query.Analyzer.v1.2.6626.zip" }).ClickAsync();
            });
            await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.2.6626");
        }
    }
}