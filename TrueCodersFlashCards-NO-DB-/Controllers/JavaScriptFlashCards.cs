using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class JavaScriptFlashCards : Controller
    {
        private readonly IC_FlashCardsrepo repo;

        public JavaScriptFlashCards(IC_FlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetJavaScriptFlashCards();

            return View(flashcards);
        }

    }
}
