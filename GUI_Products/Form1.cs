using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI_Products {

  public partial class Form1 : Form {
    private const ushort MV_WIDTH_OPENED = 250;
    private const ushort MV_WIDTH_CLOSEDED = 70;

    public Form1() {
      InitializeComponent();
    }

    // Releases the mouse capture from a window in the current thread and restores normal mouse input processing. 
    // If the function succeeds, the return value is nonzero.
    // If the function fails, the return value is zero.
    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    // Sends the specified message to a window or windows.
    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

    private void BtnSlide_Click(object sender, EventArgs e) {
      SwitchMenuVertical();
    }

    private bool IsVerticalMenuOpened() {
      return MenuVertical.Width == 250 ? true : false;
    }

    private void SwitchMenuVertical() {
      MenuVertical.Width = IsVerticalMenuOpened() ? MV_WIDTH_CLOSEDED : MV_WIDTH_OPENED;
    }

    private void IconClose_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void iconMaximize_Click(object sender, EventArgs e) {
      WindowState = FormWindowState.Maximized;
      iconMaximize.Visible = false;
      iconRestore.Visible = true;
    }

    private void iconRestore_Click(object sender, EventArgs e) {
      WindowState = FormWindowState.Normal;
      iconRestore.Visible = false;
      iconMaximize.Visible = true;
    }

    private void iconMinimize_Click(object sender, EventArgs e) {
      WindowState = FormWindowState.Minimized;
    }

    private void BarreTitle_MouseDown(object sender, MouseEventArgs e) {
      ReleaseCapture();
      SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void OpenFormInPanel(object formChild) {
      if (panelContent.Controls.Count > 0)
        panelContent.Controls.RemoveAt(0);
      Form fm = formChild as Form;
      fm.TopLevel = false;
      fm.Dock = DockStyle.Fill;
      panelContent.Controls.Add(fm);
      panelContent.Tag = fm;
      fm.Show();
    }

    private void btnProd_Click(object sender, EventArgs e) {
      OpenFormInPanel(new Produits());
    }
  }
}
