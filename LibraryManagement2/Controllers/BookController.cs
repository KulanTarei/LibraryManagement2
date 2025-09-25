using LibraryManagement2;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class BookController : Controller
{
    public IActionResult Index() => View(DataStore.Books);

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Book book)
    {
        book.Id = DataStore.Books.Count == 0 ? 1 : DataStore.Books.Max(b => b.Id) + 1;
        DataStore.Books.Add(book);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var book = DataStore.Books.FirstOrDefault(b => b.Id == id);
        if (book == null) return NotFound();
        return View(book);
    }

    [HttpPost]
    public IActionResult Edit(Book book)
    {
        var exist = DataStore.Books.FirstOrDefault(b => b.Id == book.Id);
        if (exist == null) return NotFound();

        exist.Title = book.Title;
        exist.Author = book.Author;
        exist.ISBN = book.ISBN;
        exist.PublishedYear = book.PublishedYear;
        exist.AvailableCopies = book.AvailableCopies;
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var book = DataStore.Books.FirstOrDefault(b => b.Id == id);
        if (book != null)
            DataStore.Books.Remove(book);
        return RedirectToAction("Index");
    }
}
