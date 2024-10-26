using Tyuiu.CherkashinMM.Sprint3.Task4.V6.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task4.V6.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(8.995, ds.Calculate(-5, 5));
   } 
} 
