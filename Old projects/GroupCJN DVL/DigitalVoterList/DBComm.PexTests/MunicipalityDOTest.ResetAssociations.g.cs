// <copyright file="MunicipalityDOTest.ResetAssociations.g.cs">Copyright �  2011</copyright>
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

    public partial class MunicipalityDOTest
    {
[TestMethod]
[PexGeneratedBy(typeof(MunicipalityDOTest))]
public void ResetAssociations273()
{
    MunicipalityDO municipalityDO;
    municipalityDO =
      new MunicipalityDO(default(uint?), (string)null, (string)null, (string)null);
    this.ResetAssociations(municipalityDO);
    Assert.IsNotNull((object)municipalityDO);
    Assert.IsNotNull(municipalityDO.PollingStations);
    Assert.IsNull((object)(municipalityDO.Id));
    Assert.AreEqual<string>((string)null, municipalityDO.Address);
    Assert.AreEqual<string>((string)null, municipalityDO.City);
    Assert.AreEqual<string>((string)null, municipalityDO.Name);
}
    }
}
