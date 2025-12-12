namespace Tyuiu.MuliavinIM.Sprint5.Task1.V4.Test;

using Tyuiu.MuliavinIM.Sprint5.Task1.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestSaveToFileTextData()
    {
        string expected = "-15,44\n-10,93\n-7,22\n-5,04\n0\n-0,3\n2,57\n6,4\n10,04\n12,72\n14,68";
        CollectionAssert.AreEqual(expected.ToCharArray(), new DataService().SaveToFileTextData(-5, 5).ToCharArray());

    }
}