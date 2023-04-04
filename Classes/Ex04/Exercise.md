# Car 4

Add two **constructors** for the class Car

* One default constructor that gives a white car at 1000kg

* The other constructor should set the color and weight

The color has to be either blue, white or red.

The weight has to be between 0 and 3000kg.

Here the class is used:

	var c1 = new Car("blue", 1200); // blue  1200kg
	var c2 = new Car("red", 800);   // red    800kg
	var c3 = new Car();             // white 1000kg

	var c4 = new Car("abcd", 1000);   // doesn't work (good)
	var c5 = new Car("blue", 999999); // doesn't work (good)

	Console.WriteLine($"The color of car1 is {c1.GetColor()} and the weight is {c1.GetWeight()}");
	Console.WriteLine($"The color of car2 is {c2.GetColor()} and the weight is {c2.GetWeight()}");
	Console.WriteLine($"The color of car3 is {c3.GetColor()} and the weight is {c3.GetWeight()}");