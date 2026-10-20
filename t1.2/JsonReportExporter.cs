using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t1._2
{
    public class JsonReportExporter : Reports
    {


       protected override string Format(List<string[]> rows)
        {
            var items = rows.Skip(1).Select(r => $"{{\"Id\":\"{r[0]}\",\"Name\":\"{r[1]}\"}}");
            return "[" + string.Join(",", items) + "]";
        }

    }
}
