// O(cells * 4^depth) time. Searches once over a trie of all words.
export function findWords(board: string[][], words: string[]): string[] {
  interface Node {
    children: Map<string, Node>;
    word?: string;
  }

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
    if (row < 0 || column < 0 || row >= rows || column >= columns) return;
    const char = board[row][column];
    const child = node.children.get(char);
    if (child === undefined) return;
    if (child.word !== undefined) {
      result.push(child.word);
      child.word = undefined;
    }
    board[row][column] = "";
    search(row - 1, column, child);
    search(row + 1, column, child);
    search(row, column - 1, child);
    search(row, column + 1, child);
    board[row][column] = char;
  };

  for (let row = 0; row < rows; row++) {
    for (let column = 0; column < columns; column++) search(row, column, root);
  }
  return result;
}
