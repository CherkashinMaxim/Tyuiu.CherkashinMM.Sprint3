using Tyuiu.CherkashinMM.Sprint3.Task3.V16.Lib; 
 
namespace Tyuiu.CherkashinMM.Sprint3.Task3.V16.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   { 
        DataService ds = new DataService();
        Assert.AreEqual(4, ds.GetCharCount("epioopieinjebjbjvggefcf", 'e'));
   } 
} 
