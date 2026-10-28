// O(n) time. Unions equal letters, then rejects any inequality inside one set.
export function equationsPossible(equations: string[]): boolean {
  const parent = Array.from({ length: 26 }, (_, index) => index);

  const find = (node: number): number => {
    while (parent[node] !== node) {
      parent[node] = parent[parent[node]];
      node = parent[node];
    }
    return node;
  };

  for (const equation of equations) {
    if (equation[1] === "=") {
      parent[find(equation.charCodeAt(0) - 97)] = find(equation.charCodeAt(3) - 97);
    }
  }
  for (const equation of equations) {
    if (equation[1] === "!" && find(equation.charCodeAt(0) - 97) === find(equation.charCodeAt(3) - 97)) {
      return false;
    }
  }
  return true;
}
