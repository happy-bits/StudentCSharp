# Animals in a list

Create the following console app:

![](picture.png)
 
The user should enter a list of animals. The app creates a list of string with the animals.

Answer with an error message if one of the following occurs:

- User don’t enter any animal
- One of the animals has more han 20 letters
- One of the animals contains an invalid characters (just accept some letters like a-z, å,ä,ö)

Solve the problem by creating **ArgumentException’s** and catch the exceptions.

## Hint

Create a method **ParseAnimals** that return the animals or throw an exception

    private string[] ParseAnimals(string animalsString)
    {
        ...

        throw new ArgumentException("Animal string don't contain any letters");

        ...

        return animals;
    }