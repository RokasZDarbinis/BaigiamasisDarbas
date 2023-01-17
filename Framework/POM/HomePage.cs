namespace Framework.POM
{
    public class HomePage
    {
        public static void Startup()
        {
            Driver.StartDriver();
            Driver.OpenPage("https://www.skytech.lt");
        }
    }
}
