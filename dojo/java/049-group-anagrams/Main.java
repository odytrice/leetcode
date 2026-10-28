import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = java.util.Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.stringRows(
                List.of(List.of("eat", "tea", "ate"), List.of("tan", "nat"), List.of("bat")),
                s.groupAnagrams(new String[] {"eat", "tea", "tan", "ate", "nat", "bat"}), true));
        TestSupport.test("empty strings", () -> TestSupport.stringRows(
                List.of(List.of("", "")), s.groupAnagrams(new String[] {"", ""}), true));
        TestSupport.test("letter counts", () -> TestSupport.stringRows(
                List.of(List.of("ab", "ba"), List.of("aab")),
                s.groupAnagrams(new String[] {"ab", "aab", "ba"}), true));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
