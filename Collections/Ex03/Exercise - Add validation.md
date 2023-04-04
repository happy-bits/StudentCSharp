# Add validation

Continue on the previous app, but add validation:

![](picture.png)

## Hint

Create a method BuildProductDictionary:

    private Dictionary<int, string> BuildProductDictionary()
    {
        ...

        while (true)
        {
            ...
            // Use "break" if user just hit the key "return"
            // Use "continue" if user entered a wrong input
            ...
        }
    }