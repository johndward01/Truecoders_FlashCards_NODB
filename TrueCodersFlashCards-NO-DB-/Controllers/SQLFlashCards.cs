using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards_NO_DB_.Controllers
{
    public class SQLFlashCards : Controller
    {
        private readonly IC_FlashCardsrepo repo;

        public SQLFlashCards(IC_FlashCardsrepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var flashcards = repo.GetSQLFlashCards();

            return View(flashcards);
        }

    }
}
