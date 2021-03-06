using System.Collections.Generic;
using System.Threading;
using NUnit.Core;
using NUnit.Framework;
using JsonFx.Json;
using BrainCloud;


namespace BrainCloudTests
{
    public class BrainCloudTestsMain
    {
        static int Main(string[] args)
        {
            TestResult tr = new TestResult();
            BrainCloudClient.Get ().AuthenticationService.AuthenticateUniversal("abc", "abc", true, tr.ApiSuccess, tr.ApiError);
            if (tr.Run ())
            {
                // something
            }
            return 0;
        }
    }
}