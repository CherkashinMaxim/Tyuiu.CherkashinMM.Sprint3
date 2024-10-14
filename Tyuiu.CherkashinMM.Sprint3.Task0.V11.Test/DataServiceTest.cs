using Tyuiu.CherkashinMM.Sprint3.Task0.V11.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task0.V11.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(0.042, ds.GetSumSeries(5, 1, 10));
   } 
} 
