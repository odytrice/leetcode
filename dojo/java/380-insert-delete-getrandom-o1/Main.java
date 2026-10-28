import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.Supplier<RandomizedSet> make =
                () -> reference ? new ReferenceSolution() : new RandomizedSet();

        TestSupport.test("insert and remove", () -> {
            RandomizedSet values = make.get();
            TestSupport.equal(true, values.insert(1));
            TestSupport.equal(false, values.insert(1));
            TestSupport.equal(false, values.remove(2));
            TestSupport.equal(true, values.remove(1));
            TestSupport.equal(false, values.remove(1));
        });
        TestSupport.test("swap removal", () -> {
            RandomizedSet values = make.get();
            values.insert(10);
            values.insert(20);
            values.insert(30);
            values.remove(20);
            TestSupport.equal(true, values.remove(30));
            TestSupport.equal(10, values.getRandom());
        });
        TestSupport.test("random membership", () -> {
            RandomizedSet values = make.get();
            values.insert(-1);
            values.insert(2);
            values.insert(3);
            values.remove(2);
            for (int i = 0; i < 200; i++) {
                int value = values.getRandom();
                TestSupport.check(value == -1 || value == 3, "unexpected value " + value);
            }
        });
        TestSupport.test("reinsert", () -> {
            RandomizedSet values = make.get();
            values.insert(7);
            values.remove(7);
            TestSupport.equal(true, values.insert(7));
            TestSupport.equal(7, values.getRandom());
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
