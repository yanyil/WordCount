using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;

namespace WordCount
{
    [TestFixture]
    public class BookInfoTest
    {
        [Test]
        public void Output_Book_Info()
        {
            TextWriter originalConsole = Console.Out;

            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                var baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var filePath = baseDir + "/TestData/test.txt";

                BookInfo.Main(new string[] { filePath });

                var expected = "a 1\n" +
                               "text 1\n" +
                               "file 1\n" +
                               "for 1\n" +
                               "testing 2" +
                               Environment.NewLine;

                Assert.That(writer.ToString(), Is.EqualTo(expected));
            }

            Console.SetOut(originalConsole);
        }
    }
}
