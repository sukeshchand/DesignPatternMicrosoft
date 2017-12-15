Proxy pattern
--------------------

3 type of proxy patterns are there
	1) Remote - A proxy class will be created to taken care of the client request, the class will be talk to the actual class and take required method/data from it, It hides the other real class functionalities
	2) Virtual - A proxy class will be created and it will return the data eigher by talking the actual class/subject or process by itself by taking the old cached data. 
		This type of approch is used when the real subject communication is costly
	3) Protection Proxy - in this A proxy class will be controlling the request by applying certain rules. According to the pre defined rules the proxy can accept or reject the request

Here we have provided three type of examples 

An ATMMAchine service is there, which will provide the ATMCash and the ATMStatus to the client
The Proxy will talk to the actual ATM class control the operations


