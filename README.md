## Description

Compilation fails If the Microsoft MVVM Toolkit source generator attribute [ObservableProperty] is in a `#region` block.

For example, when compiling the following code (in `MainViewModel.cs`), you will get a "`CS1038 #endregion directive expected`" error:

```
// Doesn't compile

#region Properties

[ObservableProperty]
private int counter = 0;

#endregion
```

If you delete the `#region Properties` and `#endregion` lines, the code will compile:

```
// Compiles

// #region Properties

[ObservableProperty]
private int counter = 0;

// #endregion
```

## Environment

- Microsoft.Toolkit.Mvvm 7.1.0-rc1
- Visual Studio 2019
