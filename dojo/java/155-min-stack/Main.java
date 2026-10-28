import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        boolean reference = Arrays.asList(args).contains("--reference");
        java.util.function.Supplier<MinStack> make =
                () -> reference ? new ReferenceSolution() : new MinStack();

        TestSupport.test("example", () -> {
            MinStack stack = make.get();
            stack.push(-2);
            stack.push(0);
            stack.push(-3);
            TestSupport.equal(-3, stack.getMin());
            stack.pop();
            TestSupport.equal(0, stack.top());
            TestSupport.equal(-2, stack.getMin());
        });
        TestSupport.test("duplicate minimum", () -> {
            MinStack stack = make.get();
            stack.push(1);
            stack.push(1);
            stack.pop();
            TestSupport.equal(1, stack.getMin());
        });
        TestSupport.test("int limits", () -> {
            MinStack stack = make.get();
            stack.push(Integer.MIN_VALUE);
            stack.push(Integer.MAX_VALUE);
            TestSupport.equal(Integer.MIN_VALUE, stack.getMin());
            TestSupport.equal(Integer.MAX_VALUE, stack.top());
        });
        // Add your own cases here.

        System.exit(TestSupport.finish());
    }
}
