# Interview Dojo

One problem at a time, in the language you are practicing this week. You implement; the coach helps when asked.

All 100 problems linked in the [cheat sheet](../index.html) have a drill in each of five languages: C#, Python, TypeScript, Java, and F#. Browse the [catalog by pattern](CATALOG.md).

```
dojo/
  csharp/       C# drills (dotnet run)
  python/       Python drills (python test_solution.py)
  typescript/   TypeScript drills (node test_solution.ts)
  java/         Java drills (javac + java)
  fsharp/       F# drills (dotnet fsi test.fsx)
  run-all.ps1   run every language, or the ones you name
```

Every language tree repeats the same folder names, so `csharp/560-subarray-sum` and `python/560-subarray-sum` are the same problem. Folders use the LeetCode problem number padded to at least three digits, not the order practiced (for example, `003-longest-substring` and `056-merge-intervals`).

## Practice loop

1. Read the prompt and ask clarifying questions.
2. Explain your proposed approach before coding.
3. Implement the stub in the drill folder, in that tree's language.
4. Add your own test cases and run the tests.
5. Explain correctness, time complexity and space complexity.
6. Ask for review when ready. Review includes additional cases, not just the supplied tests.

Hints are incremental: a question first, then a small nudge, then a more explicit hint if requested. No solution edits unless you ask.

Choose a drill and read its `PROBLEM.md`. Allow about 35 minutes for a Medium problem and 10 minutes for discussion. The timer is self-managed.

## What each drill contains

Every tree keeps the practice stub and the completed reference separate, and nothing else is shared between them:

| Language | Practice stub | Reference | Tests | Statement |
| --- | --- | --- | --- | --- |
| C# | `Solution.cs` | `ReferenceSolution.cs` | `Program.cs` | `PROBLEM.md` |
| Python | `solution.py` | `reference_solution.py` | `test_solution.py` | `PROBLEM.md` |
| TypeScript | `solution.ts` | `reference_solution.ts` | `test_solution.ts` | `PROBLEM.md` |
| Java | `Solution.java` (or the design class, such as `MinStack.java`) | `ReferenceSolution.java` | `Main.java` | `PROBLEM.md` |
| F# | `Solution.fs` | `ReferenceSolution.fs` | `test.fsx` | `PROBLEM.md` |

Stubs raise or throw until you fill them in. `PROBLEM.md` is the same statement in every tree.

## Running one drill

Each drill runs on its own. Add `--reference` to test the completed reference instead of your practice file.

```powershell
# C#, from the drill folder
dotnet run
dotnet run -- --reference

# Python
python test_solution.py
python test_solution.py --reference

# TypeScript
node test_solution.ts
node test_solution.ts --reference

# Java
javac -d build -sourcepath "..;." Main.java
java -cp build Main
java -cp build Main --reference

# F#
dotnet fsi test.fsx
dotnet fsi test.fsx -- --reference
```

From a language root, name the drill instead:

```powershell
cd dojo/csharp
dotnet run --project 200-number-of-islands -- --reference

cd dojo/python
python python/200-number-of-islands/test_solution.py

cd dojo/typescript
node typescript/200-number-of-islands/test_solution.ts

cd dojo/java
./run-all.ps1 -Drill 200-number-of-islands -Reference

cd dojo/fsharp
dotnet fsi fsharp/200-number-of-islands/test.fsx -- --reference
```

## Running everything

Each language root has its own `run-all.ps1`. Without `-Reference` it runs your practice files, and unfinished ones are expected to fail.

```powershell
cd dojo/csharp
./run-all.ps1 -Reference          # every drill, completed reference
./run-all.ps1 -CheckOnly          # coverage only, no builds
./run-all.ps1 -Drill 560-subarray-sum,146-lru-cache -Reference
```

The dojo root drives all five:

```powershell
cd dojo
./run-all.ps1 -CheckOnly          # every tree has all 100 drills and all files
./run-all.ps1 -Reference          # every reference suite, all languages
./run-all.ps1 -Language python,typescript -Reference
./run-all.ps1 -Language java -Drill 146-lru-cache -Reference
```

Coverage is checked against the problems linked in `index.html`, so a drill added to one tree must be added to all five.

## Toolchains

| Language | Needs |
| --- | --- |
| C# | .NET 10 SDK |
| Python | Python 3.10 or newer (type hints use `X | None`) |
| TypeScript | Node 24 (runs `.ts` files directly, no build step) |
| Java | JDK 21 (`javac` and `java` on the path) |
| F# | .NET 10 SDK (`dotnet fsi`) |

No external packages are required anywhere.

## Shared helpers

Each tree has its own helpers, and drills build independently:

- `csharp/` uses `Directory.Build.props` plus `shared/TestSupport.cs` and `shared/Models.cs`.
- `python/shared.py` holds the `ListNode` and `TreeNode` models.
- `typescript/shared.ts` holds the same models plus the assertion helpers.
- `java/` holds `TestSupport.java`, `ListNode.java`, and `TreeNode.java` in the default package, so `javac -sourcepath` finds them from any drill.
- `fsharp/Models.fsx` and `fsharp/TestSupport.fsx` are loaded by each `test.fsx`.

Graph and random-pointer node types are local to their drills, as on LeetCode.

Instance-design drills (LRU cache, min stack, trie, median finder, and friends) keep a class rather than a single method. Java names the practice file after that class because the file name must match; F# uses `abstract` members with `default` stubs so the reference can override them, mirroring C# `virtual`.

The randomized-set tests check membership and removal deterministically, not statistical uniformity.
