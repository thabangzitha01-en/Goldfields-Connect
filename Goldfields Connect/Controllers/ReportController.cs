using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoldfieldsConnect.Controllers
{
    [Authorize(Roles = "SystemAdmin,AcademicAdmin,HOD")]
    public class ReportController : Controller
    {
        public IActionResult Index() => View(); // Page with buttons to generate reports

        [HttpPost]
        public IActionResult ExportToExcel()
        {
            // TODO: Use IronXL to generate Excel
            return File(new byte[0], "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Report.xlsx");
        }

        [HttpPost]
        public IActionResult ExportToPdf()
        {
            // TODO: Use IronPDF to generate PDF
            return File(new byte[0], "application/pdf", "Report.pdf");
        }
    }
}