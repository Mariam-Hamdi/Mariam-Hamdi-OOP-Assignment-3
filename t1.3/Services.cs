using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3._t1._3
{
    public class PaymentGateway
    {
        public void Charge(string studentId, decimal amount) =>
            Console.WriteLine($"charge {studentId}: {amount}");
    }

    public class SeatInventory
    {
        public void Reserve(string courseId, string studentId) =>
            Console.WriteLine($"reserve seat {courseId} for {studentId}");
    }

    public class InvoiceGenerator
    {
        public string Create(string studentId, decimal amount)
        {
            var invoiceId = $"INV-{studentId}-{amount}";
            Console.WriteLine($"invoice {invoiceId}");
            return invoiceId;
        }
    }

    public class EmailService
    {
        public void Send(string studentId, string subject, string body) =>
            Console.WriteLine($"email {studentId}: {subject} / {body}");
    }
}
