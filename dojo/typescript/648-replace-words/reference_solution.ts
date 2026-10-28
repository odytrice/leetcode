// O(total letters) time. Walks a trie of roots and stops at the first word end.
export function replaceWords(dictionary: string[], sentence: string): string {
  const children = new Map<string, Map<string, unknown>>();
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
      if (node === undefined) return word;
      prefix += char;
      if (roots.has(prefix)) return prefix;
    }
    return word;
  };

  return sentence.split(" ").map(replace).join(" ");
}
