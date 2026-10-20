# Part 02 — answers

---

## Reports

- What was the problem?
     ----> "  violate princible DRY "    
- What did you change?
     --->  "هنعمل implementation ثابت  لفانكشن  
 ال save &export و
 فانكشن ال validate is virtual 
 الprivateهحوله لprotected
 عشان اقدر اوصله"
- Why did you choose that approach?
/*
    ---->  interface مش هقدر احط implementation 
 للformate و  ده مينفعش غير في ال
 abstract class  
 لو استخدمتinstance class
 كان لازم اعمل obj 
 منه عشان اعرف استخدمه لكن احنا اصلا مش عاوزين نعمل منه اويجكت لان 
 الimplementation
 بتاعه مكملش   
 */

## Enrollment

- What was the problem?
  ---->ان الprogram main 
 مسؤل عن استدعاء كذا كلاس بالترتيب  ف لو حبيت اعدل في حاجة
  بعدين هضطر اعدل في كذا مكان 
- What did you change?
   هنعمل كلاس واحد و الmain
 يستدعيه هو بس تمام و جواه بقى نعملobjs 
 from other classes and relation is an Aggregation 
- Why did you choose that approach?
مفيد اكتر و بيخفي كل المعلومات عن الuser 
 سواء للحماية او انها مش هتفيده ب حاجة اصلا