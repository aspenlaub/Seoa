using Aspenlaub.Net.GitHub.CSharp.Pegh.Entities;
using Aspenlaub.Net.GitHub.CSharp.Seoa.Extensions;

namespace Aspenlaub.Net.GitHub.CSharp.Seoa.Test;

[TestClass]
public sealed class SeoaTest {
    [TestMethod]
    public void NoErrors() {
        var errorsAndInfos = new ErrorsAndInfos();
        Assert.That.ThereWereNoErrors(errorsAndInfos);
    }
}
