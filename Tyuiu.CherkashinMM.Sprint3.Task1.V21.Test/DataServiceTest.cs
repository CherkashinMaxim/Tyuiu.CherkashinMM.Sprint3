using Tyuiu.CherkashinMM.Sprint3.Task1.V21.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task1.V21.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void Check()  
   {
        DataService ds = new DataService();
        Assert.AreEqual(99.512, ds.GetMultiplySeries(1, 1, 12));
    } 
} 
