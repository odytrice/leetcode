import { Trie } from "./solution.ts";

class Node {
  readonly children = new Map<string, Node>();
  // True when a whole inserted word ends at this node, not just a prefix.
  endsWord = false;
}

// O(word length) per operation. Each node maps letters and records word ends.
export class ReferenceSolution extends Trie {
  private readonly root = new Node();

  override insert(word: string): void {
    let node = this.root;
    for (const char of word) {
      let next = node.children.get(char);
      // Create the missing branch for this letter.
      if (next === undefined) {
        next = new Node();
        node.children.set(char, next);
      }
      node = next;
    }
    node.endsWord = true;
  }

  // Follows text letter by letter; undefined means no stored word starts with it.
  private find(text: string): Node | undefined {
    let node: Node | undefined = this.root;
    for (const char of text) {
      node = node.children.get(char);
      if (node === undefined) {
        return undefined;
      }
    }
    return node;
  }

  override search(word: string): boolean {
    // The path must exist and also mark the end of a whole word.
    return this.find(word)?.endsWord === true;
  }

  override startsWith(prefix: string): boolean {
    return this.find(prefix) !== undefined;
  }
}
