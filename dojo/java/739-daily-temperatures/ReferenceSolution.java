import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. A monotonic stack holds days still waiting for a warmer day. */
class ReferenceSolution extends Solution {
    @Override
    public int[] dailyTemperatures(int[] temperatures) {
        // Days that never find a warmer day keep the default answer of 0.
        int[] answer = new int[temperatures.length];
        // Indexes of waiting days; their temperatures never increase from bottom to top.
        Deque<Integer> waiting = new ArrayDeque<>();
        for (int today = 0; today < temperatures.length; today += 1) {
            // Today is the first warmer day for every cooler day on top of the stack.
            while (!waiting.isEmpty() && temperatures[waiting.peek()] < temperatures[today]) {
                int earlier = waiting.pop();
                answer[earlier] = today - earlier;
            }
            waiting.push(today);
        }
        return answer;
    }
}
