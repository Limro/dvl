// <copyright file="ModelTest.AdminPassSet.g.cs">Copyright �  2011</copyright>
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

namespace DigitalVoterList.PexTests
{
    using DBComm.DBComm.DO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Pex.Framework.Generated;

    using global::PollingTable.PollingTable;

    public partial class ModelTest
    {
[TestMethod]
[PexGeneratedBy(typeof(ModelTest))]
public void AdminPassSet550()
{
    Model model;
    model = new Model();
    model.currentVoter = (VoterDO)null;
    model.AdminPass = (string)null;
    this.AdminPassSet(model, (string)null);
    Assert.IsNotNull((object)model);
    Assert.IsNull((object)(model.currentVoter));
    Assert.AreEqual<string>("localhost", model.SetupInfo.Ip);
    Assert.AreEqual<uint>(0u, model.SetupInfo.TableNo);
    Assert.AreEqual<string>((string)null, model.AdminPass);
}
    }
}
