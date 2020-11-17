# PizzaShop20200110
A modification of Shayne Vacher's Pizza Shop coding exercise by Quinn Gil.
Each of the following requirement sections should be implemented in iterations.
** Note that this is a pure code exercise and no data store is to be used. **

====INITIAL REQUIREMENTS====
We are creating an ordering system for a Pizza Shop. A small operation, they don't need much.
The shop only needs the following
Sizes
    Personal size for $9
    Family size for $18
Toppings
    Regular Toppings, each adding 10% of the pizza price to the purchase amount
        Mozzarella, Mushroom, Olives
    Meat Toppings, each adding 15% of the pizza price to the purchase amount
        Pepperoni, Bacon, Ham
 
Requirements
    Create a pizza
        Add Toppings to the pizza
    Get Price of Pizza
    Get Description of Pizza


====MID RANGE REQUIREMENTS====
Sizes
    New Size: Medium for $12
    Family renamed to "Large"
Description Format: "Pizza with {Toppings}."
Requirements
Ability to Remove Topping(s)


====CALZONE REQUIREMENTS====
New Product: Calzone
    Sizes:
        Half-Size for $8
        Full for 14
    Toppings for Calzone same %
Description Format: "{Size} {Pizza|Calzone} with {Toppings}." ensure commas except for the last with 'and'.
    eg: "Full Calzone with Mozzarella, Pepperoni and Mushroom."


====PREMIUM REQUIREMENTS====
New Toppings: Premium
    Premium Toppings, each adding 20% of the pizza price to the purchase amount
        Roasted Garlic, Sundried Tomato's, Feta Cheese
Description Format: "{Size} {Pizza|Calzone} with {Regular Toppings}{Meat Toppings}{Premium Toppings}." ensure commas except for the last with 'and'.
    eg: "Full Calzone with Mozzarella, Pepperoni and Feta Cheese."


====EXPANSION REQUIREMENTS====
New Premium Topping Available
    Thyme & Rosemary
New Regular Topping Available
    Asiago Cheese
The shop has opened a new location
    New Location has some description changes
        Personal is Mini
        Bacon is Crispy Ham
    New Location availability
        Roasted Garlic is unavailable in the new location
        Asiago Cheese is only available in new location


====NEW CURRENCY REQUIREMENTS====
Great Growth has a new Location opening in Bricksburg!
BricksBurg uses a different Currency
    Bedrock and Springfield use LZY currency
    Bricksburg uses BLK currency
    $1.00 LZY is 1,75& BLK. A $10.00 LZY pizza is 17,50& BLK
