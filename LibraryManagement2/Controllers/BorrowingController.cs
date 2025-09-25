using LibraryManagement2;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

public class BorrowingController : Controller
{
    public IActionResult Index() => View(DataStore.Borrowings);

    public IActionResult Borrow()
    {
        ViewBag.Books = DataStore.Books.Where(b => b.AvailableCopies > 0).ToList();
        ViewBag.Members = DataStore.Members;
        return View();
    }

    [HttpPost]
    public IActionResult Borrow(int bookId, int memberId)
    {
        var book = DataStore.Books.FirstOrDefault(b => b.Id == bookId);
        var member = DataStore.Members.FirstOrDefault(m => m.Id == memberId);

        if (book == null || member == null || book.AvailableCopies <= 0)
        {
            ViewBag.Books = DataStore.Books.Where(b => b.AvailableCopies > 0).ToList();
            ViewBag.Members = DataStore.Members;
            ViewBag.Error = "Invalid operation";
            return View();
        }

        book.AvailableCopies--;
        DataStore.Borrowings.Add(new Borrowing
        {
            Id = DataStore.Borrowings.Count == 0 ? 1 : DataStore.Borrowings.Max(b => b.Id) + 1,
            BookId = bookId,
            MemberId = memberId,
            BorrowDate = DateTime.Now
        });

        return RedirectToAction("Index");
    }

    public IActionResult Return(int id)
    {
        var bo = DataStore.Borrowings.FirstOrDefault(b => b.Id == id);
        if (bo != null && bo.ReturnDate == null)
        {
            bo.ReturnDate = DateTime.Now;
            var book = DataStore.Books.FirstOrDefault(b => b.Id == bo.BookId);
            if (book != null) book.AvailableCopies++;
        }
        return RedirectToAction("Index");
    }
}
