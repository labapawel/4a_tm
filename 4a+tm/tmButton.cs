using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4a_tm
{
    internal class tmButton : Button
    {
        private Label LA = new Label() { Text = "1"};
        private string pSymbol = "";
        public string Symbol {
                get => pSymbol;
                set
                {
                    pSymbol = value;
                    base.Text = value;
                }
            }

        public int La { get => int.Parse(LA.Text); set => LA.Text = value.ToString(); }
        public tmButton() : base()
        {
            
            this.Resize += ResizeBtt;
            this.Controls.Add(LA);
            LA.Left = 5;
            LA.Top = 5;
            LA.Font = new Font("Arial", 7);
        }


        private void ResizeBtt(object sender, System.EventArgs e)
        {
            base.Height = base.Width;
            base.Size = new Size(this.Width, this.Height);
        }
    }
}
