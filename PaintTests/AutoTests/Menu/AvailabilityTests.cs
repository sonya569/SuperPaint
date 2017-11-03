using System;
using TestStack.White;
using NUnit.Framework;
using System.IO;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItemEvents;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowStripControls;

namespace PaintTests.Menu
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
        public void TestMethodMenu()
        {
            //#pragma warning disable CS0103 // The name 'applicationPath' does not exist in the current context
            //  Application application = Application.Launch(applicationPath);
            //#pragma warning restore CS0103 // The name 'applicationPath' does not exist in the current context
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("MainForm", InitializeOption.NoCache);

            window.MenuBar.MenuItem("File","Open").Click();
            window.MenuBar.MenuItem("Edit").Click();
           // window.Get<UIItem>("tabToolStripMenuItem").Click();
            //window.Get<MenuBar>("colorToolStripMenuItem").Click();
            //window.Get<MenuBar>("widthToolStripMenuItem").Click();
            //window.Get<MenuBar>("typeToolStripMenuItem").Click();
            application.Kill();
        }
    }
}