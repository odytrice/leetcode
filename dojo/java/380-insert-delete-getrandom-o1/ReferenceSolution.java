import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Random;

/** O(1) average for every operation: swap the removal target with the last value. */
class ReferenceSolution extends RandomizedSet {
    // values allows random picks by index; positions maps each value to its index in values.
    private final List<Integer> values = new ArrayList<>();
    private final Map<Integer, Integer> positions = new HashMap<>();
    private final Random random = new Random();

    @Override
    public boolean insert(int val) {
        // A set holds each value once, so report that nothing was added.
        if (positions.containsKey(val)) {
            return false;
        }
        positions.put(val, values.size());
        values.add(val);
        return true;
    }

    @Override
    public boolean remove(int val) {
        Integer position = positions.get(val);
        if (position == null) {
            return false;
        }
        // Move the last value into the hole, since removing from the end of a list is O(1).
        int last = values.get(values.size() - 1);
        values.set(position, last);
        positions.put(last, position);
        values.remove(values.size() - 1);
        // Remove val's entry last, in case val was itself the last value.
        positions.remove(val);
        return true;
    }

    @Override
    public int getRandom() {
        return values.get(random.nextInt(values.size()));
    }
}
