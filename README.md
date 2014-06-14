ObjectChauffer
==============
Whilst reading the rather brilliant book Growing Object-Oriented Software, Guided By Tests, I saw an interesting 
example of using a builder pattern for creating object instances. Here’s a example:

Customer customer = new CustomerBuilder().WithFirstName(“John”).Build();

A builder object can take care of initializing object instances, or even create a list of those object instances.
Take a look at nBuilder for an example of a great framework that does just that. What caught me out was the
method “WithFirstName”. Interesting; the property “FirstName” appears in the method name.

Previously I had seen objects initialized similar to the following

Customer customer = Builder<Customer>.CreateNew().With(c => c.FirstName = "John").Build();

This got me thinking – having just played around with ExpandoObject I decided to have a got at replicating the 
CustomerBuilder seen in the Growing Objects book.
