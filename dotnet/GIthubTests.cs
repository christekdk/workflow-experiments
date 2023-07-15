using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace PlaywrightTests;

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
            var browser = await Playwright.Chromium.LaunchAsync(browserTypeLaunchOptions);
            var context = await browser.NewContextAsync(options);

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://github.com/christianhelle/sqlcequery");
            await page.GetByRole(AriaRole.Link, new() { NameString = "v1.3.3 Latest Apr 14, 2023on Apr 14" }).ClickAsync();
            await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
            await page.GetByText("v1.3.3 Latest").ClickAsync();

            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            await page.Locator("body:has-text(\"Skip to content Toggle navigation Sign up Product Actions Automate any workflow \")").PressAsync("ArrowDown");
            
            var download1 = await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "SQLCEQueryAnalyzer-Binaries-x64.zip" }).ClickAsync();
            });
            await Task.Delay(1000);
            // await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
            var download2 = await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "SQLCEQueryAnalyzer-Binaries-x86.zip" }).ClickAsync();
            });
            await Task.Delay(1000);
            // await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
            var download3 = await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "SQLCEQueryAnalyzer-Setup-x64.exe" }).ClickAsync();
            });
            await Task.Delay(1000);
            // await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
            var download4 = await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "SQLCEQueryAnalyzer-Setup-x86.exe" }).ClickAsync();
            });
            await Task.Delay(1000);
            // await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
            var download5 = await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "Source code (zip)" }).ClickAsync();
            });
            // await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
            var download6 = await page.RunAndWaitForDownloadAsync(async () =>
            {
                await page.GetByRole(AriaRole.Link, new() { NameString = "Source code (tar.gz)" }).ClickAsync();
            });
            await Task.Delay(1000);
            // await page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.3.3");
        }
    }
}