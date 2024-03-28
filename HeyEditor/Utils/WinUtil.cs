using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyEditor {
    internal class WinUtil {
        internal static void Warring(string text) {
            MessageBox.Show(text, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
