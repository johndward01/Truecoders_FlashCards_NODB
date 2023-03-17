using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class CSSFlashCards : Controller
    {
        private readonly IC_FlashCardsrepo repo;

        public CSSFlashCards(IC_FlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetCSSFlashCards();

            return View(flashcards);
        }

    }
}
