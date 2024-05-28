
namespace PluginSystem
{
    public interface IPlugin
    {
        void Execute();
    }

    public class PluginManager
    {
        private readonly List<IPlugin> plugins = new List<IPlugin>();

        public void LoadPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
        }

        public void ExecuteAll()
        {
            foreach (var plugin in plugins)
            {
                plugin.Execute();
            }
        }
    }

    public class CalculatorPlugin : IPlugin
    {
        public void Execute()
        {
            int a = 5;
            int b = 3;
            int result = a + b;
            Console.WriteLine($"CalculatorPlugin: {a} + {b} = {result}");
        }
    }

    public class GreetingPlugin : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("GreetingPlugin: Hello, welcome to the plugin system!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var pluginManager = new PluginManager();

            var calculatorPlugin = new CalculatorPlugin();
            var greetingPlugin = new GreetingPlugin();

            pluginManager.LoadPlugin(calculatorPlugin);
            pluginManager.LoadPlugin(greetingPlugin);

            pluginManager.ExecuteAll();
        }
    }
}