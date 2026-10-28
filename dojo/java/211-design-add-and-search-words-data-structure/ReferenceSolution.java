import java.util.HashMap;
import java.util.Map;

/** O(word length) insert, branching search for '.'. Exact length is required. */
class ReferenceSolution extends WordDictionary {
    private static final class Node {
        private final Map<Character, Node> children = new HashMap<>();
        private boolean endsWord;
    }

    private final Node root = new Node();

    @Override
    public void addWord(String word) {
        Node node = root;
        for (char letter : word.toCharArray()) {
            node = node.children.computeIfAbsent(letter, key -> new Node());
        }
        node.endsWord = true;
    }

    private boolean match(Node node, String word, int index) {
        if (index == word.length()) {
            return node.endsWord;
        }
        char letter = word.charAt(index);
        if (letter == '.') {
            for (Node child : node.children.values()) {
                if (match(child, word, index + 1)) {
                    return true;
                }
            }
            return false;
        }
        Node child = node.children.get(letter);
        return child != null && match(child, word, index + 1);
    }

    @Override
    public boolean search(String word) {
        return match(root, word, 0);
    }
}
