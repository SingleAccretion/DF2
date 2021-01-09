using System;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Ultz.DF2.Tests
{
    public class UnitTest1
    {
        public readonly ITestOutputHelper Out;
        [Fact] public void CanWriteAndRecoverByte() { const byte testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsByte(), testData); } [Fact] public void CanWriteAndRecoverByteRepeatedly() {} [Fact] public void CanWriteAndRecoverByteWithinGroup() {} [Fact] public void CanWriteAndRecoverByteWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverSByte() { const sbyte testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsSByte(), testData); } [Fact] public void CanWriteAndRecoverSByteRepeatedly() {} [Fact] public void CanWriteAndRecoverSByteWithinGroup() {} [Fact] public void CanWriteAndRecoverSByteWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverShort() { const short testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsShort(), testData); } [Fact] public void CanWriteAndRecoverShortRepeatedly() {} [Fact] public void CanWriteAndRecoverShortWithinGroup() {} [Fact] public void CanWriteAndRecoverShortWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverUShort() { const ushort testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsUShort(), testData); } [Fact] public void CanWriteAndRecoverUShortRepeatedly() {} [Fact] public void CanWriteAndRecoverUShortWithinGroup() {} [Fact] public void CanWriteAndRecoverUShortWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverInt() { const int testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsInt(), testData); } [Fact] public void CanWriteAndRecoverIntRepeatedly() {} [Fact] public void CanWriteAndRecoverIntWithinGroup() {} [Fact] public void CanWriteAndRecoverIntWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverUInt() { const uint testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsUInt(), testData); } [Fact] public void CanWriteAndRecoverUIntRepeatedly() {} [Fact] public void CanWriteAndRecoverUIntWithinGroup() {} [Fact] public void CanWriteAndRecoverUIntWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverLong() { const long testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsLong(), testData); } [Fact] public void CanWriteAndRecoverLongRepeatedly() {} [Fact] public void CanWriteAndRecoverLongWithinGroup() {} [Fact] public void CanWriteAndRecoverLongWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverULong() { const ulong testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsULong(), testData); } [Fact] public void CanWriteAndRecoverULongRepeatedly() {} [Fact] public void CanWriteAndRecoverULongWithinGroup() {} [Fact] public void CanWriteAndRecoverULongWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverFloat() { const float testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsFloat(), testData); } [Fact] public void CanWriteAndRecoverFloatRepeatedly() {} [Fact] public void CanWriteAndRecoverFloatWithinGroup() {} [Fact] public void CanWriteAndRecoverFloatWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverDouble() { const double testData = 42;  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsDouble(), testData); } [Fact] public void CanWriteAndRecoverDoubleRepeatedly() {} [Fact] public void CanWriteAndRecoverDoubleWithinGroup() {} [Fact] public void CanWriteAndRecoverDoubleWithinGroupRepeatedly() {}
        [Fact] public void CanWriteAndRecoverString() { const string testData = "Forty Two";  using var s = new MemoryStream(); using var inStream = new Df2Stream(s, StreamMode.Write, true); inStream.AddOrUpdate("TestData", testData); inStream.Flush(); inStream.Close(); Out.WriteLine($"Data: {Encoding.UTF8.GetString(s.ToArray())} ({BitConverter.ToString(s.ToArray())}"); s.Seek(0, SeekOrigin.Begin); using var outStream = new Df2Stream(s, StreamMode.Read); Assert.Equal(outStream.Values["TestData"].AsString(), testData); } [Fact] public void CanWriteAndRecoverStringRepeatedly() {} [Fact] public void CanWriteAndRecoverStringWithinGroup() {} [Fact] public void CanWriteAndRecoverStringWithinGroupRepeatedly() {}
    }
}