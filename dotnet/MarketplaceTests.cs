using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class MarpletplaceTests : PageTest
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
    private int MaxAttempts = 100;
#endif

    [Test]
    public async Task Download_APIClientCodeGenerator_For_VS2019()
    {
        const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.APIClientCodeGenerator";
        const string output = "APIClientCodeGenerator.vsix";
        await Download(url, output);
    }

    [Test]
    public async Task Download_APIClientCodeGenerator2022_For_VS2022()
    {
        const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.APIClientCodeGenerator2022";
        const string output = "APIClientCodeGenerator2022.vsix";
        await Download(url, output);
        Assert.True(File.Exists(output));
    }

    [Test]
    public async Task Download_ResWFileCodeGenerator()
    {
        const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ResWFileCodeGenerator";
        const string output = "ResWFileCodeGenerator.vsix";
        await Download(url, output);
        Assert.True(File.Exists(output));
    }

    private async Task Download(string url, string output)
    {
        var random = new Random();
        var length = random.Next(1, MaxAttempts);
        for (int i = 0; i < length; i++)
        {
            var browser = await Playwright.Chromium.LaunchAsync(browserTypeLaunchOptions);
            var context = await browser.NewContextAsync(options);
            var page = await context.NewPageAsync();
            await page.GotoAsync(url);

            if (random.Next(2) != 0)
                continue;

            var waitForDownloadTask = page.WaitForDownloadAsync();
            var button = page.Locator("button:has-text('Download')");
            await button.ClickAsync();
            var download = await waitForDownloadTask;
            await download.SaveAsAsync(output);
        }
    }
}