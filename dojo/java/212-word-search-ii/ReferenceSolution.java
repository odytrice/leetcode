import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/** O(cells * 4^depth) time. Searches once over a trie of all words. */
class ReferenceSolution extends Solution {
    private static final class Node {
        private final Map<Character, Node> children = new HashMap<>();
        private String word;
    }

    private char[][] board;
    private int rows;
    private int columns;
    private List<String> result;

    @Override
    public List<String> findWords(char[][] board, String[] words) {
        Node root = new Node();
        for (String word : words) {
            Node node = root;
            for (char letter : word.toCharArray()) {
                node = node.children.computeIfAbsent(letter, key -> new Node());
            }
            node.word = word;
        }

        this.board = board;
        rows = board.length;
        columns = board[0].length;
        result = new ArrayList<>();
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {
                search(row, column, root);
            }
        }
        return result;
    }

    private void search(int row, int column, Node node) {
        if (row < 0 || column < 0 || row >= rows || column >= columns) {
            return;
        }
        char letter = board[row][column];
        Node child = node.children.get(letter);
        if (child == null) {
            return;
        }
        if (child.word != null) {
            result.add(child.word);
            child.word = null;
        }
        board[row][column] = '\0';
        search(row - 1, column, child);
        search(row + 1, column, child);
        search(row, column - 1, child);
        search(row, column + 1, child);
        board[row][column] = letter;
    }
}
