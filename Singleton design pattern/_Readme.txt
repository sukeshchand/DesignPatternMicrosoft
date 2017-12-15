Singleton pattern
---------------------

Restrcit object creation into only one in the program lifetime

Good example is error logging system. we need only one global instance of an error loging object in the entire lifetime of the program


Singleton and static class difference
-------------------------------------------
both by now Singleton and Static classes both provide a central point of access  i.e. there's only one instance and one way to access it.
The benefit of Singleton class is it is much more flexible that static classes.  Static classes once defined could not accomodate any future design changes as by design static classes are rigid and cannot be extended. 
Singleton on the other hand provides flexibility and also provides sort of a mechanism to control object creation based on various requirements.  They can be extended as well if need arises.  In other words you are not always tied to a particular implementation.  With Singleton you have the flexibility to make changes as when situation demands.. 
