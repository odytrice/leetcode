import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example and restored", () -> {
            char[][] board = {{'a', 'b'}, {'c', 'd'}};
            TestSupport.set(Arrays.asList("ab", "ac"), s.findWords(board, new String[] {"ab", "ac", "ad"}));
            TestSupport.sequence(new String[] {"ab", "cd"},
                    new String[] {new String(board[0]), new String(board[1])});
        });
        TestSupport.test("multiple paths one result", () -> TestSupport.set(Arrays.asList("aa"),
                s.findWords(new char[][] {{'a', 'a'}, {'a', 'a'}}, new String[] {"aa"})));
        TestSupport.test("prefix words and no reuse", () -> TestSupport.set(Arrays.asList("a", "ab"),
                s.findWords(new char[][] {{'a', 'b'}}, new String[] {"a", "ab", "aba"})));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
