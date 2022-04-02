using ExamPIIT.Data;
using ExamPIIT.Models;
using ExamPIIT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamPIIT.Controllers
{
    public class CoinController : Controller
    {
        MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View(db.Coins.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CoinViewModel coinViewModel)
        {
            if (ModelState.IsValid)
            {
                var coin = new Coin()
                {
                    Name = coinViewModel.Name,
                    BaseAsset = coinViewModel.BaseAsset,
                    QuoteAsset = coinViewModel.QuoteAsset,
                    LastPrice = coinViewModel.LastPrice,
                    Volumn24h = coinViewModel.Volumn24h,
                    MarketId = coinViewModel.MarketId,
                    Status = (Models.Status)coinViewModel.Status
                };
                db.Coins.Add(coin);
                db.SaveChanges();
                return View(coin);
            }
            return View("Index");
        }
        public ActionResult Search(string keyword)
        {
            var result = from coin in db.Coins.Where(c => c.Name.Contains(keyword) & c.MarketId.Equals(keyword)) select coin;
            return RedirectToAction("Index");
        }
    }
}