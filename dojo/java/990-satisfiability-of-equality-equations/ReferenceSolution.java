/** O(n) time. Unions equal letters, then rejects any inequality inside one set. */
class ReferenceSolution extends Solution {
    // parent[x] points toward letter x's set representative; a root points to itself.
    private final int[] parent = new int[26];

    @Override
    public boolean equationsPossible(String[] equations) {
        for (int letter = 0; letter < 26; letter += 1) {
            parent[letter] = letter;
        }
        // Pass 1: merge the sets of every pair declared equal ("a==b" has '=' at index 1).
        for (String equation : equations) {
            if (equation.charAt(1) == '=') {
                parent[find(equation.charAt(0) - 'a')] = find(equation.charAt(3) - 'a');
            }
        }
        // Pass 2: an inequality between two letters in the same set is a contradiction.
        for (String equation : equations) {
            if (equation.charAt(1) == '!'
                    && find(equation.charAt(0) - 'a') == find(equation.charAt(3) - 'a')) {
                return false;
            }
        }
        return true;
    }

    private int find(int node) {
        while (parent[node] != node) {
            // Path halving: point at the grandparent so later lookups are shorter.
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}
