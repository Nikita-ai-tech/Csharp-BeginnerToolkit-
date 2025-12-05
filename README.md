BeginnerToolkit

A simple C# console toolkit for beginners to practice core programming concepts.

---

1. Prompt Used
> “Give me a step‑by‑step guide to build a beginner‑friendly C# console toolkit with reusable functions.”

---

2. Curriculum Links
- Microsoft Learn: C# Fundamentals
- FreeCodeCamp C# Basics
- Dotnet CLI Documentation

---

3. AI’s Response Summary
The AI scaffolded the project structure (Program.cs, Toolkit.cs, ToolkitTests.cs, .csproj, .gitignore, README.md), explained how to upload files manually on GitHub mobile, and provided commit messages for clean version history.

---

4. Problem Addressed
> “The AI helped me scaffold the setup and fix an import error by merging Program.cs and Toolkit.cs into one file for quick testing on dotnetfiddle.”

---

5. Evaluation
The guidance was highly practical:
- Step‑by‑step instructions matched my mobile workflow.  
- Ready‑to‑paste commit messages made my repo professional.  
- Testing examples ensured my Toolkit functions worked correctly.  

---

6. Examples of Toolkit Usage

🧮 Average Calculation
`csharp
int[] numbers = { 5, 10, 15 };
double avg = Toolkit.CalculateAverage(numbers);
Console.WriteLine($"Average of [5,10,15] = {avg}");
`

Output:
`
Average of [5,10,15] = 10
`

---

🔄 Reverse String
`csharp
string reversed = Toolkit.ReverseString("hello");
Console.WriteLine($"Reversed 'hello' = {reversed}");
`

Output:
`
Reversed 'hello' = olleh
`

---

🔢 Square Number
`csharp
Console.WriteLine($"Square of 7 = {Toolkit.SquareNumber(7)}");
`

Output:
`
Square of 7 = 49
`

---

🔍 Check Even Number
`csharp
Console.WriteLine($"Is 10 even? {Toolkit.IsEven(10)}");
Console.WriteLine($"Is 11 even? {Toolkit.IsEven(11)}");
`

Output:
`
Is 10 even? True
Is 11 even? False
`

---

🔧 Toolkit Function Examples

| Function           | Example Input     | Example Code                                              | Expected Output |
|--------------------|-------------------|-----------------------------------------------------------|-----------------|
| CalculateAverage | { 5, 10, 15 }   | Toolkit.CalculateAverage(new int[]{5,10,15})            | 10            |
| ReverseString    | "hello"         | Toolkit.ReverseString("hello")                          | olleh         |
| SquareNumber     | 7               | Toolkit.SquareNumber(7)                                 | 49            |
| IsEven           | 10              | Toolkit.IsEven(10)                                      | True          |
| IsEven           | 11              | Toolkit.IsEven(11)                                      | False         |

---

🛠 Common Issues & Fixes

| Issue                          | Cause                                               | Fix                                                        |
|--------------------------------|-----------------------------------------------------|-------------------------------------------------------------|
| Toolkit not found            | Missing using BeginnerToolkit; or wrong namespace | Ensure namespace matches across files                      |
| Unhandled exception          | Empty array passed to CalculateAverage            | Add check: return 0 if array length = 0                    |
| Upload error on GitHub mobile  | File already exists (README.md)                   | Use Edit file instead of Create new file           |
| “Something went wrong” upload  | Unsupported file type or network glitch             | Use Create new file and paste code manually            |
| dotnet: command not found    | .NET SDK not installed                              | Use dotnetfiddle.net for testing |

Helpful links:
- StackOverflow: C# Average Calculation
- GitHub Docs: Managing Files

---

📚 References
- Official .NET Documentation
- C# Programming Guide
- Dotnetfiddle Online Compiler
- Rextester Online Compiler
- Helpful Blog: C# Basics for Beginners

---

✍️ Author
BeginnerToolkit created by Nikita, as part of her journey in building practical, educational C# projects.
`
