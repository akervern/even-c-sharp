using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenCSharp
{
    [TestClass]
    public class TesterSpecs
    {
        Tester tester = new Tester();

        [TestMethod]
        public void getFilenameExtension()
        {
            var inputs = new String[] { "somfile.dat", "nothing", "movie.torrent", "bla.hello.ascii", ".htaccess", "empty.", null };
            var expected = new String[] { "dat", null, "torrent", "ascii", "htaccess", "", null };

            CollectionAssert.AreEqual(expected, Enumerable.Select<string, string>(inputs, input => Tester.getFilenameExtension(input)).ToArray());
        }

        [TestMethod]
        public void getLongestString()
        {
            var inputs = new Object[][]
            {
                new Object[] {"a", "ab", "abc"},
                new Object[] {"abc", "ab", "a"},
                new Object[] {"a", null, "tiny"},
                new Object[] {"a", 12355, "abc"},
                new Object[] {"a", new String[] { "4", "2", "rewq" },  "abc"},
                new Object[] {"a", new String[] { null }, "abc"},
                new Object[] {null, new String[] { null }, 1}
            };

            var expected = new String[]
            {
                "abc", "abc", "tiny", "abc", "rewq", "abc", null
            };

            CollectionAssert.AreEqual(expected, Enumerable.Select<Object[], string>(inputs, input => Tester.getLongestString(input)).ToArray());
        }

        [TestMethod]
        public void areArrayEquals()
        {
            Assert.IsTrue(Tester.areArrayEquals(new String[] { }, new String[] { }));
            Assert.IsFalse(Tester.areArrayEquals(null, new String[] { null }));
            Assert.IsTrue(Tester.areArrayEquals(new String[] { "a", "b", "c" }, new String[] {"a", "b", "c" }));
            Assert.IsFalse(Tester.areArrayEquals(new String[] { "a", "b", "c" }, new String[] {"ab", null, "c" }));
            Assert.IsFalse(Tester.areArrayEquals(new String[] { "1", "2", "3" }, new Int32[] { 1, 2, 3 }));
            Assert.IsFalse(Tester.areArrayEquals(new String[] { "a", null, "c" }, new String[] { "a", "c" }));
            Assert.IsTrue(Tester.areArrayEquals(new Object[] { null, new String[] { "a", "b" } }, new Object[] { null, new String[] { "a", "b" } }));
            Assert.IsFalse(Tester.areArrayEquals(new Object[] { null, new String[] { "a", "b" } }, new String[] { null, "a", "b"}));
        }

        [TestMethod]
        public void getCompressedString()
        {
            var inputs = new String[] { "abc", "aaaaabbbc", null, "abccccc", "aaaaaaaabb"};
            var expected = new String[] {"abc", "5a3bc", null, "ab5c", "8a2b"};

            CollectionAssert.AreEqual(expected, Enumerable.Select<string, string>(inputs, input => Tester.compressString(input)).ToArray());
        }

        [TestMethod]
        public void getSortedArray()
        {
            var inputs = new String[][]
            {
                new String[] {"a", "ab", "abc"},
                new String[] {"abc", "ab", "a"},
                new String[] {"abc", "aab", "abbb"},
                new String[] {"abc", "acc", "ab" },
                new String[] {"aaaa", "aaab", "ab"} 
            };

            var expected = new String[][]
            {
                new String[] {"a", "ab", "abc"},
                new String[] {"a", "ab", "abc"},
                new String[] {"aab", "abbb", "abc"},
                new String[] {"acc", "ab", "abc" },
                new String[] {"aaab", "aaaa", "ab"}
            };

            CollectionAssert.AreEqual(expected, Enumerable.Select<string[], string[]>(inputs, input => Tester.sortArray(input)).ToArray());
        }
    }
}
