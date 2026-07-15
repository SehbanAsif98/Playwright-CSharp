using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();

await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
{
    Headless = true
});

var page = await browser.NewPageAsync();

await page.GotoAsync("https://playwright.dev");

Console.WriteLine(await page.TitleAsync());

await browser.CloseAsync();