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
    private const int MaxAttempts = 10;
#else
    private const int MaxAttempts = 50;
#endif

    // [Test]
    // public async Task Download_APIClientCodeGenerator2022_For_VS2017()
    // {
    //     const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.APIClientCodeGenerator2017";
    //     const string output = "vs2017.vsix";
    //     await Download(url, output);
    //     Assert.True(File.Exists(output));
    // }

    // [Test]
    // public async Task Download_APIClientCodeGenerator_For_VS2019()
    // {
    //     const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.APIClientCodeGenerator";
    //     const string output = "vs2019.vsix";
    //     await Download(url, output);
    //     Assert.That(File.Exists(output), Is.True);
    // }

    [Test]
    public async Task Download_APIClientCodeGenerator2022_For_VS2022()
    {
        const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.APIClientCodeGenerator2022";
        const string output = "vs2022.vsix";
        await Download(url, output);
        Assert.That(File.Exists(output), Is.True);
    }

    // [Test]
    // public async Task Download_ResWFileCodeGenerator()
    // {
    //     const string url = "https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ResWFileCodeGenerator";
    //     const string output = "ResWFileCodeGenerator.vsix";
    //     await Download(url, output);
    //     Assert.True(File.Exists(output));
    // }

    private async Task Download(string url, string output, int maxAttempts = MaxAttempts)
    {
        if (File.Exists(output))
        {
            File.Delete(output);
        }
        
        IBrowser browser = await Playwright.Chromium.LaunchAsync(browserTypeLaunchOptions);
        var context = await browser.NewContextAsync(options);
        var page = await context.NewPageAsync();
        await page.GotoAsync(url);

        var random = new Random();
        var length = maxAttempts;// == 1 ? 1 : random.Next(1, maxAttempts);
        for (int i = 0; i < length; i++)
        {
            var filename = i + "_" + output;
            var download = await page.RunAndWaitForDownloadAsync(
                async () =>
                {
                    await page
                        .GetByRole(AriaRole.Button, new() { NameString = "Download" })
                        .ClickAsync();
                });
                
            await download.SaveAsAsync(output);
        }
    }
}