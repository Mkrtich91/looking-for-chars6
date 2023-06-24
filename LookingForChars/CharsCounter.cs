using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string? str, char[]? chars)
        {
            if (str == null || chars == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Array.IndexOf(chars, str[i]) != -1)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "The string parameter cannot be null.");
            }

            if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars), "The characters array parameter cannot be null.");
            }

            if (startIndex < 0 || startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "The startIndex parameter is out of range.");
            }

            if (endIndex < startIndex || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "The endIndex parameter is out of range or less than startIndex.");
            }

            int count = 0;
            int index = startIndex;
            while (index <= endIndex && index < str.Length)
            {
                if (Array.IndexOf(chars, str[index]) != -1)
                {
                    count++;
                }

                index++;
            }

            return count;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex, int limit)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "The string parameter cannot be null.");
            }

            if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars), "The characters array parameter cannot be null.");
            }

            if (limit <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit), "The limit parameter must be greater than zero.");
            }

            if (startIndex < 0 || startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "The startIndex parameter is out of range.");
            }

            if (endIndex < startIndex || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "The endIndex parameter is out of range or less than startIndex.");
            }

            int count = 0;
            int index = startIndex;

            do
            {
                if (index > endIndex || index >= str.Length)
                {
                    break;
                }

                if (Array.IndexOf(chars, str[index]) != -1)
                {
                    count++;
                }

                index++;
            }
            while (count < limit);

            return count;
        }
    }
}
