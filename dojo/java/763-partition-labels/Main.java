import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("example", () -> TestSupport.sequence(TestSupport.ints(9, 7, 8),
                s.partitionLabels("ababcbacadefegdehijhklij")));
        TestSupport.test("one part",
                () -> TestSupport.sequence(TestSupport.ints(10), s.partitionLabels("eccbbbbdec")));
        TestSupport.test("distinct", () -> TestSupport.sequence(TestSupport.ints(1, 1, 1), s.partitionLabels("abc")));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
