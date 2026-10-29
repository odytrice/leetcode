// O(n) time. Pushes operands; each operator consumes the last two.
export function evalRPN(tokens: string[]): number {
  const stack: number[] = [];
  for (const token of tokens) {
    if (["+", "-", "*", "/"].includes(token)) {
      // The right operand was pushed last, so it comes off first.
      const right = stack.pop() as number;
      const left = stack.pop() as number;
      if (token === "+") {
        stack.push(left + right);
      } else if (token === "-") {
        stack.push(left - right);
      } else if (token === "*") {
        stack.push(left * right);
      } else {
        // Division truncates toward zero, as the problem requires.
        stack.push(Math.trunc(left / right));
      }
    } else {
      stack.push(Number(token));
    }
  }
  // A valid expression leaves exactly one value: the result.
  return stack[0];
}
