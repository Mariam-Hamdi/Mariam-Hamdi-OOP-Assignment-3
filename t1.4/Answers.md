# Part 03 — answers

---

## BlockedUsers

- Time complexity before: o(N^*M)
- Time (ms) before: 46 ms
- What did you change?
 using HashSet ( time complixity o(1) in search ) instead of 
 List blockedIds ( time complixity o(n) in search )
- Time complexity after: o(N)
- Time (ms) after:1ms

---

## Students

- What was the problem?
 ا لكود هياخد  وقت و رامات كتير عشان يخزن
 المليون طالب حتى لو كنت هعرض اول 3 بس مثلا 
- What did you change?
using yield---> return the students one by one instead of storing all of them in memory and returning them at once
