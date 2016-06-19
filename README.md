# Word Count
## Usage
1. Locate `BookInfo.cs` inside the WordCount project.
2. Pass in the input file path and output file path as first and second parameters respectively.
3. Run the code.

Alternate codes are provided for `Prime.cs` and `WordCounter.cs` in the WordCountAlt project, so mix and match!

## Tests
The two projects use the same sets of tests. To run tests for a certain class in a project, simply change the namespace in the corresponding test.

```csharp
using NUnit.Framework;

namespace WordCount
{
    { /* ... */ }
}
```

or

```csharp
using NUnit.Framework;

namespace WordCountAlt
{
    { /* ... */ }
}
```

## Performance
Here are the benchmark results for the methods `CountWords` in `WordCounter` class and `IsPrime` in `Prime` class, with 100 iterations.

`CountWords` was tested using the text from [The Railway Children](https://en.wikipedia.org/wiki/The_Railway_Children), which contains 62,310 words. `IsPrime` was tested with the number 2,147,483,423, which is the largest prime in the `int32` range.

|               | in WordCount  | in WordCountAlt |
----------------|---------------|-----------------|
| `CountWords`  | 10.17 s       | 9.54 s          |
| `IsPrime`     | 29.89 s       | 0.09 s          |
