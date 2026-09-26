using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ARMSProtOne
{
    internal static class Theme
    {
        public static readonly Color BgTop = ColorTranslator.FromHtml("#06181C");
        public static readonly Color BgBottom = ColorTranslator.FromHtml("#0A2A2E");
        public static readonly Color GlowTL = ColorTranslator.FromHtml("#0E3B33");
        public static readonly Color GlowBR = ColorTranslator.FromHtml("#0B3A4A");
        public static readonly Color CardTop = ColorTranslator.FromHtml("#0E272C");
        public static readonly Color CardBottom = ColorTranslator.FromHtml("#0B1F24");
        public static readonly Color CardBorder = ColorTranslator.FromHtml("#1E4A55");
        public static readonly Color CardGlow = ColorTranslator.FromHtml("#00C2FF");
        public static readonly Color PillFill = ColorTranslator.FromHtml("#12323A");
        public static readonly Color PillBorder = ColorTranslator.FromHtml("#21505C");
        public static readonly Color FieldLabel = ColorTranslator.FromHtml("#4FB3D9");
        public static readonly Color TextLight = ColorTranslator.FromHtml("#EAF6F9");
        public static readonly Color SubtitleColor = ColorTranslator.FromHtml("#7FA8B4");
        public static readonly Color RememberColor = ColorTranslator.FromHtml("#9FC4CE");
        public static readonly Color DividerColor = ColorTranslator.FromHtml("#1B4450");
        public static readonly Color DemoColor = ColorTranslator.FromHtml("#6F97A2");
        public static readonly Color VersionColor = ColorTranslator.FromHtml("#4A6E78");
        public static readonly Color LogoStart = ColorTranslator.FromHtml("#00A8E8");
        public static readonly Color LogoEnd = ColorTranslator.FromHtml("#0077C2");
        public static readonly Color BtnNormalA = ColorTranslator.FromHtml("#00C2FF");
        public static readonly Color BtnNormalB = ColorTranslator.FromHtml("#0066CC");
        public static readonly Color BtnHoverA = ColorTranslator.FromHtml("#22D0FF");
        public static readonly Color BtnHoverB = ColorTranslator.FromHtml("#0A78E0");
        public static readonly Color BtnDownA = ColorTranslator.FromHtml("#0096D6");
        public static readonly Color BtnDownB = ColorTranslator.FromHtml("#0052A8");

        public static GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public enum GlyphType { User, Lock, Eye }

        public static Bitmap CreateGlyph(GlyphType type, Color drawColor, int size = 24)
        {
            var bmp = new Bitmap(size, size, PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(bmp))
            using (var pen = new Pen(drawColor, 1.8f) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            using (var brush = new SolidBrush(drawColor))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                switch (type)
                {
                    case GlyphType.User:
                        g.FillEllipse(brush, 8, 4, 8, 8);
                        g.DrawArc(pen, 4, 13, 16, 12, 180, 180);
                        break;
                    case GlyphType.Lock:
                        using (var body = RoundedRect(new Rectangle(5, 11, 14, 10), 3))
                            g.DrawPath(pen, body);
                        g.DrawArc(pen, 8, 4, 8, 10, 180, 180);
                        break;
                    case GlyphType.Eye:
                        var eyeRect = new Rectangle(2, 7, 20, 10);
                        g.DrawArc(pen, eyeRect, 200, 140);
                        g.DrawArc(pen, eyeRect, 20, 140);
                        g.FillEllipse(brush, 10, 10, 4, 4);
                        break;
                }
            }
            return bmp;
        }
    }
}
