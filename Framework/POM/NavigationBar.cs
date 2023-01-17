namespace Framework.POM
{
    public class NavigationBar
    {
        public static void NavigatingNavBar(string menuLocator, string submenuLocator)
        {
            Common.MouseHover_SubMenuClick(menuLocator, submenuLocator);
        }

        public static void ClickingOnWantedMenu(string locator)
        {
            Common.WaitAndClick(locator);
        }
    }
}
