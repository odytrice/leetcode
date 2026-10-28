import { Trie } from "./solution.ts";

class Node {
  readonly children = new Map<string, Node>();
  endsWord = false;
}

// O(word length) per operation. Each node maps letters and records word ends.
export class ReferenceSolution extends Trie {
  private readonly root = new Node();

  override insert(word: string): void {
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

  private find(text: string): Node | undefined {
    let node: Node | undefined = this.root;
    for (const char of text) {
      node = node.children.get(char);
      if (node === undefined) return undefined;
    }
    return node;
  }

  override search(word: string): boolean {
    return this.find(word)?.endsWord === true;
  }

  override startsWith(prefix: string): boolean {
    return this.find(prefix) !== undefined;
  }
}
