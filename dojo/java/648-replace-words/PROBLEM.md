# Drill 648: Replace Words

LeetCode Medium: https://leetcode.com/problems/replace-words/

Replace each sentence word with its shortest dictionary root that is a prefix of that word. Leave words without a matching root unchanged. Words are lowercase, separated by one space, with no leading or trailing spaces.

Constraints: 1 to 1000 roots of length 1 to 100; sentence length <= 1,000,000.

Example: roots `["cat","bat","rat"]`, sentence `"the cattle was rattled by the battery"` becomes `"the cat was rat by the bat"`. Implement `ReplaceWords(IList<string> dictionary, string sentence)`.

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
java\run-all.ps1 -Drill 648-replace-words
```

To test the completed reference instead of your solution, add `--reference`.
