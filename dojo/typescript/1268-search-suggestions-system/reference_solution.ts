// O(sorted products + prefix searches). Sorts once, then reads three matches per prefix.
export function suggestedProducts(products: string[], searchWord: string): string[][] {
  // Sorting puts every word with a given prefix in one block, in lexicographic order.
  const ordered = [...products].sort();
  const result: string[][] = [];
  for (let length = 1; length <= searchWord.length; length += 1) {
    const prefix = searchWord.slice(0, length);
    let low = 0;
    let high = ordered.length;
    // Binary search for the first word that is not below the prefix.
    while (low < high) {
      const middle = (low + high) >> 1;
      if (ordered[middle] < prefix) {
        low = middle + 1;
      } else {
        high = middle;
      }
    }
    const suggestions: string[] = [];
    // Take up to three words from that point while they still share the prefix.
    for (let index = low; index < ordered.length && suggestions.length < 3; index += 1) {
      if (!ordered[index].startsWith(prefix)) {
        break;
      }
      suggestions.push(ordered[index]);
    }
    result.push(suggestions);
  }
  return result;
}
