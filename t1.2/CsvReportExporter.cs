using System.Text;
using System.Threading.Tasks;
using Task1_ass_oop3.t1._2;

namespace Task1_ass_oop3.t1._2
{

    public class CsvReportExporter : Reports
    {
        protected override string Format(List<string[]> rows) =>
            string.Join(Environment.NewLine, rows.Select(r => string.Join(",", r)));

    }
}