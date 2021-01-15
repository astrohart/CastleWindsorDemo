<a name='assembly'></a>
# CastleWindsorDemo

## Contents

- [ComponentRegistration](#T-CastleWindsorDemo-ComponentRegistration 'CastleWindsorDemo.ComponentRegistration')
  - [Register(kernel)](#M-CastleWindsorDemo-ComponentRegistration-Register-Castle-MicroKernel-IKernelInternal- 'CastleWindsorDemo.ComponentRegistration.Register(Castle.MicroKernel.IKernelInternal)')
- [DependencyResolver](#T-CastleWindsorDemo-DependencyResolver 'CastleWindsorDemo.DependencyResolver')
  - [_container](#F-CastleWindsorDemo-DependencyResolver-_container 'CastleWindsorDemo.DependencyResolver._container')
  - [Initialize()](#M-CastleWindsorDemo-DependencyResolver-Initialize 'CastleWindsorDemo.DependencyResolver.Initialize')
  - [Resolve\`\`1()](#M-CastleWindsorDemo-DependencyResolver-Resolve``1 'CastleWindsorDemo.DependencyResolver.Resolve``1')
- [IRocket](#T-CastleWindsorDemo-IRocket 'CastleWindsorDemo.IRocket')
  - [Launch(delaySeconds)](#M-CastleWindsorDemo-IRocket-Launch-System-Int32- 'CastleWindsorDemo.IRocket.Launch(System.Int32)')
- [LoggingInterceptor](#T-CastleWindsorDemo-LoggingInterceptor 'CastleWindsorDemo.LoggingInterceptor')
  - [Intercept(invocation)](#M-CastleWindsorDemo-LoggingInterceptor-Intercept-Castle-DynamicProxy-IInvocation- 'CastleWindsorDemo.LoggingInterceptor.Intercept(Castle.DynamicProxy.IInvocation)')
- [Program](#T-CastleWindsorDemo-Program 'CastleWindsorDemo.Program')
  - [#cctor()](#M-CastleWindsorDemo-Program-#cctor 'CastleWindsorDemo.Program.#cctor')
  - [Main(args)](#M-CastleWindsorDemo-Program-Main-System-String[]- 'CastleWindsorDemo.Program.Main(System.String[])')
- [Rocket](#T-CastleWindsorDemo-Rocket 'CastleWindsorDemo.Rocket')
  - [Model](#P-CastleWindsorDemo-Rocket-Model 'CastleWindsorDemo.Rocket.Model')
  - [Name](#P-CastleWindsorDemo-Rocket-Name 'CastleWindsorDemo.Rocket.Name')
  - [Launch(delaySeconds)](#M-CastleWindsorDemo-Rocket-Launch-System-Int32- 'CastleWindsorDemo.Rocket.Launch(System.Int32)')

<a name='T-CastleWindsorDemo-ComponentRegistration'></a>
## ComponentRegistration `type`

##### Namespace

CastleWindsorDemo

##### Summary

Implements the [IRegistration](#T-Castle-MicroKernel-Registration-IRegistration 'Castle.MicroKernel.Registration.IRegistration') interface.

##### Remarks

This class does the connection between interceptors and the objects they work on.

<a name='M-CastleWindsorDemo-ComponentRegistration-Register-Castle-MicroKernel-IKernelInternal-'></a>
### Register(kernel) `method`

##### Summary

Associates project classes with interceptors.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| kernel | [Castle.MicroKernel.IKernelInternal](#T-Castle-MicroKernel-IKernelInternal 'Castle.MicroKernel.IKernelInternal') | (Required.) Reference to an instance of an object that implements the [IKernelInternal](#T-Castle-MicroKernel-IKernelInternal 'Castle.MicroKernel.IKernelInternal') interface.  This object provides access to the Castle.Windsor library functionality. |

<a name='T-CastleWindsorDemo-DependencyResolver'></a>
## DependencyResolver `type`

##### Namespace

CastleWindsorDemo

##### Summary

Provides functionality to resolve injected dependencies.

<a name='F-CastleWindsorDemo-DependencyResolver-_container'></a>
### _container `constants`

##### Summary

Reference to an instance of an object that implements the [IWindsorContainer](#T-Castle-Windsor-IWindsorContainer 'Castle.Windsor.IWindsorContainer') interface.

##### Remarks

This object serves as the Dependency Container.

<a name='M-CastleWindsorDemo-DependencyResolver-Initialize'></a>
### Initialize() `method`

##### Summary

Initializes the IoC container.

##### Parameters

This method has no parameters.

<a name='M-CastleWindsorDemo-DependencyResolver-Resolve``1'></a>
### Resolve\`\`1() `method`

##### Summary

Resolves types for the object or interface `T`.

##### Returns

Reference to an instance of the component of type `T`.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | (Required.) Type to resolve dependencies for. |

<a name='T-CastleWindsorDemo-IRocket'></a>
## IRocket `type`

##### Namespace

CastleWindsorDemo

##### Summary

Describes the public interface of a rocket object.

<a name='M-CastleWindsorDemo-IRocket-Launch-System-Int32-'></a>
### Launch(delaySeconds) `method`

##### Summary

Launches the rocket after a countdown specified by the `delaySeconds` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delaySeconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Number of seconds to count down before launching the rocket. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if `delaySeconds` is zero or negative. |

<a name='T-CastleWindsorDemo-LoggingInterceptor'></a>
## LoggingInterceptor `type`

##### Namespace

CastleWindsorDemo

##### Summary

Intercepts method entry, exit, and exception occurrence to log messages to the console.

<a name='M-CastleWindsorDemo-LoggingInterceptor-Intercept-Castle-DynamicProxy-IInvocation-'></a>
### Intercept(invocation) `method`

##### Summary

Called when intercepted DynamicProxy calls are made to program class' methods.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| invocation | [Castle.DynamicProxy.IInvocation](#T-Castle-DynamicProxy-IInvocation 'Castle.DynamicProxy.IInvocation') | Reference to an instance of an object that implements the [IInvocation](#T-Castle-DynamicProxy-IInvocation 'Castle.DynamicProxy.IInvocation') interface. |

##### Remarks

This method can be used to intercept the entry, exit, and exception-thrown scenarios of a method call.

<a name='T-CastleWindsorDemo-Program'></a>
## Program `type`

##### Namespace

CastleWindsorDemo

##### Summary

Provides functionality for the program entry point.

##### Remarks

This program was created by me in order to learn more about the Castle.Windsor dependency-injection (DI) framework.  In this project, we are developing it while following along with the Aspect Oriented Programming (AOP) in C# using Castle DynamicProxy article on The Code Project, at: https://www.codeproject.com/Articles/1083684/Aspect-Oriented-Programming-AOP-in-Csharp-using-Ca.

<a name='M-CastleWindsorDemo-Program-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only for the [Program](#T-CastleWindsorDemo-Program 'CastleWindsorDemo.Program') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being created or before any static members are referenced.

<a name='M-CastleWindsorDemo-Program-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

Entry point of the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | (Optional.) Array of strings, one per value passed on the command line of this application. |

<a name='T-CastleWindsorDemo-Rocket'></a>
## Rocket `type`

##### Namespace

CastleWindsorDemo

##### Summary

Concrete implementation of a rocket.

<a name='P-CastleWindsorDemo-Rocket-Model'></a>
### Model `property`

##### Summary

Gets or sets a string containing the model of the rocket.

<a name='P-CastleWindsorDemo-Rocket-Name'></a>
### Name `property`

##### Summary

Gets or sets a string containing the name of the rocket.

<a name='M-CastleWindsorDemo-Rocket-Launch-System-Int32-'></a>
### Launch(delaySeconds) `method`

##### Summary

Launches the rocket after a countdown specified by the `delaySeconds` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| delaySeconds | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Number of seconds to count down before launching the rocket. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if `delaySeconds` is zero or negative. |
