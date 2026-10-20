using Task1_ass_oop3.t2;
using Task1_ass_oop3.t1._2;
using Task1_ass_oop3.t1._4;
using Task1_ass_oop3._t1._3;
namespace Task1_ass_oop3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("=== Reports ===");
            var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
            Directory.CreateDirectory(outDir);

            new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
            new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
            new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
            Console.WriteLine($"Wrote reports to {outDir}");
            Console.WriteLine();

            Console.WriteLine("=== Enrollment ===");
            var studentId = "S100";
            var courseId = "CS201";
            var amount = 1500m;

            var payment = new PaymentGateway();
            var seats = new SeatInventory();
            var invoices = new InvoiceGenerator();
            var email = new EmailService();

            var enrollmentFacade = new Enrollment(payment, seats, invoices, email);

            enrollmentFacade.Enroll(studentId, courseId, amount);

            Console.WriteLine( "\n RefactoringLab.Part03.Blocked");

            Console.WriteLine("=== Blocked users ===");
            const int blockedCount = 50_000;
            const int requestCount = 5_000;
            var blockedIds = BlockedUserChecker.BuildBlockedIds(blockedCount);
            var requestIds = BlockedUserChecker.BuildRequestIds(requestCount, blockedCount);
            var ms = BlockedUserChecker.MeasureMs(blockedIds, requestIds, out var found);
            Console.WriteLine($"blockedIds={blockedCount}, requests={requestCount}, found={found}, time={ms} ms");
            Console.WriteLine();
            Console.WriteLine("\n RefactoringLab.Part03.Student");

            Console.WriteLine("=== Students (1_000_000) ===");
            var printed = 0;
            foreach (var student in StudentCatalog.GetAllStudents())
            {
                Console.WriteLine($"{student.Id}: {student.Name}");
                printed++;
                if (printed == 3)
                    break;
            }
            Console.WriteLine($"printed={printed}");


            Console.WriteLine("=== Collections ===");

            Console.WriteLine("=== Testing Egyptian Phone Numbers ===");
            TestPhone("01012345678", true);
            TestPhone("+201512345678", true);
            TestPhone("01312345678", false); 
            TestPhone("0101234567", false);  
            TestPhone("0101234567a", false); 

            Console.WriteLine("\n=== Testing Egyptian National IDs ===");
            TestNationalId("29901011234567", true);
            TestNationalId("19901011234567", false); 
            TestNationalId("2990101123456", false); 
        }

        static void TestPhone(string input, bool expected)
        {
            bool result = input.IsValidEgyptianPhone();
            Console.WriteLine($"Input: \"{input,-15}\" | Expected: {expected,-5} | Result: {result}");
        }

        static void TestNationalId(string input, bool expected)
        {
            bool result = input.IsValidEgyptianNationalId();
            Console.WriteLine($"Input: \"{input,-15}\" | Expected: {expected,-5} | Result: {result}");
        }
    }
}
    

