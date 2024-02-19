
using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExamples
{
    class Program
    {
        static void Main()
        {
            // Sample data
            IEnumerable<int> data = new List<int> { 1, 2, 3, 4, 5 };

            // Aggregate - Applies an accumulator function over a sequence.
            int aggregate = data.Aggregate((a, b) => a * b);
            Console.WriteLine($"Aggregate: {aggregate}");

            // All - Determines whether all elements of a sequence satisfy a condition.
            bool all = data.All(x => x > 0);
            Console.WriteLine($"All: {all}");

            // Any - Determines whether any element of a sequence satisfies a condition.
            bool any = data.Any(x => x > 5);
            Console.WriteLine($"Any: {any}");

            // Append - Appends a value to the end of the sequence.
            IEnumerable<int> append = data.Append(6);
            Console.WriteLine($"Append: {string.Join(", ", append)}");

            // Average - Computes the average of a sequence of numeric values.
            double average = data.Average();
            Console.WriteLine($"Average: {average}");

            // Concat - Concatenates two sequences.
            IEnumerable<int> concat = data.Concat(new[] { 6, 7, 8 });
            Console.WriteLine($"Concat: {string.Join(", ", concat)}");

            // Contains - Determines whether a sequence contains a specified element.
            bool contains = data.Contains(3);
            Console.WriteLine($"Contains: {contains}");

            // Count - Returns the number of elements in a sequence.
            int count = data.Count();
            Console.WriteLine($"Count: {count}");

            // DefaultIfEmpty - Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.
            IEnumerable<int> defaultIfEmpty = new int[0].DefaultIfEmpty();
            Console.WriteLine($"DefaultIfEmpty: {string.Join(", ", defaultIfEmpty)}");

            // Distinct - Returns distinct elements from a sequence.
            IEnumerable<int> distinct = new[] { 1, 2, 2, 3, 3, 3 }.Distinct();
            Console.WriteLine($"Distinct: {string.Join(", ", distinct)}");

            // ElementAt - Returns the element at a specified index in a sequence.
            int elementAt = data.ElementAt(2);
            Console.WriteLine($"ElementAt: {elementAt}");

            // ElementAtOrDefault - Returns the element at a specified index in a sequence or a default value if the index is out of range.
            int elementAtOrDefault = data.ElementAtOrDefault(5);
            Console.WriteLine($"ElementAtOrDefault: {elementAtOrDefault}");

            // Except - Produces the set difference of two sequences.
            IEnumerable<int> except = data.Except(new[] { 1, 2 });
            Console.WriteLine($"Except: {string.Join(", ", except)}");

            // First - Returns the first element of a sequence.
            int first = data.First();
            Console.WriteLine($"First: {first}");

            // FirstOrDefault - Returns the first element of a sequence, or a default value if no element is found.
            int firstOrDefault = data.FirstOrDefault(x => x > 5);
            Console.WriteLine($"FirstOrDefault: {firstOrDefault}");

            // GroupBy - Groups the elements of a sequence.
            var groupBy = data.GroupBy(x => x % 2 == 0);
            foreach (var group in groupBy)
            {
                Console.WriteLine($"GroupBy (Even: {group.Key}): {string.Join(", ", group)}");
            }

            // Intersect - Produces the set intersection of two sequences.
            IEnumerable<int> intersect = data.Intersect(new[] { 2, 4, 6 });
            Console.WriteLine($"Intersect: {string.Join(", ", intersect)}");

            // Last - Returns the last element of a sequence.
            int last = data.Last();
            Console.WriteLine($"Last: {last}");

            // LastOrDefault - Returns the last element of a sequence, or a default value if no element is found.
            int lastOrDefault = data.LastOrDefault(x => x > 5);
            Console.WriteLine($"LastOrDefault: {lastOrDefault}");

            // LongCount - Returns the number of elements in a sequence as a long integer.
            long longCount = data.LongCount();
            Console.WriteLine($"LongCount: {longCount}");

            // Max - Returns the maximum value in a sequence of values.
            int max = data.Max();
            Console.WriteLine($"Max: {max}");

            // Min - Returns the minimum value in a sequence of values.
            int min = data.Min();
            Console.WriteLine($"Min: {min}");

            // OrderBy - Sorts the elements of a sequence in ascending order.
            IEnumerable<int> orderBy = data.OrderBy(x => -x);
            Console.WriteLine($"OrderBy: {string.Join(", ", orderBy)}");

            // Prepend - Prepends a value to the beginning of the sequence.
            IEnumerable<int> prepend = data.Prepend(0);
            Console.WriteLine($"Prepend: {string.Join(", ", prepend)}");

            // Reverse - Reverses the order of the elements in a sequence.
            IEnumerable<int> reverse = data.Reverse();
            Console.WriteLine($"Reverse: {string.Join(", ", reverse)}");

            // Select - Projects each element of a sequence into a new form.
            IEnumerable<int> select = data.Select(x => x * 2);
            Console.WriteLine($"Select: {string.Join(", ", select)}");

            // SequenceEqual - Determines whether two sequences are equal by comparing their elements by using a specified comparer.
            bool sequenceEqual = data.SequenceEqual(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"SequenceEqual: {sequenceEqual}");

            // Single - Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
            int single = new[] { 1 }.Single();
            Console.WriteLine($"Single: {single}");

            // Skip - Bypasses a specified number of elements in a sequence and then returns the remaining elements.
            IEnumerable<int> skip = data.Skip(2);
            Console.WriteLine($"Skip: {string.Join(", ", skip)}");

            // Sum - Computes the sum of a sequence of numeric values.
            int sum = data.Sum();
            Console.WriteLine($"Sum: {sum}");

            // Take - Returns a specified number of contiguous elements from the start of a sequence.
            IEnumerable<int> take = data.Take(2);
            Console.WriteLine($"Take: {string.Join(", ", take)}");

            // SkipLast - Bypasses a specified number of elements at the end of a sequence.
            IEnumerable<int> skipLast = data.SkipLast(2);
            Console.WriteLine($"SkipLast: {string.Join(", ", skipLast)}");

            // SkipWhile - Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
            IEnumerable<int> skipWhile = data.SkipWhile(x => x < 3);
            Console.WriteLine($"SkipWhile: {string.Join(", ", skipWhile)}");

            // TakeLast - Returns a specified number of contiguous elements from the end of a sequence.
            IEnumerable<int> takeLast = data.TakeLast(2);
            Console.WriteLine($"TakeLast: {string.Join(", ", takeLast)}");

            // TakeWhile - Returns elements from a sequence as long as a specified condition is true.
            IEnumerable<int> takeWhile = data.TakeWhile(x => x < 3);
            Console.WriteLine($"TakeWhile: {string.Join(", ", takeWhile)}");

            // ThenBy - Performs a subsequent ordering of the elements in a sequence in ascending order according to a key.
            var thenBy = data.OrderBy(x => x % 2).ThenBy(x => x);
            Console.WriteLine($"ThenBy: {string.Join(", ", thenBy)}");

            // ToArray - Creates an array from a sequence.
            int[] toArray = data.ToArray();
            Console.WriteLine($"ToArray: {string.Join(", ", toArray)}");

            // ToDictionary - Creates a Dictionary<TKey,TValue> from an IEnumerable<T> according to a specified key selector function.
            Dictionary<int, int> toDictionary = data.ToDictionary(x => x, x => x * 10);
            Console.WriteLine("ToDictionary:");
            foreach (var kvp in toDictionary)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
            }

            // ToList - Creates a List<T> from an IEnumerable<T>.
            List<int> toList = data.ToList();
            Console.WriteLine($"ToList: {string.Join(", ", toList)}");

            // ToLookup - Creates a Lookup<TKey,TElement> from an IEnumerable<T> according to a specified key selector function.
            var toLookup = data.ToLookup(x => x % 2);
            Console.WriteLine("ToLookup:");
            foreach (var group in toLookup)
            {
                Console.WriteLine($"  {(group.Key == 0 ? "Even" : "Odd")}: {string.Join(", ", group)}");
            }

            // Union - Produces the set union of two sequences.
            IEnumerable<int> union = data.Union(new[] { 6, 7, 8 });
            Console.WriteLine($"Union: {string.Join(", ", union)}");

            // Where - Filters a sequence of values based on a predicate.
            IEnumerable<int> where = data.Where(x => x > 2);
            Console.WriteLine($"Where: {string.Join(", ", where)}");

            // Zip - Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.
            IEnumerable<(int, int)> zip = data.Zip(new[] { 6, 7, 8 }, (a, b) => (a, b));
            Console.WriteLine("Zip:");
            foreach (var pair in zip)
            {
                Console.WriteLine($"  ({pair.Item1}, {pair.Item2})");
            }
        }
    }


}
