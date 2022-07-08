# PueSharp

My custom FP implementation for a rock solid Csharp experience.

I didn't want to just use an existing library such as language-ext https://github.com/louthy/language-ext, 
because I am interested in the concepts behind functional programming. 
So I created my own library to use it in my projects.

## Installing

Available on NuGet

```
dotnet add package BitShifter.PureSharp
```

or

```
PM> Install-Package BitShifter.PureSharp
```

## Example usage

```c#
Result<int, Exception> result = 42.Succeeded<int, Exception>();

int value = result
               .Match(
                  onSuccess: x => x,
                  onFailure: _ => 0);

value.Should()
      .Be(42);
```