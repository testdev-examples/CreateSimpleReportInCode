using System;
using DevExpress.XtraReports.UI;

namespace CreateSimpleReportInCode {
    class Program {
        [STAThread]
        static void Main(string[] args) {
            XtraReport report = ReportCreator.CreateReport();

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowRibbonPreviewDialog();
        }
    }
}
