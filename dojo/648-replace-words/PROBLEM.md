# Drill 648: Replace Words

LeetCode Medium: https://leetcode.com/problems/replace-words/

Replace each sentence word with its shortest dictionary root that is a prefix of that word. Leave words without a matching root unchanged. Words are lowercase, separated by one space, with no leading or trailing spaces.

Constraints: 1 to 1000 roots of length 1 to 100; sentence length <= 1,000,000.

Example: roots `["cat","bat","rat"]`, sentence `"the cattle was rattled by the battery"` becomes `"the cat was rat by the bat"`. Implement `ReplaceWords(IList<string> dictionary, string sentence)`.
