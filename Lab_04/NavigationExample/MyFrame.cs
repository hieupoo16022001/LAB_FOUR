using System;

namespace NavigationExample
{
    internal class MyFrame
    {
        public static bool CanGoBack { get; internal set; }
        public static bool CanGoForward { get; internal set; }

        internal static void Navigate(Type type)
        {
            throw new NotImplementedException();
        }

        internal static void GoBack()
        {
            throw new NotImplementedException();
        }

        internal static void GoForward()
        {
            throw new NotImplementedException();
        }
    }
}