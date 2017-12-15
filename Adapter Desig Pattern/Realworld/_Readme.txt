Adapter pattern
----------------

Define a separate Adapter class that converts the (incompatible) interface of a class (Adaptee) into another interface (Target) clients require.

Here we have provided an example which will do the following
	Import Adhaar customer database into a local database table
	+
	Import PAN Card customer database into the same local database table

In the adhaar database the fields name are different than our local database so we have created a Adapter class called AdhaarAdapter which will convert the Adhaar customer data structure into our local database local structure
The same operation is used for PAN Customer database

The data will be passed though an adapter object, the adapter object will trasform the data into compatable output type
