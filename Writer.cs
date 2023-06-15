using System.Text;

namespace ConsoleUtils.WriterH
{
    public class Writer
    {
        public static void Write(string text, (int x, int y) position, ConsoleColor font_color = ConsoleColor.White, ConsoleColor background_color = ConsoleColor.Black)
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = font_color;
            Console.BackgroundColor = background_color;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void Write(string text, ConsoleColor font_color = ConsoleColor.White, ConsoleColor background_color = ConsoleColor.Black)
        {
            Write(text, Console.GetCursorPosition(), font_color, background_color);
        }
        public static void Write(string text, ConsoleColor font_color)
        {
            Write(text, Console.GetCursorPosition(), font_color);
        }

        public static void WriteLine(string text, (int x, int y) position, ConsoleColor font_color = ConsoleColor.White, ConsoleColor background_color = ConsoleColor.Black)
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = font_color;
            Console.BackgroundColor = background_color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void WriteLine(string text, ConsoleColor font_color = ConsoleColor.White, ConsoleColor background_color = ConsoleColor.Black)
        {
            WriteLine(text, Console.GetCursorPosition(), font_color, background_color);
        }
        public static void WriteLine(string text, ConsoleColor font_color)
        {
            WriteLine(text, Console.GetCursorPosition(), font_color);
        }





        public static void SetCursorPosition((int x, int y) position)
        {
            Console.SetCursorPosition(position.x, position.y);
        }

        public static void ClearLine(int line_y)
        {
            SetCursorPosition((0, line_y));
            StringBuilder clearing_text = new StringBuilder();
            clearing_text.Append(' ', Console.BufferWidth-1);
            Console.Write(clearing_text.ToString());
            SetCursorPosition((0, line_y));
        }

        public static void WriteTemporaryText(string text, ConsoleColor font_color = ConsoleColor.White, int time_in_milliseconds = 700)
        {
            (int x, int y) pos = Console.GetCursorPosition();
            Write(text, pos, font_color, ConsoleColor.Black);
            Thread.Sleep(time_in_milliseconds);
            StringBuilder clearing_text = new StringBuilder();
            SetCursorPosition(pos);
            clearing_text.Append(' ', text.Length);
            Console.Write(clearing_text.ToString());
        }
    }
}
