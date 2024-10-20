using Tyuiu.CherkashinMM.Sprint3.Task2.V2.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task2.V2.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(6482.439, ds.GetMultiplySeries(1, 7));
   } 
} 
