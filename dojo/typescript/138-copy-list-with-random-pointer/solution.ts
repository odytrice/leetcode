export class RandomNode {
  val: number;
  next: RandomNode | null;
  random: RandomNode | null;

  constructor(val = 0, next: RandomNode | null = null, random: RandomNode | null = null) {
    this.val = val;
    this.next = next;
    this.random = random;
  }
}

export function copyRandomList(head: RandomNode | null): RandomNode | null {
  throw new Error("TODO: implement copyRandomList");
}
