using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Properties;

namespace TimeTracker.backend
{
    /// <summary>
    /// Class responsible for generating a PDF timesheet.
    /// </summary>
    public class GenerateTimesheet
    {
        private static string filename = "";
        private static XGraphics gfx;
        private static XFont pageHeaderFont;
        private static XFont headerFont;
        private static XFont textFont;
        
        private static PdfDocument document;
        private static PdfPage page;

        private static Employee e;

        /// <summary>
        /// Generates a timesheet based on the current week with the current employee.
        /// <para>The timesheet is saved in the path specified by the value in <see cref="Settings.Default"/> in the <c>Timesheets</c> folder.</para>
        /// <para>If the <c>Timesheets</c> folder does not exist, it is created.</para>
        /// </summary>
        public static void Generate()
        {
            e = EmployeeInformation.Instance.GetEmployee(Settings.Default.LastGUID);
            if (e == null)
            {
                return;
            }
            SetupDocumentInfo(TimeSheet.Instance);
            SetupPage();

            AddTimeToPage(TimeSheet.Instance);

            filename = Path.Combine(Settings.Default.SavePath, "Timesheets");
            Directory.CreateDirectory(filename);
            filename = Path.Combine(filename, $"{document.Info.Title}.pdf");

            document.Save(filename);
            Process.Start(filename);
        }

        /// <summary>
        /// Generates a timesheet based on the supplied sheet.
        /// <para>The timesheet is saved in the path specified by the value in <see cref="Settings.Default"/> in the <c>Timesheets</c> folder.</para>
        /// <para>If the <c>Timesheets</c> folder does not exist, it is created.</para>
        /// </summary>
        /// <param name="sheet">The <see cref="TimeSheet"/> to use for the generation.</param>
        public static void Generate(TimeSheet sheet)
        {
            if (sheet.Employee == null)
            {
                return;
            }
            else
            {
                e = sheet.Employee;
            }


            SetupDocumentInfo(sheet);
            SetupPage();

            AddTimeToPage(sheet);

            filename = Path.Combine(Settings.Default.SavePath, "Timesheets");
            Directory.CreateDirectory(filename);
            filename = Path.Combine(filename, $"{document.Info.Title}.pdf");

            document.Save(filename);
            Process.Start(filename);
        }

        /// <summary>
        /// Setup the document Metadata.
        /// </summary>
        private static void SetupDocumentInfo(TimeSheet sheet)
        {
            document = new PdfDocument();
            document.Info.Title = $"{e.Name}-{sheet.Days.ElementAt(0).Value.Date:MM-dd-yyyy}-{sheet.Days.ElementAt(sheet.Days.Count - 1).Value.Date:MM-dd-yyyy}";
            document.Info.Author = e.Name;
            document.Info.CreationDate = DateTime.Now;
            document.Info.Creator = System.Reflection.Assembly.GetExecutingAssembly().FullName;
            document.Info.Subject = "Timesheet";
        }

        /// <summary>
        /// Setup page components needed for drawing.
        /// </summary>
        private static void SetupPage()
        {
            page = new PdfPage();
            document.AddPage(page);
            gfx = XGraphics.FromPdfPage(page);
            pageHeaderFont = new XFont("SegoueUI", 14, XFontStyle.Bold);
            headerFont = new XFont("SegoueUI", 12, XFontStyle.Regular);
            textFont = new XFont("SegoueUI", 10, XFontStyle.Regular);
        }

        /// <summary>
        /// Populates the page with all necessary information.
        /// </summary>
        private static void AddTimeToPage(TimeSheet sheet)
        {
            int textStartX = 10;
            int textStartY = 10;

            gfx.DrawString($"Timesheet for {e.Name}", pageHeaderFont, XBrushes.Black, new XRect(textStartX, textStartY, page.Width, page.Height), XStringFormats.TopLeft);
            textStartY += 30;
            gfx.DrawString($"Address: {e.EmpAddress}", headerFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 20;
            gfx.DrawString($"Phone Number: {e.PhoneNumber}", headerFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 20;
            gfx.DrawString($"Email: {e.Email}", headerFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 30;

            foreach (DayTime day in sheet.Days.Values)
            {
                string header = $"{day.Date.DayOfWeek}: {day.Date.Date:MM-dd-yyyy}";
                gfx.DrawString(header, headerFont, XBrushes.Black, new XRect(textStartX, textStartY, page.Width, page.Height), XStringFormats.TopLeft);
                
                textStartX += 30;
                textStartY += 30;

                string normalTime = $"Regular Hours: {day.NormalTime.TotalHours:F2}";
                string overTime = $"Overtime Hours: {day.Overtime.TotalHours:F2}";
                string billableTime = $"Billable Hours: {day.BillableTime.TotalHours:F2}";
                gfx.DrawString(normalTime, textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
                textStartY += 15;

                gfx.DrawString(overTime, textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
                textStartY += 15;

                gfx.DrawString(billableTime, textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
                textStartX += 20;
                textStartY += 20;

                gfx.DrawString($"Notes: {day.Notes}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
                textStartX = 10;
                textStartY += 30;
            }

            gfx.DrawLine(XPens.Black, 10, textStartY, page.Width - 10, textStartY);
            textStartY += 20;
            textStartX = 10;

            gfx.DrawString($"Hourly Rate: {string.Format("{0:C}", Convert.ToDecimal(e.HourlyRate))}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 20;
            gfx.DrawString($"Hourly Pay: {string.Format("{0:C}", sheet.GetNormalPay())}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 30;

            gfx.DrawString($"Billable Rate: {string.Format("{0:C}", Convert.ToDecimal(e.BillableRate))}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 20;
            gfx.DrawString($"Hourly Pay: {string.Format("{0:C}", sheet.GetBillablePay())}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 30;

            gfx.DrawString($"Overtime Rate: {string.Format("{0:C}", Convert.ToDecimal(e.OvertimeRate))}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 20;
            gfx.DrawString($"Overtime Pay: {string.Format("{0:C}", sheet.GetOvertimePay())}", textFont, XBrushes.Black, new XRect(textStartX, textStartY, 0, 0));
            textStartY += 30;

            gfx.DrawString($"Total Pay: {string.Format("{0:C}", sheet.GetTotalPay())}", headerFont, XBrushes.Black, new XRect(textStartX, textStartY, page.Width, 40), XStringFormats.Center);
        }
    }
}
