import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. A monotonic stack holds days still waiting for a warmer day. */
class ReferenceSolution extends Solution {
    @Override
    public int[] dailyTemperatures(int[] temperatures) {
        int[] answer = new int[temperatures.length];
        Deque<Integer> waiting = new ArrayDeque<>();
        for (int today = 0; today < temperatures.length; today += 1) {
            while (!waiting.isEmpty() && temperatures[waiting.peek()] < temperatures[today]) {
                int earlier = waiting.pop();
                answer[earlier] = today - earlier;
            }
            waiting.push(today);
        }
        return answer;
    }
}
