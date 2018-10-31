//using NUnit.Framework;
//using System.Diagnostics;
//using System.IO;

//public enum DatabaseType
//{
//    Test,
//    ProductionCopy
//}

//[SetUpFixture]
//public class SetUpFixture
//{
//    [OneTimeSetUp]
//    public void Setup()
//    {
//        //var creator = new CreateTestDatabase();
//        //creator.Create();
//    }
//}

//public class TestBase
//{
//    private Stopwatch _StopWatch = new Stopwatch();

//    [SetUp]
//    public void Setup()
//    {
//        Trace.WriteLine("");
//        Trace.WriteLine("");
//        Trace.WriteLine(string.Format("============== {0} ==============", TestContext.CurrentContext.Test.FullName));
//        this._StopWatch.Start();

//    }

//    [TearDown]
//    public void TearDown()
//    {
//        Trace.WriteLine(string.Format("*********************************************************************", TestContext.CurrentContext.Test.FullName));
//        Trace.WriteLine("Elapsed: "+ this._StopWatch.Elapsed);
//        Trace.WriteLine("");
//    }

//    internal string TestFolder()
//    {
//        return TestContext.CurrentContext.TestDirectory;
//    }

//    internal string TestFolder(string subFolder)
//    {
//        return Path.Combine(this.TestFolder(), subFolder);
//    }



//    //public static string GetConnectionString(DatabaseType databaseType)
//    //{
//    //    var result = "";
//    //    switch (databaseType)
//    //    {
//    //        case DatabaseType.ProductionCopy:
//    //            result = JollySwagman.Utilities.Settings.GetConnectionString("ChabrierEntities_Prod");
//    //            break;

//    //        case DatabaseType.Test:
//    //            result = JollySwagman.Utilities.Settings.GetConnectionString("ChabrierEntities");
//    //            break;

//    //        default:
//    //            break;
//    //    }
//    //    return result;
//    //}
//}