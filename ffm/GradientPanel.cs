using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffm
{
    class GradientPanel :   FlowLayoutPanel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new
            LinearGradientBrush(this.ClientRectangle, this.TopColor,
            this.BottomColor, 90F);

            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors = new Color[2] { this.TopColor, this.BottomColor };
            cblend.Positions = new float[2] { 0f, 1f };

            lgb.InterpolationColors = cblend;
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }


}
