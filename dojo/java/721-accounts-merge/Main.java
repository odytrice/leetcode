import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        Solution s = reference ? new ReferenceSolution() : new Solution();

        TestSupport.test("transitive merge", () -> TestSupport.stringRows(
                List.of(List.of("John", "a@x", "b@x", "c@x")),
                s.accountsMerge(List.of(List.of("John", "a@x"), List.of("John", "b@x", "c@x"),
                        List.of("John", "a@x", "b@x"))), false));
        TestSupport.test("same name distinct people", () -> TestSupport.stringRows(
                List.of(List.of("John", "a@x"), List.of("John", "b@x")),
                s.accountsMerge(List.of(List.of("John", "a@x"), List.of("John", "b@x"))), false));
        TestSupport.test("sorted and deduplicated", () -> TestSupport.stringRows(
                List.of(List.of("Mary", "a@x", "z@x")),
                s.accountsMerge(List.of(List.of("Mary", "z@x", "a@x", "z@x"))), false));
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
