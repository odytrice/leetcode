import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

/** Assertions and reporting shared by the Java drills. */
public final class TestSupport {
    private static int total;
    private static int failed;

    @FunctionalInterface
    public interface Action {
        void run() throws Exception;
    }

    private TestSupport() {
    }

    public static void test(String name, Action action) {
        total++;
        try {
            action.run();
            System.out.println("PASS: " + name);
        } catch (Throwable error) {
            failed++;
            String message = error.getMessage() == null ? error.toString() : error.getMessage();
            System.out.println("FAIL: " + name + ": " + message);
        }
    }

    public static void check(boolean condition, String message) {
        if (!condition) {
            throw new AssertionError(message);
        }
    }

    public static void check(boolean condition) {
        check(condition, "Assertion failed");
    }

    public static List<Integer> ints(int... values) {
        List<Integer> list = new ArrayList<>();
        for (int value : values) {
            list.add(value);
        }
        return list;
    }

    public static void equal(long expected, long actual) {
        check(expected == actual, "Expected " + expected + ", got " + actual);
    }

    public static void equal(double expected, double actual) {
        check(Double.compare(expected, actual) == 0, "Expected " + expected + ", got " + actual);
    }

    public static void equal(boolean expected, boolean actual) {
        check(expected == actual, "Expected " + expected + ", got " + actual);
    }

    public static void equal(Object expected, Object actual) {
        check(expected == null ? actual == null : expected.equals(actual),
                "Expected " + expected + ", got " + actual);
    }

    public static void sequence(int[] expected, int[] actual) {
        check(actual != null && Arrays.equals(expected, actual),
                "Expected " + Arrays.toString(expected) + ", got " + Arrays.toString(actual));
    }

    public static void sequence(long[] expected, long[] actual) {
        check(actual != null && Arrays.equals(expected, actual),
                "Expected " + Arrays.toString(expected) + ", got " + Arrays.toString(actual));
    }

    public static void sequence(String[] expected, String[] actual) {
        check(actual != null && Arrays.equals(expected, actual),
                "Expected " + Arrays.toString(expected) + ", got " + Arrays.toString(actual));
    }

    public static <T> void sequence(List<T> expected, List<T> actual) {
        check(expected.equals(actual), "Expected " + expected + ", got " + actual);
    }

    /** Compare outer order independently, while still detecting duplicated results. */
    public static <T> void set(List<T> expected, List<T> actual) {
        List<T> left = new ArrayList<>(expected);
        List<T> right = new ArrayList<>(actual);
        left.sort((a, b) -> a.toString().compareTo(b.toString()));
        right.sort((a, b) -> a.toString().compareTo(b.toString()));
        sequence(left, right);
    }

    public static void rows(List<List<Integer>> expected, List<List<Integer>> actual) {
        rows(expected, actual, false);
    }

    public static void rows(List<List<Integer>> expected, List<List<Integer>> actual, boolean sortInside) {
        List<String> left = new ArrayList<>();
        for (List<Integer> row : expected) {
            List<Integer> copy = new ArrayList<>(row);
            if (sortInside) {
                Collections.sort(copy);
            }
            left.add(copy.toString());
        }
        List<String> right = new ArrayList<>();
        for (List<Integer> row : actual) {
            List<Integer> copy = new ArrayList<>(row);
            if (sortInside) {
                Collections.sort(copy);
            }
            right.add(copy.toString());
        }
        set(left, right);
    }

    public static void stringRows(List<List<String>> expected, List<List<String>> actual, boolean sortInside) {
        List<String> left = new ArrayList<>();
        for (List<String> row : expected) {
            List<String> copy = new ArrayList<>(row);
            if (sortInside) {
                Collections.sort(copy);
            }
            left.add(copy.toString());
        }
        List<String> right = new ArrayList<>();
        for (List<String> row : actual) {
            List<String> copy = new ArrayList<>(row);
            if (sortInside) {
                Collections.sort(copy);
            }
            right.add(copy.toString());
        }
        set(left, right);
    }

    public static int finish() {
        System.out.println("\n" + (total - failed) + "/" + total + " passed.");
        return failed == 0 ? 0 : 1;
    }
}
