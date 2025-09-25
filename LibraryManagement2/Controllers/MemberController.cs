using LibraryManagement2;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class MemberController : Controller
{
    public IActionResult Index() => View(DataStore.Members);

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Member mem)
    {
        mem.Id = DataStore.Members.Count == 0 ? 1 : DataStore.Members.Max(m => m.Id) + 1;
        DataStore.Members.Add(mem);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var mem = DataStore.Members.FirstOrDefault(m => m.Id == id);
        if (mem == null) return NotFound();
        return View(mem);
    }

    [HttpPost]
    public IActionResult Edit(Member mem)
    {
        var ex = DataStore.Members.FirstOrDefault(m => m.Id == mem.Id);
        if (ex == null) return NotFound();

        ex.Name = mem.Name;
        ex.Email = mem.Email;
        ex.MemberId = mem.MemberId;
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var mem = DataStore.Members.FirstOrDefault(m => m.Id == id);
        if (mem != null)
            DataStore.Members.Remove(mem);
        return RedirectToAction("Index");
    }
}
