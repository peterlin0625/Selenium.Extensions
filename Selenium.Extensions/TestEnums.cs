﻿using System.ComponentModel;

namespace Selenium.Extensions
{
    /// <summary>
    /// The test type you want to run
    /// </summary>
    [Description("Test Type")]
    public enum TestType
    {
        [Description("Standalone Browser")]
        StandaloneBrowser,
        [Description("Installed Browser")]
        InstalledBrowser,
        [Description("Cloud Browser")]
        CloudBrowser,
        [Description("Emulator Browser")]
        EmulatorBrowser,
        [Description("Android Browser")]
        AndroidBrowser
    }

    /// <summary>
    /// The webdriver to use for the test
    /// </summary>
    [Description("Driver")]
    public enum WebDriver
    {
        [Description("Chrome")]
        ChromeDriver,
        [Description("Firefox")]
        FirefoxDriver,
        [Description("IE")]
        InternetExplorerDriver,
        [Description("Edge")]
        EdgeDriver,
        [Description("Opera")]
        OperaDriver,
        //PhantomJsDriver,
        [Description("Remote")]
        RemoteWebDriver,
        [Description("Safari")]
        SafariDriver
}

    //public enum TestBrowser
    //{
    //    Chrome,
    //    Edge,
    //    MultiBrowserEmulator,
    //    Firefox,
    //    InternetExplorer,
    //    Opera,
    //    Safari,
    //    Android,
    //    IPhone,
    //    IPad,
    //    HtmlUnit,
    //    HtmlUnitWithJavaScript,
    //    PhantomJs
    //}

    [Description("Vendor")]
    public enum CloudBrowserVendor
    {
        [Description("Apple iPad")]
        iPad,
        [Description("Apple iPhone")]
        iPhone,
        [Description("Google Android")]
        Android,
        [Description("Apple Yosemite")]
        Yosemite,
        [Description("Apple Mavericks")]
        Mavericks,
        [Description("Apple Mountain Lion")]
        MountainLion,
        [Description("Apple Snow Leopard")]
        SnowLeopard,
        [Description("Linux")]
        Linux,
    }

    [Description("Browser Name")]
    public enum CloudBrowserName
    {
        [Description("Chrome")]
        Chrome,
        [Description("Firefox")]
        Firefox,
        [Description("Safari")]
        Safari,
        [Description("Opera")]
        Opera,
    }

    [Description("Orientation")]
    public enum DeviceOrientation
    {
        [Description("Landscape")]
        Landscape,
        [Description("Portrait")]
        Portrait
    }

    [Description("MultiBrowser Emulator")]
    public enum Emulator
    {
        [Description("Apple iPhone4")]
        // ReSharper disable InconsistentNaming
        iPhone4,
        [Description("Apple iPhone5")]
        iPhone5,
        [Description("Apple iPhone6")]
        iPhone6,
        [Description("Apple iPhone6 Plus")]
        iPhone6Plus,
        [Description("Apple iPad")]
        iPad,
        // ReSharper restore InconsistentNaming
        [Description("Samsung Galaxy Tab")]
        SamsungGalaxyTab,
        [Description("Samsung Galaxy S5")]
        SamsungGalaxyS5,
        [Description("Samsung Galaxy S6")]
        SamsungGalaxyS6,
        [Description("Sony Xperia Z3")]
        SonyXperiaZ3
    }

    public enum ElementType
    {
        Button,
        CheckBox,
        Div,
        Img,
        Label,
        A,
        Radio,
        Select,
        Span,
        Tbody,
        Td,
        Thead,
        Tr,
        Table,
        Text,
        Password,
        Submit,
        DateTime,
        DateTimeLocal,
        Date,
        Color,
        Email,
        Month,
        Number,
        Range,
        Search,
        Tel,
        Time,
        Url,
        Week

    }


}