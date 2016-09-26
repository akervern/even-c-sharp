using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenCSharp
{
    public class Tester
    {
        /**
         * input will be a string, but it may not have a file extension. return the file
         * extension (with no period) if it has one, otherwise null
         *
         * <param name="file">Filename as a string</param>
         * <returns>null if input is null or filename has no extension and the extension without the period otherwise.</returns>
         */
        public static String getFilenameExtension(String file)
        {
            // XXX Implement me!
            return null;
        }


        /**
         * Return the longest string contained inside the input array
         *
         * <param name="values">Input Array of values</param>
         * <returns>null if input is null and the longest string otherwise</returns>
         */
        public static String getLongestString(Object[] values)
        {
            // XXX Implement me!
            return null;
        }

        /**
         * Returns true is both arrays contains the same values
         *
         * <param name="o1">First Array to test</param>
         * <param name="o2">Second Array to test<param>
         * <returns>true if both arrays contains the same values</returns>
         */
        public static Boolean areArrayEquals(Object o1, Object o2)
        {
            // XXX Implement me!
            return false;
        }

        /**
         * Compress the input string with a very dummy algorithm : repeated letters
         * are replaced by {n}{letter} where n is the number of repetition and
         * {letter} is the letter. n must be superior to 1 (otherwise, simply output
         * the letter)
         *
         * <param name="str">The input string that can only contains letters</param>
         * <returns>The compressed String or null if the input is null</returns>
         */
        public static String compressString(String str)
        {
            // XXX Implement me!
            return null;
        }

        /**
         * Sort the input array of string based on lexicographic order of the
         * corresponding compressed string
         *
         * <param name="arr">The Array of String to sort</param>
         * <returns>The sorted array</returns>
         */
        public static String[] sortArray(String[] arr)
        {
            // XXX Implement me!
            return null;
        }
    }
}
