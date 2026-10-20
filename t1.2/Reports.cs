using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t1._2
{
    public abstract class Reports
    {
        public void Export(string path)
        {
            var rows = Load();
            if (!Validate(rows))
                throw new InvalidOperationException("Invalid data");
            var content = Format(rows);
            Save(path, content);
        }

       protected List<string[]> Load() =>
        [
            ["Id", "Name"],
        ["1", "Keyboard"],
        ["2", "Mouse"]
        ];

        protected virtual bool Validate(List<string[]> rows) =>
                rows.Count > 1 && rows[0].Length > 0;

        protected abstract string Format(List<string[]> rows);
        protected void Save(string path, string content) =>
                File.WriteAllText(path, content);
    }
}
