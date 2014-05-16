This is a c sharp concole app that clearly demonstrates the three types of dependency injection that were identified by Martin Fowloer:
	1 Constructor Injection where the dependencies are provided through a class constructor.
	2 Setter Injection where the client exposes a setter method that the injector uses to inject the depndency.
	3 Interface Injection where the dependency provides an injector method that will inject the depnedency into any client passed to it.