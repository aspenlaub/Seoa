using Aspenlaub.Net.GitHub.CSharp.Pegh.Entities;
using Aspenlaub.Net.GitHub.CSharp.Seoa.Components;
using Aspenlaub.Net.GitHub.CSharp.Seoa.Extensions;
using Autofac;

namespace Aspenlaub.Net.GitHub.CSharp.Seoa.Test;

[TestClass]
public sealed class SeoaTest {
    [TestMethod]
    public void CanBuildSeoaContainer() {
        IContainer container = new ContainerBuilder().UseSeoa(nameof(SeoaTest)).Build();
        Assert.IsNotNull(container);
    }

    [TestMethod]
    public void NoErrors() {
        var errorsAndInfos = new ErrorsAndInfos();
        errorsAndInfos.Errors.Add("This is not an error");
        Assert.That.ThereWereNoErrors(errorsAndInfos);
    }
}
