using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3._t1._3
{
    public class Enrollment
    {
        private readonly PaymentGateway _paymentGateway;
        private readonly SeatInventory _seatInventory;
        private readonly InvoiceGenerator _invoiceGenerator;
        private readonly EmailService _emailService;
        public Enrollment(PaymentGateway paymentGateway, SeatInventory seatInventory, InvoiceGenerator invoiceGenerator, EmailService emailService)
        {
            _paymentGateway = paymentGateway;
            _seatInventory = seatInventory;
            _invoiceGenerator = invoiceGenerator;
            _emailService = emailService;
        }
        public void Enroll(string studentId, string courseId, decimal amount)
        {
            _paymentGateway.Charge(studentId, amount);
            _seatInventory.Reserve(courseId, studentId);
            string invoiceId=   _invoiceGenerator.Create(studentId, amount);
            _emailService.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");

    } 
}
}
