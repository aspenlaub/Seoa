using Aspenlaub.Net.GitHub.CSharp.Seoa.Components;
using Autofac;

namespace Aspenlaub.Net.GitHub.CSharp.Seoa;

[TestClass]
public sealed class SeoaTest {
    [TestMethod]
    public void CanBuildSeoaContainer() {
        IContainer container = new ContainerBuilder().UseSeoa(nameof(SeoaTest)).Build();
        Assert.IsNotNull(container);
    }
}
