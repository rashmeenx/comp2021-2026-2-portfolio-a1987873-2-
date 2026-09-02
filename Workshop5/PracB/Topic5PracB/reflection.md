## How is the structure of a LinkedList<T> different from List<T>?
Answer: List<T> stores elements in order and lets us access them using an index, such as list[3]. A LinkedList<T> stores each value inside a node. Each node contains references to the previous and next nodes.

## Describe why you can't initialize a LinkedList<string> using standard List syntax: LinkedList<string> stringLinkedList = ["Why", "isn't", "it", "possible!!"];
Answer: LinkedList<T> is designed around adding nodes through methods such as AddFirst and AddLast, rather than index-based list syntax.

## Further, if the nodes are linked in a set order, why can't you just access nodes directly using e.g.LinkedList[3]?
Answer: Since LinkedList<T> uses nodes, it cannot directly use the index. It goes one by one. For LinkedList<T>, every element only know what is in their before and their after. Thus, it uses AddAfter and AddBefore. If we are trying to look for the 4th element, then it will start from a node, and move through till it reaches the final one.