using System;
using System.Collections.Generic;

namespace Permutacja
{
    /// <summary>
    /// Utility which helps with permutations.
    /// </summary>
    public class Permutations
    {
        /// <summary>
        /// Returns list of permutations. Function is recursive.
        /// </summary>
        /// <param name="length">Of rows.</param>
        /// <param name="set">Set of avaible elements.</param>
        /// <param name="result">Result from last function call.</param>
        /// <param name="count">Count of iterations (includs all iterations from "for" loops).</param>
        /// <returns></returns>
        public List<string> GetPermutationsList(int length, List<string> set, List<string> result = null, int count = 0)
        {
            // First function call
            if (result == null)
            {
                result = new List<string>();
                count = 0;
                for (var i = 0; i < set.Count; i++)
                {
                    count++;
                    if (!result.Contains(set[i]))
                    {
                        result.Add(set[i]);
                    }
                }
                GetPermutationsList(length, set, result, count);
            }

            // Last function call
            if (result[0].Length == length)
            {
                Memory.Count = count;
                return result;
            }
            // Standard function call
            var newResult = new List<string>();
            for (var i = 0; i < result.Count; i++)
            {
                for (var j = 0; j < set.Count; j++)
                {
                    count++;
                    var newValue = result[i] + set[j];
                    if (!newResult.Contains(newValue))
                    {
                        newResult.Add(newValue);
                    }
                }
            }
            // Pass value to next function call and return result at the end.
            return GetPermutationsList(length, set, newResult, count);
        }
    }
}