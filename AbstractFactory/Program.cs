internal class Program
{
    public interface ThemeFactory
    {
        public void createTheme()
        {
            Window _window;
            Button _button;
            Text _text;

            _window = this.createWindow();
            _button = this.createButton();
            _text = this.createText();
        }

        Window createWindow();
        Button createButton();
        Text createText();
    }



    public class DarkThemeFactory : ThemeFactory
    {

        string _primartColor;
        string _secondaryColor;
        public DarkThemeFactory()
        {
            _primartColor = "#000000";
            _secondaryColor = "#FFFFFF";
        }

        public Window createWindow()
        {
            return new Window(_primartColor, _secondaryColor);
        }
        public Button createButton()
        {
            return new Button(_primartColor, _secondaryColor, _secondaryColor);
        }
        public Text createText()
        {
            return new Text(_secondaryColor);
        }
    }

    // public abstract class LightThemeFactory : ThemeFactory
    // {

    // }

    public class Window
    {
        public string backgroundColor;
        public string borderColor;

        public Window(string backgroundColor, string borderColor)
        {
            this.backgroundColor = backgroundColor;
            this.borderColor = borderColor;
        }
    }
    public class Button
    {
        public string backgroundColor;
        public string borderColor;
        public string textColor;

        public Button(string backgroundColor, string borderColor, string textColor)
        {
            this.backgroundColor = backgroundColor;
            this.borderColor = textColor;
            this.textColor = textColor;
        }
    }
    public class Text
    {
        public string textColor;
        public Text(string textColor)
        {
            this.textColor = textColor;
        }
    }


    private static void Main(string[] args)
    {
        ThemeFactory darkTheme = new DarkThemeFactory();

        var darkButton = darkTheme.createButton();
    }
}