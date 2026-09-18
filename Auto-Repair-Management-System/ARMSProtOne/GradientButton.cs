using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ARMSProtOne
{
    public class GradientButton : Button
    {
        public int CornerRadius { get; set; } = 10;

        private enum BtnState { Normal, Hover, Down }
        private BtnState state = BtnState.Normal;

        public GradientButton()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        protected override void OnMouseEnter(System.EventArgs e) { state = BtnState.Hover; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(System.EventArgs e) { state = BtnState.Normal; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { state = BtnState.Down; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            state = ClientRectangle.Contains(e.Location) ? BtnState.Hover : BtnState.Normal;
            Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            var g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : BackColor);

            Color a, b;
            switch (state)
            {
                case BtnState.Hover: a = Theme.BtnHoverA; b = Theme.BtnHoverB; break;
                case BtnState.Down: a = Theme.BtnDownA; b = Theme.BtnDownB; break;
                default: a = Theme.BtnNormalA; b = Theme.BtnNormalB; break;
            }

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = Theme.RoundedRect(rect, CornerRadius))
            using (var brush = new LinearGradientBrush(rect, a, b, LinearGradientMode.Horizontal))
            {
                g.FillPath(brush, path);
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
