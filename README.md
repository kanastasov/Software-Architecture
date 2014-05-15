Software-Architecture
=====================
This is a c #/sharp console app that clearly demonstrates the three types of dependency injection that were identified by Martin Fowler:

	i Constructor Injection where the dependencies are provided through a class constructor.
	
	ii Setter Injection where the client exposes a setter method that the injector uses to inject the dependency.
	
	iii Interface Injection where the dependency provides an injector method that will inject the depenedency into any client passed to it.
