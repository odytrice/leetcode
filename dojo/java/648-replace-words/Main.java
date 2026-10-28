import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.equal("the cat was rat by the bat",
                s.replaceWords(List.of("cat", "bat", "rat"), "the cattle was rattled by the battery")));
        TestSupport.test("shortest root",
                () -> TestSupport.equal("a a b", s.replaceWords(List.of("aaa", "a", "aa"), "aaaa aa b")));
        TestSupport.test("exact and absent",
                () -> TestSupport.equal("cat dog", s.replaceWords(List.of("cat"), "cat dog")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
