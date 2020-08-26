## CLR

* common language framework


* When you compile C#, programs are
translated in IL Code, not binary.
Similar to intermediates in Java,
meant to facilitate portability.

* CLR's job is to translate IL Code
into binary as a just-in-time compiler (JIT)

Architecture of .NET Applications

* applications consists of classes
* namespace -> container for related
classes
* Assembly (DLL or EXE) -> As our application grows, we need
a container for these namespaces

DLL and EXE seem analogous to library vs binary executable in linux

Compiler writes one or more assemblies based on how you
partition your code.

## Overflow

* no overflow checking by default
* variable can be modified at runtime and cause overflow
* checked keyword prevent this, will throw exception. program will crash if unhandled

## Scope

* scope is where a variable has meaning and
is accessible
* 