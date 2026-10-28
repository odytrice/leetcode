# Drill 211: Design Add and Search Words Data Structure

LeetCode Medium: https://leetcode.com/problems/design-add-and-search-words-data-structure/

Implement `WordDictionary()`, `AddWord(string word)`, and `Search(string word)`. Insert lowercase words. A search pattern may contain `'.'`, matching exactly one arbitrary letter. A match must consume the whole word.

Constraints: lengths 1 to 25; at most two dots per search; at most 10,000 operations.

Example: insert "bad", "dad", "mad"; search ".ad" -> true; search ".." -> false.

## Your task

Implement the stubs in `WordDictionary.java` using Java without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
javac -d build -sourcepath "..;." Main.java
java -cp build Main
```

Or from the `dojo` root:

```powershell
java\run-all.ps1 -Drill 211-design-add-and-search-words-data-structure
```

To test the completed reference instead of your solution, add `--reference`.
