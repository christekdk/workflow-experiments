using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class GithubTests : PageTest
{
#if DEBUG
    private readonly int MaxAttempts = 1;
#else
    private int MaxAttempts = 10;
#endif

    [Test]
    public async Task SqlCeQueryAnalyzer_Download()
    {
        var random = new Random();
        var length = random.Next(1, MaxAttempts);
        for (int i = 0; i < length; i++)
        {
            await Page.GotoAsync("https://github.com/christianhelle");

            await Page.GetByRole(AriaRole.Link, new() { NameString = "sqlcequery" }).ClickAsync();
            await Page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery");

            await Page.GetByRole(AriaRole.Link, new() { NameString = "1.2.6626 Latest May 1, 2021on May 1, 2021" }).ClickAsync();
            await Page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.2.6626");

            await Page.RunAndWaitForDownloadAsync(async () =>
            {
                await Page.GetByRole(AriaRole.Link, new() { NameString = "SQL.Compact.Query.Analyzer.Setup.v1.2.6626.exe" }).ClickAsync();
            });
            await Page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.2.6626");

            await Page.RunAndWaitForDownloadAsync(async () =>
            {
                await Page.GetByRole(AriaRole.Link, new() { NameString = "SQL.Compact.Query.Analyzer.v1.2.6626.zip" }).ClickAsync();
            });
            await Page.WaitForURLAsync("https://github.com/christianhelle/sqlcequery/releases/tag/1.2.6626");
        }
    }
}