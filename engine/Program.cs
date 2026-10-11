using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Vulkan;
using Silk.NET.Windowing;



public class Program
{

    private static IWindow _window;

    public static void Main(string[] args)
    {
        // Create our window settings
        WindowOptions options = WindowOptions.Default with
        {
            Size = new Vector2D<int>(800, 600),
            Title = "My Game engine "
        };

        _window = Window.Create(options);
        _window.Run();
    }

    private static void OnLoad()
    {

    }

    private static void OnUpdate()
    {

    }

    private static void OnRender()
    {

    }
};

