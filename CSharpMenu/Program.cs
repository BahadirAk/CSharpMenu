namespace CSharpMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            Menu menu = new Menu();

            operations.Login();
            menu.GetMenu();
        }
    }
}
