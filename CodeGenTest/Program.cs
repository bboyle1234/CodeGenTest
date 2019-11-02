using Amadevus.RecordGenerator;
using System;

namespace CodeGenTest {

    [Record]
    sealed partial class SomeObject {
        public int SomeValue { get; }
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            var x = new SomeObject(10);
        }
    }
}
