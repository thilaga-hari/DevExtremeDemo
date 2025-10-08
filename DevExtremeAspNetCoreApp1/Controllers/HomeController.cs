using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.AspNetCore.Spreadsheet;
using DevExtremeAspNetCoreApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View();
        }

        public IActionResult DIT()
        {
            return View();
        }

        [HttpPost]
        public void SaveToFile(SpreadsheetClientState spreadsheetState)
        {
            var spreadsheet = SpreadsheetRequestProcessor.GetSpreadsheetFromState(spreadsheetState);
            spreadsheet.Save();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult DxDocumentRequest()
        {
            return SpreadsheetRequestProcessor.GetResponse(HttpContext);
        }
    }
}
