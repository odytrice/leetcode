/** O(n) time. Unions equal letters, then rejects any inequality inside one set. */
class ReferenceSolution extends Solution {
    private final int[] parent = new int[26];

    @Override
    public boolean equationsPossible(String[] equations) {
        for (int letter = 0; letter < 26; letter += 1) {
            parent[letter] = letter;
        }
        for (String equation : equations) {
            if (equation.charAt(1) == '=') {
                parent[find(equation.charAt(0) - 'a')] = find(equation.charAt(3) - 'a');
            }
        }
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
            parent[node] = parent[parent[node]];
            node = parent[node];
        }
        return node;
    }
}
