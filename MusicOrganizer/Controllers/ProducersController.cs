using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordsController : Controller
  {
    [HttpGet("/formats/{formatId}/records/new")]
    public ActionResult New(int formatId)
    {
      Format format = Format.Find(formatId);
      return View(format);
    }

    [HttpGet("/formats/{formatId}/records/{recordId}")]
    public ActionResult Show(int formatId, int recordId)
    {
      Record record = Record.Find(recordId);
      Format format = Format.Find(formatId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("record", record);
      model.Add("format", format);
      return View(model);
    }

    [HttpPost("/records/delete")]
    public ActionResult DeleteAll()
    {
      Record.ClearAll();
      return View();
    }
  }
}