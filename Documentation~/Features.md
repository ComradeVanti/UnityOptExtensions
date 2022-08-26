# Features

In general this package includes utility functions, overloads and extensions to
make Unity functions which might return null return an `IOpt` instead. Below you
fill find a list of all included methods. Their usage should be
self-explanatory, but if not you can always use the included XML-docs to learn
more.

## Static utility classes

### OptObject

- TryFindObjectOfType

## Extensions

### Object

- ToOpt

### GameObject

- TryGetComponent

### Component

- TryGetComponent
- TryGetComponentInChildren
- TryGetComponentInParent