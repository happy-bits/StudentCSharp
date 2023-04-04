# Car 6

Add an **auto property** namned **Note** so you can add notes for a car freely:



    var c1 = new Car("blue", 1200);
    var c2 = new Car("red", 800);  
    var c3 = new Car();            

    Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
    Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
    Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");

    c1.Note = "A nice car";
    c2.Note = "Very rusty!";

    Console.WriteLine($"The note of car1 is {c1.Note}");
    Console.WriteLine($"The note of car2 is {c2.Note}");
    Console.WriteLine($"The note of car3 is {c3.Note}");