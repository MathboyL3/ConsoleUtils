using System.Text;
using ConsoleUtils.WriterH;
using System.Globalization;

namespace ConsoleUtils.ReaderH
{
    public class Reader
    {
        static CultureInfo invariant = CultureInfo.InvariantCulture;
        public static int[] ReadIntVector((int x, int y) pos, int max_char_item_size, int max_array_length, ConsoleColor brackets_color = ConsoleColor.White, ConsoleColor items_color = ConsoleColor.White, ConsoleColor comma_color = ConsoleColor.White)
        {
            Writer.SetCursorPosition(pos);
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.CursorVisible = false;
                Writer.SetCursorPosition(pos);
                string[] separeted_items = sb.ToString().Split(",");

                Writer.Write("[", brackets_color);
                for(int i = 0; i < separeted_items.Length; i++)
                {
                    Writer.Write(separeted_items[i], items_color);
                    if(i != separeted_items.Length-1)
                        Writer.Write(",", comma_color);
                }
                Writer.Write("] ", brackets_color);

                (int x, int y) current_pos = Console.GetCursorPosition();
                Console.SetCursorPosition(current_pos.x - 2 > 0 ? current_pos.x - 2 : 0, current_pos.y);
                Console.CursorVisible = true;

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                ConsoleKey key = key_pressed.Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                }
                else if (key == ConsoleKey.OemMinus)
                {
                    if (sb.Length == 0 || sb[sb.Length - 1] == ',')
                        sb.Append('-');
                }
                else if (key == ConsoleKey.Spacebar || key == ConsoleKey.OemComma)
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] != ',')
                        if ((from a in sb.ToString() where a == ',' select a).Count() < max_array_length)
                            sb.Append(',');
                }
                int l = sb.ToString().LastIndexOf(',') + 1;
                if (char.IsDigit(key_pressed.KeyChar))
                    if (sb.Length - l < max_char_item_size)
                        sb.Append(key_pressed.KeyChar);
            }

            return sb.ToString().Split(',').Select(s => int.Parse(s, invariant)).ToArray();
        }
        public static int[] ReadIntVector(ConsoleColor brackets_color = ConsoleColor.White, ConsoleColor items_color = ConsoleColor.White, ConsoleColor comma_color = ConsoleColor.White)
        {
            return ReadIntVector(Console.GetCursorPosition(), int.MaxValue.ToString().Length, int.MaxValue, brackets_color, items_color, comma_color);
        }
        public static int[] ReadIntVector((int x, int y) pos)
        {
            return ReadIntVector(pos, int.MaxValue.ToString().Length, int.MaxValue, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
        }

        public static double[] ReadDoubleVector((int x, int y) pos, int max_char_item_size, int max_array_length, ConsoleColor brackets_color = ConsoleColor.White, ConsoleColor items_color = ConsoleColor.White, ConsoleColor comma_color = ConsoleColor.White)
        {
            Writer.SetCursorPosition(pos);
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.CursorVisible = false;
                Writer.SetCursorPosition(pos);
                string[] separeted_items = sb.ToString().Split(",");

                Writer.Write("[", brackets_color);
                for (int i = 0; i < separeted_items.Length; i++)
                {
                    Writer.Write(separeted_items[i], items_color);
                    if (i != separeted_items.Length - 1)
                        Writer.Write(",", comma_color);
                }
                Writer.Write("] ", brackets_color);

                (int x, int y) current_pos = Console.GetCursorPosition();
                Console.SetCursorPosition(current_pos.x - 2 > 0 ? current_pos.x - 2 : 0, current_pos.y);
                Console.CursorVisible = true;

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                ConsoleKey key = key_pressed.Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                }
                else if (key == ConsoleKey.OemMinus)
                {
                    if (sb.Length == 0 || sb[sb.Length - 1] == ',')
                        sb.Append('-');
                }
                else if (key == ConsoleKey.Spacebar || key == ConsoleKey.OemComma)
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] != ',')
                        if ((from a in sb.ToString() where a == ',' select a).Count() < max_array_length)
                            sb.Append(',');
                }

                int l = sb.ToString().LastIndexOf(',') + 1;
                if (char.IsDigit(key_pressed.KeyChar) || key_pressed.KeyChar == '.')
                    if (sb.Length - l < max_char_item_size)
                        sb.Append(key_pressed.KeyChar);
            }

            return sb.ToString().Split(',').Select(s => double.Parse(s, invariant)).ToArray();
        }
        public static double[] ReadDoubleVector(ConsoleColor brackets_color = ConsoleColor.White, ConsoleColor items_color = ConsoleColor.White, ConsoleColor comma_color = ConsoleColor.White)
        {
            return ReadDoubleVector(Console.GetCursorPosition(), int.MaxValue.ToString().Length, int.MaxValue, brackets_color, items_color, comma_color);
        }
        public static double[] ReadDoubleVector((int x, int y) pos)
        {
            return ReadDoubleVector(pos, int.MaxValue.ToString().Length, int.MaxValue, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
        }

        public static float[] ReadFloatVector((int x, int y) pos, int max_char_item_size, int max_array_length, ConsoleColor brackets_color = ConsoleColor.White, ConsoleColor items_color = ConsoleColor.White, ConsoleColor comma_color = ConsoleColor.White)
        {
            Writer.SetCursorPosition(pos);
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.CursorVisible = false;
                Writer.SetCursorPosition(pos);
                string[] separeted_items = sb.ToString().Split(",");

                Writer.Write("[", brackets_color);
                for (int i = 0; i < separeted_items.Length; i++)
                {
                    Writer.Write(separeted_items[i], items_color);
                    if (i != separeted_items.Length - 1)
                        Writer.Write(",", comma_color);
                }
                Writer.Write("] ", brackets_color);

                (int x, int y) current_pos = Console.GetCursorPosition();
                Console.SetCursorPosition(current_pos.x - 2 > 0 ? current_pos.x - 2 : 0, current_pos.y);
                Console.CursorVisible = true;

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                ConsoleKey key = key_pressed.Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                }
                else if (key == ConsoleKey.OemMinus)
                {
                    if (sb.Length == 0 || sb[sb.Length - 1] == ',')
                        sb.Append('-');
                }
                else if (key == ConsoleKey.Spacebar || key == ConsoleKey.OemComma)
                {
                    if (sb.Length > 0 && sb[sb.Length - 1] != ',')
                        if ((from a in sb.ToString() where a == ',' select a).Count() < max_array_length)
                            sb.Append(',');
                }

                int l = sb.ToString().LastIndexOf(',') + 1;
                if (char.IsDigit(key_pressed.KeyChar) || key_pressed.KeyChar == '.')
                    if (sb.Length - l < max_char_item_size)
                        sb.Append(key_pressed.KeyChar);
            }

            return sb.ToString().Split(',').Select(s => float.Parse(s, invariant)).ToArray();
        }
        public static float[] ReadFloatVector(ConsoleColor brackets_color = ConsoleColor.White, ConsoleColor items_color = ConsoleColor.White, ConsoleColor comma_color = ConsoleColor.White)
        {
            return ReadFloatVector(Console.GetCursorPosition(), int.MaxValue.ToString().Length, int.MaxValue, brackets_color, items_color, comma_color);
        }
        public static float[] ReadFloatVector((int x, int y) pos)
        {
            return ReadFloatVector(pos, int.MaxValue.ToString().Length, int.MaxValue, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White);
        }

        public static string ReadLine((int x, int y) pos, ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            
            Writer.SetCursorPosition(pos);
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.CursorVisible = false;
                Writer.SetCursorPosition(pos);
                Writer.Write($"{sb} ", font_color);

                (int x, int y) current_pos = Console.GetCursorPosition();
                Console.SetCursorPosition(current_pos.x - 1 > 0 ? current_pos.x - 1 : 0, current_pos.y);

                Console.CursorVisible = true;

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                ConsoleKey key = key_pressed.Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                }
                else if (!invert_exception && (exception == null || !exception.Contains(key_pressed.KeyChar)))
                    sb.Append(key_pressed.KeyChar);
                else if (invert_exception && (exception == null || exception.Contains(key_pressed.KeyChar)))
                    sb.Append(key_pressed.KeyChar);
            }

            return sb.ToString();
        }
        public static string ReadLine(ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return ReadLine(Console.GetCursorPosition(), font_color, exception, invert_exception);
        }

        public static char ReadChar((int x, int y) pos, ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {

            Writer.SetCursorPosition(pos);
            char current_char = ' ';
            while (true)
            {
                Console.CursorVisible = false;
                Writer.SetCursorPosition(pos);
                Writer.Write($"{current_char}", font_color);
                Console.CursorVisible = true;

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                ConsoleKey key = key_pressed.Key;

                if (key == ConsoleKey.Backspace)
                    continue;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (!invert_exception && (exception == null || !exception.Contains(key_pressed.KeyChar)))
                    current_char = key_pressed.KeyChar;
                else if (invert_exception && (exception == null || exception.Contains(key_pressed.KeyChar)))
                    current_char = key_pressed.KeyChar;
            }

            return current_char;
        }
        public static char ReadChar(ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return ReadChar(Console.GetCursorPosition(), font_color, exception, invert_exception);
        }

        static string ReadNumberAsString((int x, int y) pos, bool is_float = false, ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            Writer.SetCursorPosition(pos);
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.CursorVisible = false;
                Writer.SetCursorPosition(pos);
                Writer.Write($"{sb} ", font_color);

                (int x, int y) current_pos = Console.GetCursorPosition();
                Console.SetCursorPosition(current_pos.x - 1 > 0 ? current_pos.x - 1 : 0, current_pos.y);

                Console.CursorVisible = true;

                ConsoleKeyInfo key_pressed = Console.ReadKey(true);
                ConsoleKey key = key_pressed.Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                }
                else if (char.IsDigit(key_pressed.KeyChar) || (is_float && key_pressed.KeyChar == '.'))
                {
                    if (!invert_exception && (exception == null || !exception.Contains(key_pressed.KeyChar)))
                        sb.Append(key_pressed.KeyChar);
                    else if (invert_exception && (exception == null || exception.Contains(key_pressed.KeyChar)))
                        sb.Append(key_pressed.KeyChar);
                }
            }
            return sb.ToString();
        }

        public static int ReadInt((int x, int y) pos, ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return int.Parse(ReadNumberAsString(pos, false, font_color, exception, invert_exception), invariant);
        }
        public static int ReadInt(ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return ReadInt(Console.GetCursorPosition(), font_color, exception, invert_exception);
        }

        public static double ReadDouble((int x, int y) pos, ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return double.Parse(ReadNumberAsString(pos, true, font_color, exception, invert_exception), invariant);
        }
        public static double ReadDouble(ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return ReadDouble(Console.GetCursorPosition(), font_color, exception, invert_exception);
        }

        public static float ReadFloat((int x, int y) pos, ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return float.Parse(ReadNumberAsString(pos, true, font_color, exception, invert_exception), invariant);
        }
        public static float ReadFloat(ConsoleColor font_color = ConsoleColor.White, char[]? exception = null, bool invert_exception = false)
        {
            return ReadFloat(Console.GetCursorPosition(), font_color, exception, invert_exception);
        }
    }
}
