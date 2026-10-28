import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Random;

/** O(1) average for every operation: swap the removal target with the last value. */
class ReferenceSolution extends RandomizedSet {
    private final List<Integer> values = new ArrayList<>();
    private final Map<Integer, Integer> positions = new HashMap<>();
    private final Random random = new Random();

    @Override
    public boolean insert(int val) {
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
        int last = values.get(values.size() - 1);
        values.set(position, last);
        positions.put(last, position);
        values.remove(values.size() - 1);
        positions.remove(val);
        return true;
    }

    @Override
    public int getRandom() {
        return values.get(random.nextInt(values.size()));
    }
}
