using Microsoft.AspNetCore.Mvc;
using AudioProject.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace AudioProject.Controllers
{
  public class MichaelController : Controller
  {
    private readonly AudioProjectContext _db;

    public MichaelController(AudioProjectContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Upload()
    {
      return View();
    }
    public ActionResult Spector()
    {
      return View();
    }
  }
}