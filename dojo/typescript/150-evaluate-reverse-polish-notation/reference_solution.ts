// O(n) time. Pushes operands; each operator consumes the last two.
export function evalRPN(tokens: string[]): number {
  const stack: number[] = [];
  for (const token of tokens) {
    if (["+", "-", "*", "/"].includes(token)) {
      const right = stack.pop() as number;
      const left = stack.pop() as number;
      if (token === "+") {
        stack.push(left + right);
      } else if (token === "-") {
        stack.push(left - right);
      } else if (token === "*") {
        stack.push(left * right);
      } else {
        stack.push(Math.trunc(left / right));
      }
    } else {
      stack.push(Number(token));
    }
  }
  return stack[0];
}
