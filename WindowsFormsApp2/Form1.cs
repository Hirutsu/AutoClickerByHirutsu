using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace WindowsFormsApp2
{
    public partial class AutoClicker : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,LowLevelKeyboardProcDelegate lpfn,IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk,int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var khs = (KeyboardHookStruct)
                          Marshal.PtrToStructure(lParam,
                          typeof(KeyboardHookStruct));
                if (Convert.ToInt32("" + wParam) == 256)
                {
                    if ((int)khs.VirtualKeyCode == 123)//F12
                    {
                        ButtonStop.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 113)//F2
                    {
                        StartButton.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 114)//F3
                    {
                        FindPosCursor.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                }
            }
            return CallNextHookEx(m_hHook, nCode, wParam, lParam);
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }
        private delegate IntPtr LowLevelKeyboardProcDelegate(
            int nCode, IntPtr wParam, IntPtr lParam);

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                m_callback,
                GetModuleHandle(IntPtr.Zero), 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        static protected long totalPixels = 0;
        static protected int diffX;
        static protected int diffY;
        bool isStart = false;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //Нормированные абсолютные координаты
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        //Нажатие на левую кнопку мыши
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //Поднятие левой кнопки мыши
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        //Нажатие на правой кнопку мыши
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //Поднятие правой кнопки мыши
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //перемещение указателя мыши
        private const int MOUSEEVENTF_MOVE = 0x0001;

        public AutoClicker()
        {
            InitializeComponent();
            SetHook();
            this.Focus();
        }

        private void TextBoxMins_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Back) && TextBoxMins.Text.Length > 0)
            {
                TextBoxMins.Text = TextBoxMins.Text.Substring(0, TextBoxMins.Text.Length - 1);
            }
        }

        private void TextBoxSecs_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Back) && TextBoxSecs.Text.Length > 0)
            {
                TextBoxSecs.Text = TextBoxSecs.Text.Substring(0, TextBoxSecs.Text.Length - 1);
            }
        }

        private void TextBoxMins_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void TextBoxSecs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void AutoClicker_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == false)
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == false)
            {
                radioButton3.Checked = true;
                radioButton4.Checked = false;
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == false)
            {
                radioButton4.Checked = true;
                radioButton3.Checked = false;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRoleUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        async private void StartButton_Click(object sender, EventArgs e)
        {

            isStart = true;
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int X = 65535/resolution.Width * Convert.ToInt32(TextLocationX.Text);
            int Y = 65535 / resolution.Height * Convert.ToInt32(TextLocationY.Text);

            while (isStart)
            {
                if(radioButton3.Checked == true && radioButton1.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (radioButton4.Checked == true && radioButton1.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (radioButton3.Checked == true && radioButton2.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                if (radioButton4.Checked == true && radioButton2.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                await Task.Delay(60000 * Convert.ToInt32(TextBoxMins.Text) + 1000 * Convert.ToInt32(TextBoxSecs.Text));
            }
        }

        private void FindPosCursor_Click(object sender, EventArgs e)
        {
            // обновление информации происходит каждые 10 мс
            Point defPnt = new Point();
            // заполняем defPnt информацией о координатах мышки
            GetCursorPos(ref defPnt);
            // выводим информацию в окно
            TextLocationY.Text = defPnt.Y.ToString();
            TextLocationX.Text = defPnt.X.ToString(); 
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isStart = false;
            TextLocationX.Text = "0";
            TextLocationY.Text = "0";
            TextBoxMins.Text = "0";
            TextBoxSecs.Text = "0";
        }
    }
}
