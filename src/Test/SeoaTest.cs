using Aspenlaub.Net.GitHub.CSharp.Seoa.Extensions;
using Aspenlaub.Net.GitHub.CSharp.Skladasu.Entities;

namespace Aspenlaub.Net.GitHub.CSharp.Seoa.Test;

[TestClass]
public sealed class SeoaTest {
    [TestMethod]
    public void NoErrors() {
        var errorsAndInfos = new ErrorsAndInfos();
        Assert.That.ThereWereNoErrors(errorsAndInfos);
    }
}
