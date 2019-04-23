using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace CreateSimpleReportInCode {
    public class ReportCreator {
        class Employee {
            public string Name { get; set; }
        }
        public static XtraReport CreateReport() {
            XtraReport report = new XtraReport() {
                DataSource = CreateDataSource(),
                StyleSheet = {
                    new XRControlStyle() { Name = "Title", Font = new Font("Tahoma", 20f, FontStyle.Bold) },
                    new XRControlStyle() { Name = "Normal", Font = new Font("Tahoma", 10f), Padding = new PaddingInfo(2, 2, 0, 0) },
                }
            };
            var reportHeaderBand = CreateReportHeader("List of employees");
            var detailBand = CreateDetail("[Name]");
            report.Bands.AddRange(new Band[] { reportHeaderBand, detailBand });
            return report;
        }
        static List<Employee> CreateDataSource() {
            return new List<Employee>() {
                new Employee() { Name = "Nancy Davolio" },
                new Employee() { Name = "Andrew Fuller" },
                new Employee() { Name = "Janet Leverling" },
                new Employee() { Name = "Margaret Peacock" },
                new Employee() { Name = "Steven Buchanan" },
                new Employee() { Name = "Michael Suyama" },
                new Employee() { Name = "Robert King" },
                new Employee() { Name = "Laura Callahan" },
                new Employee() { Name = "Anne Dodsworth" }
            };
        }
        static ReportHeaderBand CreateReportHeader(string title) {
            ReportHeaderBand reportHeaderBand = new ReportHeaderBand() {
                HeightF = 50
            };
            XRLabel titleLabel = new XRLabel() {
                Text = title,
                BoundsF = new RectangleF(0, 0, 300, 30),
                StyleName = "Title"
            };
            reportHeaderBand.Controls.Add(titleLabel);
            return reportHeaderBand;
        }
        static DetailBand CreateDetail(string expression) {
            DetailBand detailBand = new DetailBand() {
                HeightF = 25
            };
            XRLabel detailLabel = new XRLabel() {
                ExpressionBindings = { new ExpressionBinding("Text", expression) },
                BoundsF = new RectangleF(0, 0, 300, 20),
                StyleName = "Normal"
            };
            detailBand.Controls.Add(detailLabel);
            return detailBand;
        }
    }
}
