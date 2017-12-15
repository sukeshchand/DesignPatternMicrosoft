Observer pattern
----------------------

Here we have provided an example of Notifiying system which will send notification to the subscribers when a new item is arrived in the store

There will be a product notifier class, inside the notifier class there is a provision to add/remove subscribers/observers 
also the item count will be inside the product notifier class, when its changes, it will call the NotifyAll method.
The notifyAll method will be update the information to the all observers/subscribers.