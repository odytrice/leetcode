// O(n) time. Unions equal letters, then rejects any inequality inside one set.
export function equationsPossible(equations: string[]): boolean {
  // parent links each letter towards its set's root; letters are numbered 0 to 25.
  const parent = Array.from({ length: 26 }, (_, index) => index);

  const find = (node: number): number => {
    while (parent[node] !== node) {
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  // Pass 1: merge every pair of letters that must be equal.
  for (const equation of equations) {
    if (equation[1] === "=") {
      parent[find(equation.charCodeAt(0) - 97)] = find(equation.charCodeAt(3) - 97);
    }
  }
  // Pass 2: an inequality between letters in the same set is a contradiction.
  for (const equation of equations) {
    if (equation[1] === "!" && find(equation.charCodeAt(0) - 97) === find(equation.charCodeAt(3) - 97)) {
      return false;
    }
  }
  return true;
}
