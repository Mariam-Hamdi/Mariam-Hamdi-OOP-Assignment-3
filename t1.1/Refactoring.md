# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
violate Open /Closed principle 
 لو حبينا نضيف تعديل هنعدل في كذا مكان 
- What did you change?
using polymorphism
---

## OrderProcessor

- What was the problem?
violate Dependency Inversion Principle (DIP)
- الhigh level depend on low level
- What did you change?

بنعمل Interfaces (IOrderRepository و IEmailSender).
بنخلي  ال 
Repositories و Senders
يطبقوا ال Interfaces دي

بنبعت ال Interfaces 
دي ل OrderProcessor
عن طریق ل Constructor مش بنعمله
م new جوه الكلاس بايدينا

---

## Notifications

- What was the problem?
 violate Open /Closed principle 
 لو حبينا نضيف channel
جديدة هنضطر نعمل كذا class و كل 
classتاني بي
 inherit منه
- What did you change?
using Composition 

---

## Proof

- New carrier file(s):
- New notification channel file(s):
- Existing classes left unchanged? (yes/no):
