1. What type is your List.OrderBy(x => x)? (Before you convert to back to a list)
Answer: orderedNames is an IOrderedEnumerable<string>.

2. Why does .OrderBy() return the ordered results, instead of sorting them in place like .Sort()?
Answer: LINQ queries do not modify the original collection. They return a new sequence representing the query result.

3. Explain the purpose of x => x in List.OrderBy(x => x).
Answer: Organising it alphabetically without actually sorting the list, and x=> x organise them without using the word directly.

4. What does x mean? Can I use any name? Why doesn't x have a type?
Answer: x represents one item from the list at a time. We can use any name. It does not need to have a type as C# can read the type as string from the list being made; from "List<string> names"