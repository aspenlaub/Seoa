using Aspenlaub.Net.GitHub.CSharp.Skladasu.Extensions;
using Aspenlaub.Net.GitHub.CSharp.Skladasu.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspenlaub.Net.GitHub.CSharp.Seoa.Extensions;

public static class AssertExtensions {
    public static void ThereWereNoErrors(this Assert assert, IErrorsAndInfos errorsAndInfos) {
        if (!errorsAndInfos.AnyErrors()) {
            return;
        }

        throw new AssertFailedException(errorsAndInfos.ErrorsToString());
    }
}
