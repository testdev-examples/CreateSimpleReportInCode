using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSimpleReportInCode {
    class Program {
        static void Main(string[] args) {
            var report = DxReportHelper.GetMyReport();
        }
    }
    public class DxReportHelper {
        public static XtraReport GetMyReport() {
            // todo
            return null;
        }
    }
}
