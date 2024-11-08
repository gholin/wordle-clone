using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class WordleTest : PageTest
{
    [Test]
    public async Task UserLosesAfterSixIncorrectGuesses() 
    {
        var correctGuess = "ninja";
        await Page.GotoAsync($"http://localhost:3000/?test={correctGuess}");
        await Expect(Page.GetByText("Wordle")).ToBeVisibleAsync();
        
        string[] guesses = ["lbcde", "zxuwb", "cccyd", "hkcpb", "ccccc", "bbbbb"];
        
        var index = 0;
        foreach (var guess in guesses) {
            // Type in guess
            await Page.Keyboard.TypeAsync(guess, new() { Delay = 100 });
            
            // Complete the guess, and check that the last row was incorrect by checking tile color
            await Page.Keyboard.PressAsync("Enter");
            var rowPastLocator = Page.Locator($".row.past:nth-of-type({index + 1})");
            await rowPastLocator.WaitForAsync();
            await Expect(rowPastLocator.Locator(".grey")).ToHaveCountAsync(5);
            
            index++;
        }

        var loseModal = Page.Locator(".modal");
        // I split these because the modal test doesn't have good spacing and reads:
        //  "Sorry, you loose!The word was: ninjaBetter luck next time :)"
        await Expect(loseModal.Locator("h1")).ToContainTextAsync("Sorry, you loose!"); // Totally a typo here, so this line fails currently.
        await Expect(loseModal.GetByText($"The word was: {correctGuess}")).ToBeVisibleAsync();
        await Expect(loseModal.GetByText("Better luck next time :)")).ToBeVisibleAsync();
    }

    [Test]
    public async Task UserWinsWithCorrectGuess() 
    {
        var correctGuess = "ninja";
        await Page.GotoAsync($"http://localhost:3000/?test={correctGuess}");

        // Enter in correct guess and verify the tiles fill correctly
        await Page.Keyboard.TypeAsync(correctGuess, new() { Delay = 100 });
        // I could have chosen to chain the css in one locator (".row.current .filled"), but it seems more readable this way
        await Expect(Page.Locator(".row.current").Locator(".filled")).ToHaveCountAsync(5);
        
        // Hit enter and check that the rows inside
        await Page.Keyboard.PressAsync("Enter");
        await Expect(Page.Locator(".row.past").Locator(".green")).ToHaveCountAsync(5);
        
        var winModal = Page.Locator(".modal");
        await Expect(winModal.Locator("h1")).ToContainTextAsync("You Win!");
        await Expect(winModal.GetByText($"The word was: {correctGuess}")).ToBeVisibleAsync();
        await Expect(winModal.GetByText($"You found the solution in 1 guesses :)")).ToBeVisibleAsync();
    }
}

