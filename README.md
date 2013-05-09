NancyError
==========

Testing problem with Nancy testing.

```
Test Name:  TestMethod1
Test FullName:	Eightlabs.CardGame.TestWin.UnitTest1.TestMethod1
Test Source:	c:\dev\Eightlabs.CardGame\src\Eightlabs.CardGame.TestWin\UnitTest1.cs : line 19
Test Outcome:	Failed
Test Duration:	0:00:00.0973812

Result Message:	
Test method Eightlabs.CardGame.TestWin.UnitTest1.TestMethod1 threw exception: 
System.InvalidOperationException: Sequence contains more than one element
Result StackTrace:	
at System.Linq.Enumerable.SingleOrDefault[TSource](IEnumerable`1 source)
   at Nancy.Bootstrapper.NancyBootstrapperBase`1.GetRootPathProvider()
   at Nancy.Bootstrapper.NancyBootstrapperBase`1.get_RootPathProvider()
   at Nancy.Bootstrapper.NancyBootstrapperBase`1.GetAdditionalInstances()
   at Nancy.Bootstrapper.NancyBootstrapperBase`1.Initialise()
   at Nancy.Testing.Browser..ctor(INancyBootstrapper bootstrapper)
   at Eightlabs.CardGame.TestWin.UnitTest1.TestMethod1() in c:\dev\Eightlabs.CardGame\src\Eightlabs.CardGame.TestWin\UnitTest1.cs:line 27

```
