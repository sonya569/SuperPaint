using System;
using TestStack.White;
using NUnit.Framework;
using System.IO;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItemEvents;
using TestStack.White.UIItems.Finders;

namespace PaintTests.Plugins
{
    [TestFixture]
    public class AvailabilityTests
    {
        public String applicationPath = @"F:\док\Visual Studio 2017\Projects\SuperPaint\SuperPaint\bin\Debug\SuperPaint.exe";
        [SetUp]
        public void Init()
        {

        }

        [TearDown]
        public void Dispose()
        { /* ... */ }

        [Test]
        public void TestMethodPlus()
        {
            //#pragma warning disable CS0103 // The name 'applicationPath' does not exist in the current context
            //  Application application = Application.Launch(applicationPath);
            //#pragma warning restore CS0103 // The name 'applicationPath' does not exist in the current context
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("MainForm", InitializeOption.NoCache);

            window.Get<RadioButton>("radioButton1").Click();
            window.Get<RadioButton>("radioButton2").Click();
            window.Get<RadioButton>("radioButton3").Click();
            //window.Get<UIItem>("radioButton1").Click();
            application.Kill();
        }
    }
}
