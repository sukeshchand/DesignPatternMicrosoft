Chain of responsibility
------------------------

Here we have provided an example of purchase approval system inside a company

The purchase request amout is less than 100000 Director can approve,
If it greater than 10000 the director will pass the responsibility of approval to the VicePresident
The vice president will check the amount and if its between 10000 and 25000 He will approve it 
if its greater, then vice presider will pass the responsibility to the President
The president will check the amount, If its between 25000 and 100000. then he will approve, other wise he will call for meeting

