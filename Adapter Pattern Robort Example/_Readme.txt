Adapter pattern - Change the behaviour of the method
---------------------------------------------------------


Here we are provided an example of how a Robot can used for attacking the enemies

The normal attaching will have the following methods
	fireWeapon();
	driveForward();
	assignDriver(string driver);

While attacking with a Tank we can use the above methods

But when we replace the tank with a Robot, The above methods will have to change to new attacking methods as follows

 fireWeapon()	=> smashWithHands()
 driveForward() => walkForward();
 assignDriver() => reactToHuman()

 So we will use a EnemyRobortAttackerAdapter to tranform the actions