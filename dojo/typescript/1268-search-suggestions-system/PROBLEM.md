# Drill 1268: Search Suggestions System

LeetCode Medium: https://leetcode.com/problems/search-suggestions-system/

For every successive nonempty prefix of searchWord, return up to three lexicographically smallest products starting with that prefix, sorted lexicographically. Include an empty list for prefixes with no matches.

Constraints: 1 to 1000 distinct lowercase products; total product length <= 20,000; searchWord length 1 to 1000. You may sort products.

Example: products `["bags","baggage","banner","box","cloth"]`, search `"ba"` gives `[["baggage","bags","banner"],["baggage","bags","banner"]]`. Implement `SuggestedProducts(string[] products, string searchWord)` returning `IList<IList<string>>`.

## Your task

Implement the stubs in `solution.ts` using TypeScript without external libraries. Keep the given names and signatures, and leave the reference solution alone.

Before coding, explain your understanding and proposed approach in chat. The supplied tests are a starting point, not a complete assessment; add cases you think matter.

Run tests from this folder:

```powershell
node test_solution.ts
```

Or from the `dojo` root:

```powershell
node typescript/1268-search-suggestions-system/test_solution.ts
```

To test the completed reference instead of your solution, add `--reference`.
