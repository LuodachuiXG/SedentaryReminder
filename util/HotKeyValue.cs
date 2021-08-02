using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedentaryReminder.util
{
    /// <summary>
    /// 系统热键数据类。
    /// </summary>
    class HotKeyValue
    {
        /// <summary>
        /// 修改键。
        /// </summary>
        public Keys Modifiers = Keys.None;

        /// <summary>
        /// 按键值。
        /// </summary>
        public Keys KeyCode = Keys.None;

        /// <summary>
        /// 初始化 <see cref="HotKeyValue" /> 的新实例
        /// </summary>
        /// <param name="modifiers"></param>
        /// <param name="keyCode"></param>
        public HotKeyValue(Keys modifiers, Keys keyCode)
        {
            this.Modifiers = modifiers;
            this.KeyCode = keyCode;
        }


        /// <summary>
        /// 重载，返回快捷键组合字符串
        /// </summary>
        /// <returns>返回快捷键组合字符串</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if ((this.Modifiers & Keys.Control) != 0)
                sb.Append("Ctrl+");
            if ((this.Modifiers & Keys.Shift) != 0)
                sb.Append("Shift+");
            if ((this.Modifiers & Keys.Alt) != 0)
                sb.Append("Alt+");
            if (this.KeyCode != Keys.None)
                sb.Append((char)this.KeyCode);
            return sb.ToString();
        }
    }
}
