using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARMSProtOne
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\GitHub Exports\\ARMS_DBInside\\Auto-Repair-Management-System\\Auto-Repair-Management-System\\ARMSProtOne\\ARMS_Database.mdf\";Integrated Security=True");

        private Bitmap userGlyph, lockGlyph, eyeGlyph;

        private Rectangle CardRect => new Rectangle((ClientSize.Width - 420) / 2, (ClientSize.Height - 480) / 2, 420, 480);
        private Rectangle PillUserRect => new Rectangle(CardRect.X + 40, CardRect.Y + 188, 340, 44);
        private Rectangle PillPassRect => new Rectangle(CardRect.X + 40, CardRect.Y + 260, 340, 44);

        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.AcceptButton = btnLogin;
            LoadGlyphs(); //To Remove, replace with image icons
        }

        private void LoadGlyphs() //To Remove, replace with image icons
        {
            userGlyph = Theme.CreateGlyph(Theme.GlyphType.User, Theme.FieldLabel);
            lockGlyph = Theme.CreateGlyph(Theme.GlyphType.Lock, Theme.FieldLabel);
            eyeGlyph = Theme.CreateGlyph(Theme.GlyphType.Eye, Theme.FieldLabel);
            picUserIcon.Image = userGlyph;
            picPasswordIcon.Image = lockGlyph;
            picEyeIcon.Image = eyeGlyph;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var bgBrush = new LinearGradientBrush(ClientRectangle, Theme.BgTop, Theme.BgBottom, 135f))
                g.FillRectangle(bgBrush, ClientRectangle);

            DrawGlow(g, new Point(0, 0), Theme.GlowTL);
            DrawGlow(g, new Point(ClientSize.Width, ClientSize.Height), Theme.GlowBR);

            var card = CardRect;

            for (int i = 3; i >= 1; i--)
            {
                var glowRect = Rectangle.Inflate(card, i * 2, i * 2);
                int alpha = i == 1 ? 28 : (i == 2 ? 16 : 8);
                using (var path = Theme.RoundedRect(glowRect, 16 + i * 2))
                using (var pen = new Pen(Color.FromArgb(alpha, Theme.CardGlow), 1.5f))
                    g.DrawPath(pen, path);
            }

            using (var cardPath = Theme.RoundedRect(card, 16))
            using (var cardBrush = new LinearGradientBrush(card, Theme.CardTop, Theme.CardBottom, 90f))
            {
                g.FillPath(cardBrush, cardPath);
                using (var borderPen = new Pen(Theme.CardBorder, 1f))
                    g.DrawPath(borderPen, cardPath);
            }

            var logoRect = new Rectangle(card.X + 182, card.Y + 28, 56, 56);
            using (var logoPath = Theme.RoundedRect(logoRect, 14))
            using (var logoBrush = new LinearGradientBrush(logoRect, Theme.LogoStart, Theme.LogoEnd, 45f))
            {
                g.FillPath(logoBrush, logoPath);
                TextRenderer.DrawText(g, "AC", new Font("Segoe UI", 18F, FontStyle.Bold), logoRect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            DrawPill(g, PillUserRect);
            DrawPill(g, PillPassRect);

            using (var dividerPen = new Pen(Theme.DividerColor, 1f))
                g.DrawLine(dividerPen, card.X + 40, card.Y + 414, card.X + 380, card.Y + 414);
        }

        private void DrawGlow(Graphics g, Point center, Color color)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(center.X - 220, center.Y - 220, 440, 440);
                using (var brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = Color.FromArgb(60, color);
                    brush.SurroundColors = new[] { Color.Transparent };
                    g.FillPath(brush, path);
                }
            }
        }

        private void DrawPill(Graphics g, Rectangle rect)
        {
            using (var path = Theme.RoundedRect(rect, 10))
            using (var brush = new SolidBrush(Theme.PillFill))
            using (var pen = new Pen(Theme.PillBorder, 1f))
            {
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }
        }

        private void picEyeIcon_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                int matchCount = (int)cmd.ExecuteScalar();

                if (matchCount == 0)
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                OpenMainSystem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to log in: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void OpenMainSystem()
        {
            this.Hide();

            var mainForm = new BaseForm();
            mainForm.FormClosed += (s, ev) => this.Close();
            mainForm.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            userGlyph?.Dispose();
            lockGlyph?.Dispose();
            eyeGlyph?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
