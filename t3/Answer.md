#
## Step 2: StudentStore vs CourseStore
 **What is the same:** 
 Both stores share the exact same
 four core operations (`Add`, `GetById`, `GetAll`, and `Remove`) 
 and use an internal `List` to manage items.
 The structural logic for searching, adding, and removing is identical.
 **What is different:**
 The data type they operate on differs
 `StudentStore` handles `Student` objects (containing Id and Name), 
 while `CourseStore` handles `Course`
 objects (containing Id, Title, and Price)
 This duplication of logic for different types motivates 
 the need for Generics in the next steps.

 ###
 Error step 2::::
 'T' does not contain a definition for 'Id' and no
 accessible extension method 'Id' accepting a first argument of type 
 'T' could be found (are you missing a using directive or an 
 assembly reference?)
 ------> ???? ?? ???? ?? ???? ??? ????? ???id? ?? ?? 



 error in main of task3:: 
 // new Store<int>();
 ??? ??constrain
 ????? ??? ???? ???? 
 class
  int ??? ??
  is a struct 


#