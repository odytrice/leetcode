// O(total letters) time. Walks a trie of roots and stops at the first word end.
export function replaceWords(dictionary: string[], sentence: string): string {
  // Each trie node is a map from a letter to the child node.
  const children = new Map<string, Map<string, unknown>>();
  // The set tells us when a walked prefix is a whole root, not just part of one.
  const roots = new Set(dictionary);
  for (const word of dictionary) {
    let node = children;
    for (const char of word) {
      let next = node.get(char) as Map<string, unknown> | undefined;
      if (next === undefined) {
        next = new Map<string, unknown>();
        node.set(char, next);
      }
      node = next as Map<string, Map<string, unknown>>;
    }
  }

  const replace = (word: string): string => {
    let node: Map<string, unknown> | undefined = children;
    let prefix = "";
    for (const char of word) {
      node = node.get(char) as Map<string, unknown> | undefined;
      // No root continues with this letter, so keep the word as it is.
      if (node === undefined) {
        return word;
      }
      prefix += char;
      // Stop at the first root found, which is the shortest one.
      if (roots.has(prefix)) {
        return prefix;
      }
    }
    return word;
  };

  return sentence.split(" ").map(replace).join(" ");
}
