using Task1_ass_oop3.t2;
using Task1_ass_oop3.t1._2;
using Task1_ass_oop3.t1._4;
using Task1_ass_oop3._t1._3;
using Task1_ass_oop3.t3;
using Task1_ass_oop3.t1._1;
namespace Task1_ass_oop3
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Shipping Carriers ===");
            IShippingCarrier aramex = new Aramex();
            IShippingCarrier dhl = new DHL();
            IShippingCarrier newCarrier = new NewCarrier();

            decimal weight = 5.5m;
            Console.WriteLine($"Aramex cost for {weight}kg: {aramex.Calculate(weight)}");
            Console.WriteLine($"DHL cost for {weight}kg: {dhl.Calculate(weight)}");
            Console.WriteLine($"NewCarrier cost for {weight}kg: {newCarrier.Calculate(weight)}");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("=== Testing Notifications ===");
            INotification emailChannel = new EmailNotification();
            NotificationSender notificationSender = new NotificationSender(emailChannel);

            notificationSender.Send("test@example.com", "Hello via Email");
            notificationSender.SendUrgent("test@example.com", "This is urgent!");
            notificationSender.SendScheduled("test@example.com", "Scheduled message", DateTime.Now.AddHours(2));

            INotification messengerChannel = new MassengerNotification();
            NotificationSender messengerSender = new NotificationSender(messengerChannel);
            messengerSender.Send("user123", "Hello via Messenger");
            Console.WriteLine("--------------------------------------------------");

          
            Console.WriteLine("=== Testing Order Processor ===");
            IOrderRepository sqlRepo = new SqlOrderRepository();
            IEmailSender smtpSender = new SmtpEmailSender();

            OrderProcessor orderProcessor = new OrderProcessor(sqlRepo, smtpSender);
            orderProcessor.Process(501, "customer@domain.com");
            Console.WriteLine("--------------------------------------------------");
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

            Console.WriteLine("\n RefactoringLab.Part03.Blocked");

            Console.WriteLine("=== Blocked users ===");
            const int blockedCount = 50_000;
            const int requestCount = 5_000;
            var blockedIds = BlockedUserChecker.BuildBlockedIds(blockedCount);
            var requestIds = BlockedUserChecker.BuildRequestIds(requestCount, blockedCount);
            var ms = BlockedUserChecker.MeasureMs(blockedIds, requestIds, out var found);
            Console.WriteLine($"blockedIds={blockedCount}, requests={requestCount}, found={found}, time={ms} ms");
            Console.WriteLine();
            Console.WriteLine("\n RefactoringLab.Part03.Studenttt");

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



            // t3
            Store<Studenttt> studentStore = new Store<Studenttt>();
            studentStore.Add(new Studenttt { Id = 1, Name = "Mariam" });
            studentStore.Add(new Studenttt { Id = 2, Name = "Ahmed" });
            studentStore.Add(new Studenttt { Id = 3, Name = "Mohamed" });
            studentStore.Add(new Studenttt { Id = 4, Name = "Ali" });
            studentStore.Add(new Studenttt { Id = 5, Name = "Fatma" });

            Store<Course> courseStore = new Store<Course>();
            courseStore.Add(new Course { Id = 101, Title = "C# Basics", Price = 100m });
            courseStore.Add(new Course { Id = 102, Title = "Advanced .NET", Price = 250m });
            courseStore.Add(new Course { Id = 103, Title = "Data Structures", Price = 150m });

            var fetchedStudent = studentStore.GetById(3);
            var fetchedCourse = courseStore.GetById(102);

            Console.WriteLine($"Fetched Studenttt: {fetchedStudent?.Name}");
            Console.WriteLine($"Fetched Course: {fetchedCourse?.Title}");
            Console.WriteLine("--------------------------------------------------");

            try
            {
                studentStore.Add(new Studenttt { Id = 55, Name = "Duplicate Studenttt" });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught Expected Exception: {ex.Message}");
            }
            Console.WriteLine("--------------------------------------------------");

            var allStudents = studentStore.GetAll();
            Console.WriteLine("-- Page 2 (Page Size: 2) of Students --");
            var page2Students = allStudents.Page(2, 2);
            foreach (var s in page2Students)
            {
                Console.WriteLine($"Studenttt ID: {s.Id}, Name: {s.Name}");
            }

            List<Studenttt> plainList = new List<Studenttt>
        {
            new Studenttt { Id = 10, Name = "Hassan" },
            new Studenttt { Id = 20, Name = "Salma" }
        };
            var foundFromList = plainList.FindById(20);
            Console.WriteLine($"Found from plain List: {foundFromList?.Name ?? "Not Found"}");
            Console.WriteLine("--------------------------------------------------");

            // new Store<int>();

        }


    }
        }