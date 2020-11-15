using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.IO;
using Comment.BLL.Models;
using Comment.BLL.Interfaces.ChildServices;
using SelfWork_1.Filters;

namespace SelfWork_1.Controllers
{
    [Culture]
    public class HomeController : Controller
    {
        ICommentService commentService;
        IPlayerService playerService;
        public HomeController(ICommentService commentService,IPlayerService playerService)
        {
            this.commentService = commentService;
            this.playerService = playerService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangeCulture(string lang)
        {
            List<string> cultures = new List<string> { "ru", "en" };
            if (!cultures.Contains(lang))
                lang = "ru";
            HttpCookie cookie = Request.Cookies["lang"];
            if (cookie != null)
                cookie.Value = lang;
            else
            {
                cookie = new HttpCookie("lang");
                cookie.HttpOnly = false;
                cookie.Value = lang;
                cookie.Expires = DateTime.Now.AddYears(1);
            }
            Response.Cookies.Add(cookie);
            return Redirect(Request.UrlReferrer.AbsolutePath);
        }
        [HttpGet]
        public ActionResult Comment()
        {
            return View(commentService.ReadAll());
        }
        [HttpPost]
        public ActionResult Comment(CommentDTO comment)
        {
            try
            {
                //ViewBag.Error = "";
                comment.Date = DateTime.Now;
                commentService.Create(comment);
                return RedirectToAction("Comment");
            }
            catch(ArgumentException ex)
            {
                //ViewBag.Error = ex.Message;
                return RedirectToAction("Comment");
            }
        }
        public ActionResult AboutTeam()
        {
            return View(playerService.ReadAll());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}