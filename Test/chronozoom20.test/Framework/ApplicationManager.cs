﻿using Framework.Helpers;

namespace Framework
{
    public class ApplicationManager
    {
        private static ApplicationManager _singleton;
        private Environment _environment;
        private NavigationHelper _navigationHelper;
        private BrowserStateManager _browserStateManager;
        private ScreenshotManager _screenshotManager;
        private HomePageHelper _homePageHelper;
        private TourHelper _tourHelper;
        private BookmarkHelper _bookmarkHelper;

        public static ApplicationManager GetInstance()
        {
            return _singleton ?? (_singleton = new ApplicationManager());
        }

        public void Stop()
        {
            if (_environment != null)
            {
                _environment.StopDriver();
                _singleton = null;
            }
        }

        public Environment GetEnvironment()
        {
            return _environment ?? (_environment = new Environment());
        }
        
        public NavigationHelper GetNavigationHelper()
        {
            return _navigationHelper ?? (_navigationHelper = new NavigationHelper());
        }

        public BrowserStateManager GetBrowserStateManager()
        {
            return _browserStateManager ?? (_browserStateManager = new BrowserStateManager());
        }

        public ScreenshotManager GetScreenshotManager()
        {
            return _screenshotManager ?? (_screenshotManager = new ScreenshotManager());
        }

        public HomePageHelper GetHomePageHelper()
        {
            return _homePageHelper ?? (_homePageHelper = new HomePageHelper());
        }

        public TourHelper GetTourHelper()
        {
            return _tourHelper ?? (_tourHelper = new TourHelper());
        }

        public BookmarkHelper GetBookmarkHelper()
        {
            return _bookmarkHelper ?? (_bookmarkHelper = new BookmarkHelper());
        }

    }
}