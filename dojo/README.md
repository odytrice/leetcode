# Interview Dojo

One problem at a time. You implement; the coach helps when asked.

All 100 problems linked in the [cheat sheet](../index.html) have a drill, including its Easy foundations and Hard extensions. Browse the [catalog by pattern](CATALOG.md).

Folders use the LeetCode problem number padded to at least three digits, not the order practiced (for example, `003-longest-substring` and `056-merge-intervals`).

## Practice loop

1. Read the prompt and ask clarifying questions.
2. Explain your proposed approach before coding.
3. Implement in `Solution.cs` inside the drill folder using C#.
4. Add your own test cases and run the tests.
5. Explain correctness, time complexity and space complexity.
6. Ask for review when ready. Review includes additional cases, not just the supplied tests.

Hints are incremental: a question first, then a small nudge, then a more explicit hint if requested. No solution edits unless you ask.

Choose a drill and read its `PROBLEM.md`. Allow about 35 minutes for a Medium problem and 10 minutes for discussion. The timer is self-managed.

## Running tests

Requires the .NET 10 SDK. No external packages are needed.

From the `dojo` folder, run `dotnet run --project 560-subarray-sum`. From a drill folder, run `dotnet run`.

Each drill contains:

- `PROBLEM.md`: the contract, constraints, an example, and the LeetCode link.
- `Solution.cs`: your practice implementation. New drills start blank; existing work is preserved.
- `ReferenceSolution.cs`: a completed implementation, separate from your work. Avoid opening it until you want the answer.
- `Program.cs`: executable examples and edge cases. Add your own cases here.

To test the completed reference instead of your solution:

```powershell
dotnet run --project 200-number-of-islands -- --reference
```

To verify coverage, build every project, and run every reference suite:

```powershell
./run-all.ps1 -Reference
```

Use `./run-all.ps1 -CheckOnly` to check coverage without building. Omit `-Reference` to run all your practice implementations instead; unfinished ones are expected to fail.

New projects share build settings, assertions, and the LeetCode `ListNode` and `TreeNode` models through `Directory.Build.props` and `shared/`. Graph and random-pointer `Node` types are local to their drills. Keep the practice method signatures intact so the reference subclass continues to compile. The randomized-set tests check membership and removal deterministically, not statistical uniformity.

The earlier TypeScript files are retained, including your unfinished attempt. They are not used by the C# runner.
