# Drill 211: Design Add and Search Words Data Structure

LeetCode Medium: https://leetcode.com/problems/design-add-and-search-words-data-structure/

Implement `WordDictionary()`, `AddWord(string word)`, and `Search(string word)`. Insert lowercase words. A search pattern may contain `'.'`, matching exactly one arbitrary letter. A match must consume the whole word.

Constraints: lengths 1 to 25; at most two dots per search; at most 10,000 operations.

Example: insert "bad", "dad", "mad"; search ".ad" -> true; search ".." -> false.

## Your task

Implement the stubs in `Solution.fs` using F# without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
dotnet fsi test.fsx
```

Or from the `dojo` root:

```powershell
dotnet fsi fsharp/211-design-add-and-search-words-data-structure/test.fsx
```

To test the completed reference instead of your solution, add `--reference`.
