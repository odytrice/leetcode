import { WordDictionary } from "./solution.ts";

class Node {
  readonly children = new Map<string, Node>();
  endsWord = false;
}

// O(word length) insert, branching search for '.'. Exact length is required.
export class ReferenceSolution extends WordDictionary {
  private readonly root = new Node();

  override addWord(word: string): void {
    let node = this.root;
    for (const char of word) {
      let next = node.children.get(char);
      if (next === undefined) {
        next = new Node();
        node.children.set(char, next);
      }
      node = next;
    }
    node.endsWord = true;
  }

  private match(node: Node, word: string, index: number): boolean {
    if (index === word.length) {
      return node.endsWord;
    }
    const char = word[index];
    if (char === ".") {
      for (const child of node.children.values()) {
        if (this.match(child, word, index + 1)) {
          return true;
        }
      }
      return false;
    }
    const child = node.children.get(char);
    return child !== undefined && this.match(child, word, index + 1);
  }

  override search(word: string): boolean {
    return this.match(this.root, word, 0);
  }
}
