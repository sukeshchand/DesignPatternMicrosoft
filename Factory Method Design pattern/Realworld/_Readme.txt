Factory method pattern
--------------------------------
In class-based programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created. 
This is done by creating objects by 1)calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

Example
--------
Here we are trying to create two type of resumes. 
1) Resume for Higher education
2) Resume for Job

A factory method called DocumentFactory will be taken care of creating the object of the above
Document_Abstract is the abstract class which has a method called CreatePages(), The creation of pages in the document will be taken care by the CreatePages()

Points to note
------------------
The Document_HigherEducationResume and Document_JobResume are implemented from Document_Abstract so we can point/store the two pages in to Document_Abstract
Page_Education, Page_Experience, Page_PersonalDetails and Page_Skills is a derived from Page_Abstract, So we can create object of any one of the page and store/point towards the Page_Abstract

