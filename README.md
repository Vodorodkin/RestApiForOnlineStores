Requirements:
Implement operations: creating an order, receiving order information (tracking), updating order information, canceling an order, receiving a list of postamates and information about the postamate.
For the storage of orders and postamates, you can take any storage, BUT the plus will be:
the implementation of CodeFirst on the Entity Framework Core (MS SQL/ Postgree)
implementation using NoSQL DB to choose from.
If the order does not exist, report the response code: "not found".
The order status and postamate number fields are immutable.
The order can contain no more than 10 products. If there are more products, issue a response code "request error".
If the number of the postamate is specified, the format of which is incorrect, issue a request error. The format of the postamate number is "XXXX-XXX", where X is a digit.
If the postamat does not exist, report the response code: "not found".
The format of the phone number must meet the mask "+7XXX-XXX-XX-XX", where numbers should stand instead of X. If the number does not match the format, issue the response code "request error".
If there is an attempt to create an order for a closed postamat – prohibit registering an order with the error code "prohibited".
