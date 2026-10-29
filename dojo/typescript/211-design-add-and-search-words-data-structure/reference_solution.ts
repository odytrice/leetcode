import { WordDictionary } from "./solution.ts";

class Node {
  readonly children = new Map<string, Node>();
  // True when a whole added word ends at this node.
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
    // Used every pattern character, so a word must end exactly here.
    if (index === word.length) {
      return node.endsWord;
    }
    const char = word[index];
    // A wildcard can be any letter, so try every child.
    if (char === ".") {
      for (const child of node.children.values()) {
        if (this.match(child, word, index + 1)) {
          return true;
        }
      }
      return false;
    }
    // A normal letter has only one possible branch.
    const child = node.children.get(char);
    return child !== undefined && this.match(child, word, index + 1);
  }

  override search(word: string): boolean {
    return this.match(this.root, word, 0);
  }
}
