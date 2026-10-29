/** O(n) time, O(1) space. Each position is reached as one digit or as a valid pair. */
class ReferenceSolution extends Solution {
    @Override
    public int numDecodings(String s) {
        // previous and current are the decodings of the prefixes ending two and one steps back.
        int previous = 1;
        // A leading zero cannot be decoded at all.
        int current = s.charAt(0) == '0' ? 0 : 1;
        for (int index = 1; index < s.length(); index += 1) {
            // A single digit only works if it is 1 to 9.
            int following = s.charAt(index) == '0' ? 0 : current;
            // A pair works if it reads 10 to 26, which also rules out a leading zero.
            int pair = (s.charAt(index - 1) - '0') * 10 + (s.charAt(index) - '0');
            if (pair >= 10 && pair <= 26) {
                following += previous;
            }
            previous = current;
            current = following;
        }
        return current;
    }
}
