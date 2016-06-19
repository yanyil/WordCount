using NUnit.Framework;
using System;
using System.IO;
using System.Reflection;

namespace WordCount
{
    [TestFixture]
    public class BookInfoTest
    {
        static readonly Assembly assembly = Assembly.GetExecutingAssembly();
        static readonly string baseDir = Path.GetDirectoryName(assembly.Location);

        [TearDown]
        public void Cleanup()
        {
            var fileOut = baseDir + "/TestData/temp.txt";

            if (File.Exists(fileOut))
            {
                try
                {
                    File.Delete(fileOut);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        [Test]
        public void Output_Book_Info_To_File()
        {
            var fileIn = baseDir + "/TestData/test.txt";
            var fileOut = baseDir + "/TestData/temp.txt";

            BookInfo.OutputToFile(fileIn, fileOut);

            var text = File.ReadAllText(fileOut);

            var expected = "a 1 \n" +
                           "text 1 \n" +
                           "file 1 \n" +
                           "for 1 \n" +
                           "testing 2 prime" +
                           Environment.NewLine;

            Assert.That(text, Is.EqualTo(expected));
        }
    }
}
