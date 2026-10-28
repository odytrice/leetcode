# Drill 150: Evaluate Reverse Polish Notation

LeetCode Medium: https://leetcode.com/problems/evaluate-reverse-polish-notation/

Evaluate valid postfix tokens containing integers and `+ - * /`. Division truncates toward zero. All intermediate results fit int; divisors are nonzero.

Constraints: 1 to 10,000 tokens; integer tokens in [-200,200].

Example: `["2","1","+","3","*"]` returns `9`. Implement `EvalRPN(string[] tokens)`.

## Your task

Implement the stubs in `Solution.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 150-evaluate-reverse-polish-notation
```

To test the completed reference instead of your solution, add `--reference`.
