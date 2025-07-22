-----

# 30 Days in C#
![C# 30 Günlük Eğitim Serisi](https://img.shields.io/badge/C%23-30Days-blueviolet)

A 30-day journey for those who want to learn the C\# language\! Each day, we'll cover a core topic with code examples.

> Prepared by: M. Talha Çelik
> Note: This guide includes daily notes, examples, and explanations. It covers topics from beginner to advanced levels.

-----

## Main Method - The Entry Point of the Program

In C\#, every program starts with the `Main` method. This is where the code execution begins.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Program started!"); // Prints text to the console
}
```

  - `static`: Used for the program to run without creating an object.
  - `void`: Indicates that it does not return a value.
  - `string[] args`: Receives arguments passed from the command line.

## Data Types

Basic data types in C\#:

| Data Type | Description         |
|-----------|---------------------|
| int       | Integers            |
| double    | Floating-point numbers |
| char      | Single character    |
| string    | Text data           |
| bool      | true/false values   |

Methods like `Convert.ToInt32()`, `int.Parse()`, `TryParse()` are used for type conversion.

-----

## 30 Days in C\#

This guide is a 30-day development journey prepared for those who want to learn the C\# language from scratch. Each day, we'll delve into a concept in detail and reinforce it with examples. The daily progression plan is as follows:

-----

## Day 0 - Hello World

Writing the first application in C\#, the `Main` method, and printing output with `Console.WriteLine()`.

## Day 1 - Data Types

Basic data types (`int`, `double`, `char`, `string`, `bool`) and conversions with the `Convert` class.

## Day 2 - Operators

Arithmetic, comparison, and logical operators. Understanding how expressions work.

## Day 3 - Intro to Conditional Statements

Controlling program flow with conditional statements like `if`, `else if`, `else`, `switch`.

## Day 4 - Class vs. Instance

What is a class, what is an instance? Learning object creation, the first step in OOP.

## Day 5 - Loops

`for`, `while`, `do-while`, `foreach` loops. When and how to use loops.

## Day 6 - Let’s Review

A quick review of previously learned topics and a mini-application.

## Day 7 - Arrays

Single-dimensional and multi-dimensional arrays. Methods like `Length`, `IndexOf`, `Sort`.

## Day 8 - Dictionaries and Maps

Usage of `Dictionary<TKey, TValue>`. Understanding key-value pair logic.

## Day 9 - Recursion

Methods that call themselves. Explained with classic examples like Factorial and Fibonacci.

## Day 10 - Binary Numbers

Introduction to the binary number system. Bitwise operations and interpreting numbers in binary.

## Day 11 - 2D Arrays

Introduction to matrix structure. Processing data with rows and columns.

## Day 12 - Inheritance

What is inheritance, why is it used? Usage of `: base` and derived classes.

## Day 13 - Abstract Classes

Abstract classes and abstract methods. Abstracting common behaviors between classes.

## Day 14 - Scope

Scope of variables (local vs. global). Access modifiers like `public`, `private`, `protected`.

## Day 15 - Linked List

What is a linked list, how does it work? Exemplifying by defining your own `Node` class.

## Day 16 - Exceptions - String to Integer

Catching errors (`try-catch-finally`). Comparison of `int.Parse`, `Convert.ToInt32`, `TryParse`.

## Day 17 - More Exceptions

Custom exception classes, `throw`, `InnerException`, `finally` blocks.

## Day 18 - Queues

`Queue<T>` and `Stack<T>` structures. FIFO vs. LIFO logic.

## Day 19 - Interfaces

What is an interface, differences between class and interface. Example interfaces like `IComparable`, `IDisposable`.

## Day 20 - Sorting

Data sorting methods. Usage of `Array.Sort()`, `List.Sort()`, `IComparer`.

## Day 21 - Generics

Generic classes and methods. Working with type `T` and type safety.

## Day 22 - Binary Search Trees

Introduction to tree structures. Creating data structures with nodes.

## Day 23 - BST Level-Order Traversal

Level-by-level traversal on a binary tree (BFS with `Queue`).

## Day 24 - More Linked Lists

Doubly linked lists. Enhancing with extra functionalities.

## Day 25 - Running Time and Complexity

Algorithm runtime. Big-O notation.

## Day 26 - Nested Logic

Nested logical structures. How conditions work within each other.

## Day 27 - Testing

Writing simple test scenarios. `Debug.Assert` and manual testing approaches.

## Day 28 - Regex, Patterns and Intro to Databases

Regex (regular expressions) for string matching. Introduction to databases.

## Day 29 - Bitwise AND

Bitwise operations (`&`, `|`, `^`, `~`, `<<`, `>>`). Powerful tools especially used in algorithms.

-----

💡 BONUSES AND SPECIAL THINGS YOU'VE DONE

  * Demonstrated `Split()` with examples: "You win some. You lose some." → splitting by both spaces and periods.
  * Resolved logical error in Regex usage (group structure including `|` instead of `&&`).
  * Created test examples running in Release mode.
  * Built user-interactive test scenarios.
  * Created annotated and understandable examples with the "Code With Love (cwl)" signature.
  * Performed code scoring and style evaluation (e.g., readability, user experience, modularity).
  * Analyzed an example that finds the maximum `a & b < k` combination.

-----

## 💡 Points That Might Confuse

| Topic | Why it's Confusing? | Explanation |
|------|---------------------|-------------|
| `==` vs `.Equals()` | Value or reference? | `==` for primitives, `.Equals()` for objects. |
| `ref` vs `out` | Seem similar | `ref` is input-output, `out` is output only. |
| `var` | Type seems hidden | Compile-time type. |
| `static` | Called without an object | Belongs to the class. |
| `new` keyword | Different meanings | Object creation vs. method overriding. |
| `abstract` vs `interface` | Which one when? | `abstract` can contain code, `interface` only definitions. |
| `params` | Variable number of arguments | Used for multiple arguments. |
| `is`, `as`, `typeof` | Type checking tools | `is`: check, `as`: cast, `typeof`: returns type. |
| `Nullable<int>` vs `int?` | They are the same | `int?` is the shorthand. |
| `List` vs `Array` | Which one to use? | `List` is dynamic, `Array` has fixed size. |

-----

## 🎓 Advice for Beginners

1.  Keep logs with `Console.WriteLine()` in every example.
2.  Learn by debugging the code.
3.  Understand the differences between arrays, lists, and dictionaries.
4.  Experiment with loops to see their differences.
5.  Learn methods like `Split()`, `Parse()`, `TryParse()`.
6.  If you can't explain it, you haven't learned it.
7.  Use StackOverflow and Microsoft Docs.
8.  Take even small code seriously.
9.  Pay attention to project structure.

-----
