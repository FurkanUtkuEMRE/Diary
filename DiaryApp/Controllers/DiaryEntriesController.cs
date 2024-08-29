using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntryModel> diaryEntries = _db.DiaryEntries.ToList();

            return View(diaryEntries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntryModel diaryEntry)
        {
            ValidateInput(diaryEntry);

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(diaryEntry);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diaryEntry);
        }

        public IActionResult Edit(int? id)
        {
            DiaryEntryModel? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntryModel diaryEntry)
        {
            ValidateInput(diaryEntry);

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(diaryEntry);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diaryEntry);
        }

        public IActionResult Delete(int id)
        {
            DiaryEntryModel? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            _db.DiaryEntries.Remove(diaryEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public void ValidateInput(DiaryEntryModel diaryEntry)
        {
            if (diaryEntry.Title == null || diaryEntry.Content == null || diaryEntry.Date == DateTime.MinValue)
            {
                ModelState.AddModelError("Title", "You need to give the entry a title.");
                ModelState.AddModelError("Content", "You need to write some content for the entry.");
                ModelState.AddModelError("Date", "You need to pick a date for your entry.");
            }
            else if (diaryEntry.Title.Length < 3 && diaryEntry.Content.Length < 5)
            {
                ModelState.AddModelError("Title", "Your title must be between 3 and 50 characters!");
                ModelState.AddModelError("Content", "Your content must be between 5 and 50 characters!");
            }
        }
    }
}
