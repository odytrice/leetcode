// O(cells * 4^depth) time. Searches once over a trie of all words.
export function findWords(board: string[][], words: string[]): string[] {
  interface Node {
    children: Map<string, Node>;
    // Set on the node where a word ends, so we know which word was found.
    word?: string;
  }

  // Phase 1: build a trie of all the words so one board walk checks them all.
  const root: Node = { children: new Map() };
  for (const word of words) {
    let node = root;
    for (const char of word) {
      let next = node.children.get(char);
      if (next === undefined) {
        next = { children: new Map() };
        node.children.set(char, next);
      }
      node = next;
    }
    node.word = word;
  }

  const rows = board.length;
  const columns = board[0].length;
  const result: string[] = [];

  const search = (row: number, column: number, node: Node): void => {
    if (row < 0 || column < 0 || row >= rows || column >= columns) {
      return;
    }
    const char = board[row][column];
    // Stop as soon as no word continues with this letter.
    const child = node.children.get(char);
    if (child === undefined) {
      return;
    }
    if (child.word !== undefined) {
      result.push(child.word);
      // Clear the word so it is only reported once.
      child.word = undefined;
    }
    // Blank the cell so this path cannot reuse it; restore it afterwards.
    board[row][column] = "";
    search(row - 1, column, child);
    search(row + 1, column, child);
    search(row, column - 1, child);
    search(row, column + 1, child);
    board[row][column] = char;
  };

  for (let row = 0; row < rows; row += 1) {
    for (let column = 0; column < columns; column += 1) {
      search(row, column, root);
    }
  }
  return result;
}
