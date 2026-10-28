import java.util.HashMap;
import java.util.Map;

/** O(word length) per operation. Each node maps letters and records word ends. */
class ReferenceSolution extends Trie {
    private static final class Node {
        private final Map<Character, Node> children = new HashMap<>();
        private boolean endsWord;
    }

    private final Node root = new Node();

    @Override
    public void insert(String word) {
        Node node = root;
        for (char letter : word.toCharArray()) {
            node = node.children.computeIfAbsent(letter, key -> new Node());
        }
        node.endsWord = true;
    }

    private Node find(String text) {
        Node node = root;
        for (char letter : text.toCharArray()) {
            node = node.children.get(letter);
            if (node == null) {
                return null;
            }
        }
        return node;
    }

    @Override
    public boolean search(String word) {
        Node node = find(word);
        return node != null && node.endsWord;
    }

    @Override
    public boolean startsWith(String prefix) {
        return find(prefix) != null;
    }
}
