import React from "react";

interface Props {
  init?: number;
}

export function Counter({init = 42}: Props) {
  const [count, setCount] = React.useState(init);
  return (
    <div>
      <h1>Counter: {count}</h1>
      <button onClick={() => setCount(count + 1)}>Increment</button>
      <button onClick={() => setCount(count - 1)}>Decrement</button>
    </div>
  );
}
