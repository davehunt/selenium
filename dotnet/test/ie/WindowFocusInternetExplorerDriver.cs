using OpenQA.Selenium.Remote;

namespace OpenQA.Selenium.IE
{
    // This is a simple wrapper class to create an InternetExplorerDriver that
    // uses the enables RequireWindowFocus as the default input simplation.
    public class WindowFocusInternetExplorerDriver : InternetExplorerDriver
    {
        public WindowFocusInternetExplorerDriver(InternetExplorerDriverService service)
            : this(service, DefaultOptions)
        {
        }

        public WindowFocusInternetExplorerDriver(InternetExplorerDriverService service, InternetExplorerOptions options)
            : base(service, options)
        {
        }

        public static InternetExplorerDriverService DefaultService
        {
            get
            {
                InternetExplorerDriverService service = InternetExplorerDriverService.CreateDefaultService();

                // For debugging purposes, one can uncomment the following lines
                // to generate a log from the driver executable. Please do not
                // commit changes to this file with these lines uncommented.
                // service.LogFile = @"iedriver.log";
                // service.LoggingLevel = InternetExplorerDriverLogLevel.Debug;
                return service;
            }
        }

        public static InternetExplorerOptions DefaultOptions
        {
            get { return new InternetExplorerOptions() { RequireWindowFocus = true }; }
        }
    }
}
