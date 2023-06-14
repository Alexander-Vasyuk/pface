using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pokerface.Controllers;
public class NewGameController : Controller
{
	// GET: NewGameController
	public ActionResult Index()
	{
		return View();
	}

	// GET: NewGameController/Details/5
	public ActionResult Details(int id)
	{
		return View();
	}

	// GET: NewGameController/Create
	public ActionResult Create()
	{
		return View();
	}

	// POST: NewGameController/Create
	[HttpPost]
	[ValidateAntiForgeryToken]
	public ActionResult Create(IFormCollection collection)
	{
		try
		{
			return RedirectToAction(nameof(Index));
		}
		catch
		{
			return View();
		}
	}

	// GET: NewGameController/Edit/5
	public ActionResult Edit(int id)
	{
		return View();
	}

	// POST: NewGameController/Edit/5
	[HttpPost]
	[ValidateAntiForgeryToken]
	public ActionResult Edit(int id, IFormCollection collection)
	{
		try
		{
			return RedirectToAction(nameof(Index));
		}
		catch
		{
			return View();
		}
	}

	// GET: NewGameController/Delete/5
	public ActionResult Delete(int id)
	{
		return View();
	}

	// POST: NewGameController/Delete/5
	[HttpPost]
	[ValidateAntiForgeryToken]
	public ActionResult Delete(int id, IFormCollection collection)
	{
		try
		{
			return RedirectToAction(nameof(Index));
		}
		catch
		{
			return View();
		}
	}
}
