# Features

In general this package includes utility functions, overloads and extensions to
make Unity functions which might return null return an `IOpt` instead. Below you
fill find a list of all included methods. Their usage should be
self-explanatory, but if not you can always use the included XML-docs to learn
more.

## Static utility classes

### OptObject

- TryFindObjectOfType

### OptResources

- TryLoad

## Extensions

### Object

- ToOpt

### GameObject

- TryGetComponent

### Component

- TryGetComponent
- TryGetComponentInChildren
- TryGetComponentInParent

## OptField

You can declare optional fields in the inspector. For example, let's say, your script *can* have a reference to a rigidbody, but does not *have to*. In this case, you could do:
```csharp
[SerializeField] private OptField<Rigidbody> maybeRigidbody;
```

which would show up in the inspector like this
![Alt text](./Images/None.png "No value set")
![Alt text](./Images/Some.png "Some value set")