public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        var waitingDays = new Stack<int>();

        for (int today = 0; today < temperatures.Length; today++)
        {
            // Today resolves every waiting day at the top that is cooler.
            while (waitingDays.Count > 0
                && temperatures[today] > temperatures[waitingDays.Peek()])
            {
                int earlierDay = waitingDays.Pop();
                answer[earlierDay] = today - earlierDay;
            }

            // Today must now wait for its own warmer day.
            waitingDays.Push(today);
        }

        // Days still waiting have no warmer day ahead; their answers stay 0.
        return answer;
    }
}
