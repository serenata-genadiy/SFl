
I defined 2 lists item into Index.html file in order to show the products that we are selling in the first one, and We show the items of the cart in the second one.

In the first list, showing all the products that we are selling, load with jQuery from the WebApi DB the elements, and adds a button on it to order. This button makes a POST to WebApi Cart.

In the second list, that shows the elements of the cart, should be updated after every PUT (to modify product and add 1 to cart) or DELETE (to remove 1 element to cart) but I have gotten not to run PUT or DELETE on my computer, therefore I used POST instead.

Finally we have a Clear button, which makes a POST (method clear) and empty the cart.