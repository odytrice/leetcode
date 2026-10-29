/** O(output length) time. Recursive parse of one bracketed level. */
class ReferenceSolution extends Solution {
    private final int[] position = {0};

    @Override
    public String decodeString(String s) {
        position[0] = 0;
        return parse(s);
    }

    private String parse(String s) {
        StringBuilder text = new StringBuilder();
        while (position[0] < s.length() && s.charAt(position[0]) != ']') {
            char current = s.charAt(position[0]);
            if (!Character.isDigit(current)) {
                text.append(current);
                position[0] += 1;
                continue;
            }
            int count = 0;
            while (position[0] < s.length() && Character.isDigit(s.charAt(position[0]))) {
                count = count * 10 + (s.charAt(position[0]) - '0');
                position[0] += 1;
            }
            position[0] += 1;
            String inner = parse(s);
            position[0] += 1;
            text.append(inner.repeat(count));
        }
        return text.toString();
    }
}
