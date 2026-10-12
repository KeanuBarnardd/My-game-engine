using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Vulkan;
using Silk.NET.Windowing;
using System.Drawing;



public class Program
{

    private static IWindow _window;
    private static GL _gl;

    private static uint _vertexArrayObject;
    private static uint _visualBufferObject;

    public static void Main(string[] args)
    {
        WindowOptions options = WindowOptions.Default with
        {
            Size = new Vector2D<int>(800, 600),
            Title = "My Game engine "
        };

        _window = Window.Create(options);


        _window.Load += OnLoad;
        _window.Update += OnUpdate;
        _window.Render += OnRender;


        _window.Run();
    }

    private static void OnLoad()
    {
        IInputContext input = _window.CreateInput();

        _gl = _window.CreateOpenGL();
        _gl.ClearColor(Color.CornflowerBlue);
        _gl.Clear(ClearBufferMask.ColorBufferBit);

        _vertexArrayObject = _gl.GenVertexArray();

        _gl.BindVertexArray(_vertexArrayObject);

        _visualBufferObject = _gl.GenBuffer();
        _gl.BindBuffer(BufferTargetARB.ArrayBuffer, _visualBufferObject);


        float[] vertices =
        {
            0.5f,  0.5f, 0.0f,
            0.5f, -0.5f, 0.0f,
            -0.5f, -0.5f, 0.0f,
            -0.5f,  0.5f, 0.0f
        };

        for (int i = 0; i < input.Keyboards.Count; i++)
        {
            input.Keyboards[i].KeyDown += KeyDown;
        }
    }

    private static void OnUpdate(double deltaTime)
    {
        Console.WriteLine("Update!");
    }

    private static void OnRender(double deltaTime)
    {

    }

    private static void KeyDown(IKeyboard keyboard, Key key, int keyCode)
    {
        if (key == Key.Escape)
        {
            _window.Close();
        }
    }
};

