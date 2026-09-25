# Day 10 Assignment - Generics, Delegates, Functional Programming, and Research Topics

**Name:** Asser Mohammed Khairallah
**Group Code:** GIZ5_SWD5_S2

## 1. Practical Code

The solution is located in `Day10_Workspace` and targets `net5.0`.

The implementation is separated into focused files:

- `Program.cs`: runs and demonstrates all twenty practical examples.
- `Employee.cs`: employee model, salary comparison, and cloning.
- `Manager.cs`: manager inheritance, comparison, and cloning.
- `SortingAlgorithm.cs`: generic sorting with `IComparable<T>` and `ICloneable` constraints.
- `SortingTwo.cs`: dynamic generic sorting with a comparison function.
- `Comparers.cs`: string-length and employee multi-criteria comparers.
- `Delegates.cs`: custom delegates, generic delegates, and delegate operations.
- `GenericMethods.cs`: generic `Swap<T>` and `GetDefault<T>` methods.

The practical examples cover:

- Generic sorting and generic constraints.
- Dynamic and multi-criteria sorting.
- `IComparable<T>` and `ICloneable`.
- Anonymous functions and lambda expressions.
- Custom delegates and generic delegates.
- `Func`, `Action`, and `Predicate`.
- Default values and swapping generic values.

### Verification

```text
dotnet build Day10_Workspace/Day10_Solution.sln
dotnet run --project Day10_Workspace/TaskApp/TaskApp.csproj
```

The application runs all twenty examples successfully with no build warnings or errors.

## 2. Technical Research Report (PDF)

The research report contains the required Day 10 Part 02 topics:

- Parallel Programming and Concurrency.
- Unit Testing and Test-Driven Development (TDD).
- Asynchronous Programming with `async` and `await`.

[Open the research report on Google Drive](https://drive.google.com/file/d/1MxywI_rtoHBbgVs_rsmZHXm4KUs27A-G/view?usp=sharing)

The local report is also included as `DotNet_Day10_Report.pdf`.

## 3. LinkedIn Post

The LinkedIn post summarizes the Day 10 topics in generics, delegates, lambdas, constraints, and functional programming.

[Open the LinkedIn post](https://lnkd.in/p/eZSjj3Wn)

A screenshot of the published post is included as `LinkedIn_Post.png`.

## 4. Project Scope

The submission includes the required Part 01 practical work and the required Part 02 research and LinkedIn material. The Part 03 bonus self-study report and the separate bonus asynchronous-programming explanation are intentionally excluded.
