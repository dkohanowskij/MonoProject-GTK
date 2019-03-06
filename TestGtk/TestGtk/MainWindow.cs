using System;
using Gtk;
using TestLib;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Pressed(object sender, EventArgs e)
    {
        UserManager userManager = new UserManager(this.entry2.Text);

        var dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, userManager.GetGreeting());

        dialog.Run();
        dialog.Destroy();
    }
}
