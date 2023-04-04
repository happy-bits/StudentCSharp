# Product list with dictionary

Create the following console app:

![](picture.png)

Let the user input products. A product is supposed to be entered as a number and a description separated with comma. When the user just press enter, then display all the products.

If the user enter a product’id that is already taken, then respond with an error message.

## Hint

Create two methods, one for getting the input and one for the response:

    Dictionary<int, string> products = BuildProductDictionary();
    DisplayProductDictionary(products);

Check if a value is in the dictionary:

    mydictionary.ContainsKey(...)

