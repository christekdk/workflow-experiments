using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class BlogArchiveTests : PageTest
{
    private readonly BrowserTypeLaunchOptions browserTypeLaunchOptions = new BrowserTypeLaunchOptions
    {
        ChromiumSandbox = true,
#if DEBUG
        Headless = false,
#endif
    };

    [Test]
    public async Task Crawl_Archive()
    {
        const string baseUrl = $"https://christianhelle.com";
        const string startUrl = $"{baseUrl}/archives";

        var browser = await Playwright.Chromium.LaunchAsync(browserTypeLaunchOptions);
        var context = await browser.NewContextAsync();
        var Page = await context.NewPageAsync();

        await Page.GotoAsync($"{startUrl}");

        await Page.GetByRole(AriaRole.Link, new() { NameString = "AutoFaker - A Python library to minimize unit testing ceremony" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2022/10/autofaker.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Orchestrated ETL Design Pattern for Apache Spark and Databricks" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2022/09/orchestrated-etl.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "AppCenter Extensions for ASP.NET Core and Application Insights" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2020/03/appcenter-extensions-for-aspnet-core.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "AppCenter Extensions for Xamarin.Forms" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2020/02/appcenter-extensions-for-xamarinforms.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generate Android Translations from Google Sheets" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2019/06/generate-android-translations-from.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generate iOS InfoPlist.strings Translations from Google Sheets" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2019/06/generate-ios-infopliststrings.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generate Resx Translations from Google Sheets" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2019/06/generate-resx-translations-using-google.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generate Resx Translations from Google Sheets" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2019/06/generate-resx-translations-using-google.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Scrollable UISegmentedControl for Xamarin.iOS" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2019/06/scrollable-uisegmentedcontrol-for.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generating a REST API Client from Visual Studio 2017 and 2019" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2019/05/generating-rest-api-client-from-visual.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "New Challenges in the Cloud" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2018/06/new-challenges-in-cloud.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Working with Native Bitmap pixel buffers in Xamarin.Forms" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2016/09/working-with-native-bitmap-pixel.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "AppCenter Extensions for Xamarin.Forms" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2020/02/appcenter-extensions-for-xamarinforms.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Over 2 years of Xamarin" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2016/08/over-2-years-of-xamarin.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Integrating with the Windows Phone 8 Lock Screen" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2013/05/integrating-with-windows-phone-8-lock.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Using the Windows Phone Custom Contact Store" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2013/04/using-windows-phone-custom-contact-store.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "The missing ResWFileCodeGenerator custom tool for Visual Studio 2012" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2013/01/the-missing-reswfilecodegenerator.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Parenthood" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2013/01/parenthood.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Windows Phone and HTML5 - Danish Developer Conference 2012 Session Recording" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2012/04/windows-phone-and-html5-danish.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Accessing the Accelerometer from HTML5 and Javascript with Windows Phone 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2012/03/accessing-accelerometer-from-html5-and.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Heading, new() { NameString = "2019" }).ClickAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Integrating HTML5 and Javascript with Windows Phone 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2012/03/integrating-html5-and-javascript-with.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "HTML5 and Windows Phone 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2012/03/html5-and-windows-phone-7.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Danish Developer Conference 2012" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2012/02/danish-developer-conference-2012.html");
        await Page.GoBackAsync();

        await Page.Locator("ul:has-text(\"Windows Phone and HTML5 - Danish Developer Conference 2012 Session Recording Acc\")").GetByRole(AriaRole.Link, new() { NameString = "A long break..." }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2012/02/long-break.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "SQL Compact Query Analyzer" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/06/sql-compact-query-analyzer.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "SQL Compact Code Generator" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/03/sql-ce-code-generator.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to display a Notification Bubble in Windows Mobile using .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/02/how-to-display-notification-bubble-in.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Working around Pivot SelectedIndex limitations in Windows Phone 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/02/working-around-pivot-selectedindex.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to Darken an Image in WPF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/02/how-to-darken-image-in-wpf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to Brighten an Image in WPF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/02/how-to-brighten-image-in-wpf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to Alpha Blend 2 Images in WPF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/02/how-to-alpha-blend-2-images-in-wpf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to convert an image to gray scale in WPF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/02/how-to-convert-image-to-gray-scale-in.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Multi-platform Mobile Development - Sending SMS" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/01/multi-platform-mobile-development-sending-sms.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Multi-platform Mobile Development - Creating a List Based UI" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/01/multi-platform-mobile-development-listviews.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Multi-platform Mobile Development" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2011/01/multi-platform-mobile-development.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to enable Internet Tethering on a Samsung Omnia 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/11/how-to-enable-internet-tethering-on.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Chris' Puzzle Game on the Windows Phone 7 Marketplace" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/11/chris-puzzle-game-on-windows-phone-7.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to launch the Marketplace in the Windows Phone 7 Emulator" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/11/how-to-launch-marketplace-in-windows.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to use the keyboard in the Windows Phone 7 Emulator" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/how-to-use-keyboard-in-windows-phone-7.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Windows Phone 7 Unlocked Emulator" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/windows-phone-7-unlocked-emulator.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Chris' Puzzle Game for Windows Phone 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/chris-puzzle-game-for-windows-phone-7.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Motorola Dual Bluetooth Stack Support" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/motorola-dual-bluetooth-stack-support.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Widcomm Bluetooth Pairing Prompt" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/widcomm-bluetooth-pairing-prompt.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Windows Phone 7 Game State Management using XNA" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/windows-phone-7-game-state-management.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Microsoft Advertising SDK for Windows Phone 7" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/microsoft-advertising-sdk-for-windows.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to retrieve a list of installed applications using .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/10/how-to-retrieve-list-of-installed.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Writing a Puzzle Game for Windows Phone 7 using XNA" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/09/writing-puzzle-game-for-windows-phone-7.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Copying files from the Desktop to the Device using .NET" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/08/copying-files-from-desktop-to-device.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Enumerating Bluetooth Devices from .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/07/enumerating-bluetooth-devices-from.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Cropping an Image in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/07/cropping-image-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = ".NET Compact Framework 3.5 Data Driven Applications" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/07/net-compact-framework-35-data-driven.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Themed Image Button in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/05/themed-image-button-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to enumerate files on a Windows CE based device from the Desktop" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/04/how-to-enumerate-files-on-windows-ce.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to draw a textured rounded rectangle in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/01/how-to-draw-textured-rounded-rectangle.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to draw a rounded rectangle in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/01/how-to-draw-rounded-rectangle-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Pocket News - Newsgroup reader for Windows Mobile" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/01/pocket-news-newsgroup-reader-for.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "SQLCE Code Generator" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/01/sqlce-code-generator.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to toggle the Wi-fi radio" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/01/how-to-toggle-wi-fi-radio.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Semi-Transparent Controls in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2010/01/semi-transparent-controls-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to get the IP Address of a device in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/12/how-to-get-ip-address-of-device-in.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to Vibrate a Smartphone / Windows Mobile Standard device in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/12/how-to-vibrate-smartphone-windows.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to switch on/off the speaker phone in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/12/how-to-switch-onoff-speaker-phone-in.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to enumerate storage cards in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/12/how-to-enumerate-storage-cards-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to send keyboard events in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/12/how-to-send-keyboard-events-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generic Bordered Control Base for .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/generic-bordered-control-base-for-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Extending the TextBox Control in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/extending-textbox-control-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to hide the TextBox caret in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/how-to-hide-textbox-caret-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Resizing an Image in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/resizing-image-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Improve .NETCF Build Performance in Visual Studio" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/improve-netcf-build-performance-in.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generic Singleton Implementation" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/generic-singleton-implementation.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "ListView Background Image in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/listview-background-image.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "ListView Custom Drawing in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/10/listview-custom-drawing-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "How to enumerate running programs in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/09/how-to-enumerate-running-programs-in.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "A long break..." }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2009/09/long-break.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Source Code Download" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/10/source-code-download.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "ListView Extended Styles in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/10/listview-extended-styles-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Chris' Puzzle Game for Windows Mobile" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/04/chris-puzzle-game.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Unit Testing for Smart Devices Webcast" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/02/unit-testing-for-smart-devices-webcast.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Integrating with Garmin Mobile XT" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/02/integrating-with-garmin-mobile-xt.html");

        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Transparent Controls in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/01/transparent-controls-in-netcf.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Cepa Mobility - Enabling the Disabled" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2008/01/cepa-mobility-enabling-disabled.html");
        await Page.GoBackAsync();

        await Page.Locator("li:has-text(\"SqlCeEngineEx - Extending the SqlCeEngine class\")").ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { NameString = "SqlCeEngineEx - Extending the SqlCeEngine class" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/12/sqlceengineex-extending-sqlceengine.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Microsoft Development Center Copenhagen - TechFest 2007" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/11/microsoft-development-center-copenhagen.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Visual Studio 2008 Released!" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/11/visual-studio-2008-released.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Microsoft Dynamics Convergence 2007 - Copenhagen" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/10/microsoft-dynamics-convergence-2007.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Official Windows Mobile 6.0 Upgrade for HTC P3300" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/10/official-windows-mobile-60-upgrade-for.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "ButtonEx - Owner Drawn Button Control" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/09/buttonex-owner-drawn-button-control.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Attaching Photos to a .NETCF Application" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/09/attaching-photos-to-netcf-application.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Displaying the Calendar view on a DateTimePicker Control in .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/07/displaying-calendar-view-on.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Generic Multiple CAB File Installer for the Desktop" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/07/generic-multiple-cab-file-installer-for.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Accessing Windows Mobile 6.0 Sound API's through .NETCF" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/07/accessing-windows-mobile-60-sound-apis.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "WISP Lite in Managed Code" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/wisp-lite-in-managed-code.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Copying Files from the Device to the Desktop using .NET" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/copying-files-from-device-to-desktop.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Retrieving the Icon Image within the System Image List in .NETCF 2.0" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/retrieving-icon-image-within-system_295.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Logging Unhandled Exceptions" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/logging-unhandled-exceptions.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Integrating with TomTom Navigator" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/integrating-with-tomtom-navigator.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Programmatically Minimize an Application in .NET CF 2.0" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/programmatically-minimize-application.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Programmatically Refreshing the Today Screen" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/programmatically-refreshing-today.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Querying Overridden Check-in Policies" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/querying-overridden-check-in-policies.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "My first ever blog post" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/2007/06/my-first-ever-blog-post.html");
        await Page.GoBackAsync();

        await Page.GetByRole(AriaRole.Link, new() { NameString = "About" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/about/");

        await Page.GetByRole(AriaRole.Link, new() { NameString = "Tags" }).ClickAsync();
        await Page.WaitForURLAsync($"{baseUrl}/tags/");
    }
}
