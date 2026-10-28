import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.Supplier<MedianFinder> make =
                () -> reference ? new ReferenceSolution() : new MedianFinder();

        TestSupport.test("example", () -> {
            MedianFinder finder = make.get();
            finder.addNum(1);
            finder.addNum(2);
            TestSupport.equal(1.5, finder.findMedian());
            finder.addNum(3);
            TestSupport.equal(2.0, finder.findMedian());
        });
        TestSupport.test("negative values", () -> {
            MedianFinder finder = make.get();
            finder.addNum(-1);
            finder.addNum(-2);
            TestSupport.equal(-1.5, finder.findMedian());
            finder.addNum(-3);
            TestSupport.equal(-2.0, finder.findMedian());
        });
        TestSupport.test("duplicates", () -> {
            MedianFinder finder = make.get();
            for (int index = 0; index < 8; index++) {
                finder.addNum(7);
                TestSupport.equal(7.0, finder.findMedian());
            }
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
