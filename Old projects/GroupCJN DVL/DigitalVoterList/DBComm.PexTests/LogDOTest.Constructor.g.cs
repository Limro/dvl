// <copyright file="LogDOTest.Constructor.g.cs">Copyright �  2011</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>

namespace DBComm.PexTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Pex.Framework.Generated;

    using global::DBComm.DBComm.DO;

    public partial class LogDOTest
    {
[TestMethod]
[PexGeneratedBy(typeof(LogDOTest))]
public void Constructor481()
{
    LogDO logDO;
    logDO = this.Constructor(default(uint?), default(uint?), default(ActivityEnum?));
    Assert.IsNotNull((object)logDO);
    Assert.IsNull((object)(logDO.PrimaryKey));
    Assert.IsNull((object)(logDO.Time));
    Assert.IsNull((object)(logDO.Table));
    Assert.IsNull((object)(logDO.Cpr));
    Assert.IsNull((object)(logDO.Activity));
}
    }
}
