﻿# Opt for Unity

Unity-extensions and utilities
for [Opt](https://www.nuget.org/packages/ComradeVanti.CSharpTools.Opt/)

Found any issues? Post
them [here](https://github.com/ComradeVanti/opt-unity/issues/new/choose).

Want to see the Changelog? Its [here](./CHANGELOG.md).

## Features

Additionally to all features included in the `Opt` package you will also have
access to extensions and utilities which allow you to better deal with
missing values in Unity, such as by using `TryGetComponent` instead
of `GetComponent`.

All features are listed [here](./Documentation~/Features.md).

If you have ideas for
more, [let me know](https://github.com/ComradeVanti/opt-unity/issues/new?assignees=&labels=enhancement&template=unity-api-suggestion--.md&title=)
.

## Installation

The quickest way is to install via [OpenUPM](https://openupm.com)
using `openupm add dev.comradevanti.opt-unity`.

Or install manually
as [git dependency](https://docs.unity3d.com/Manual/upm-ui-giturl.html)
from `https://github.com/ComradeVanti/opt-unity.git` or download as zip
and [import locally](https://docs.unity3d.com/Manual/upm-ui-local.html). If you
decide to install manually, make sure your project includes the
following [scoped registry](https://docs.unity3d.com/Manual/upm-scoped.html):

```json
{
  "name": "package.openupm.com",
  "url": "https://package.openupm.com",
  "scopes": [
    "com.openupm",
    "dev.comradevanti.opt-unity",
    "org.nuget.comradevanti.csharptools.opt"
  ]
}
```