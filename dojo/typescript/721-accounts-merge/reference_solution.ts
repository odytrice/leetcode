// O(total emails log total emails) time. Unions accounts that share an email.
export function accountsMerge(accounts: string[][]): string[][] {
  // parent links each account index towards the root account of its group.
  const parent = Array.from({ length: accounts.length }, (_, index) => index);

  const find = (node: number): number => {
    while (parent[node] !== node) {
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  // owner maps each email to the first account that listed it.
  const owner = new Map<string, number>();
  accounts.forEach((account, index) => {
    for (const email of account.slice(1)) {
      const first = owner.get(email);
      if (first === undefined) {
        owner.set(email, index);
      } else {
        // A shared email means both accounts belong to the same person.
        parent[find(index)] = find(first);
      }
    }
  });

  // Gather every email under the root account of its group.
  const groups = new Map<number, string[]>();
  for (const [email, index] of owner) {
    const root = find(index);
    const group = groups.get(root);
    if (group) {
      group.push(email);
    } else {
      groups.set(root, [email]);
    }
  }

  const result: string[][] = [];
  for (const [root, emails] of groups) {
    // The root account supplies the name; emails are sorted as the output requires.
    result.push([accounts[root][0], ...emails.sort()]);
  }
  return result;
}
