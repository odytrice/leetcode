import java.util.HashMap;
import java.util.Map;

/** O(word length) insert, branching search for '.'. Exact length is required. */
class ReferenceSolution extends WordDictionary {
    private static final class Node {
        private final Map<Character, Node> children = new HashMap<>();
        // True when an added word ends exactly at this node.
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

    // Returns true if word[index..] can be matched starting from node.
    private boolean match(Node node, String word, int index) {
        // All letters are used up; it only counts if a word ends here.
        if (index == word.length()) {
            return node.endsWord;
        }
        char letter = word.charAt(index);
        // A wildcard may stand for any letter, so try every child.
        if (letter == '.') {
            for (Node child : node.children.values()) {
                if (match(child, word, index + 1)) {
                    return true;
                }
            }
            return false;
        }
        // A normal letter has only one possible child to follow.
        Node child = node.children.get(letter);
        return child != null && match(child, word, index + 1);
    }

    @Override
    public boolean search(String word) {
        return match(root, word, 0);
    }
}
