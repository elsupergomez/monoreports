
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action FileAction1;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action HelpAction1;
	private global::Gtk.Action executeAction;
	private global::Gtk.Action Action;
	private global::Gtk.Action aboutAction;
	private global::Gtk.Action zoomFitAction;
	private global::Gtk.Action Action1;
	private global::Gtk.Action openAction;
	private global::Gtk.Action saveAction;
	private global::Gtk.Action executeAction1;
	private global::Gtk.Action dialogErrorAction;
	private global::Gtk.ToggleAction editAction;
	private global::Gtk.Action sortAscendingAction;
	private global::Gtk.Action EditAction;
	private global::Gtk.Action ReportSettingsAction;
	private global::Gtk.VBox mainVbox;
	private global::Gtk.MenuBar mainMenubar;
	private global::Gtk.Toolbar mainToolbar;
	private global::Gtk.HBox contentHbox;
	private global::Gtk.HPaned mainHPaned;
	private global::MonoReports.Gui.Widgets.MainDesignView maindesignview1;
	private global::Gtk.VPaned rightVPaned;
	private global::MonoReports.Gui.Widgets.ReportExplorer reportExplorer;
	private global::PropertyGrid.PropertyGrid mainPropertygrid;
	private global::Gtk.Statusbar bottomStatusbar;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.FileAction1 = new global::Gtk.Action ("FileAction1", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction1, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.quitAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.HelpAction1 = new global::Gtk.Action ("HelpAction1", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.HelpAction1, null);
		this.executeAction = new global::Gtk.Action ("executeAction", null, null, "gtk-execute");
		w1.Add (this.executeAction, null);
		this.Action = new global::Gtk.Action ("Action", null, null, null);
		w1.Add (this.Action, null);
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, "gtk-about");
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.aboutAction, null);
		this.zoomFitAction = new global::Gtk.Action ("zoomFitAction", null, null, "gtk-zoom-fit");
		w1.Add (this.zoomFitAction, null);
		this.Action1 = new global::Gtk.Action ("Action1", null, null, null);
		w1.Add (this.Action1, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("_Otwórz"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Otwórz");
		w1.Add (this.openAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("_Zapisz"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Zapisz");
		w1.Add (this.saveAction, null);
		this.executeAction1 = new global::Gtk.Action ("executeAction1", null, null, "gtk-execute");
		w1.Add (this.executeAction1, null);
		this.dialogErrorAction = new global::Gtk.Action ("dialogErrorAction", null, null, "gtk-dialog-error");
		w1.Add (this.dialogErrorAction, null);
		this.editAction = new global::Gtk.ToggleAction ("editAction", null, null, "gtk-edit");
		w1.Add (this.editAction, null);
		this.sortAscendingAction = new global::Gtk.Action ("sortAscendingAction", null, null, "gtk-sort-ascending");
		w1.Add (this.sortAscendingAction, null);
		this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
		w1.Add (this.EditAction, null);
		this.ReportSettingsAction = new global::Gtk.Action ("ReportSettingsAction", global::Mono.Unix.Catalog.GetString ("Report Settings"), null, null);
		this.ReportSettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Report Settings");
		w1.Add (this.ReportSettingsAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MonoReports");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.AllowShrink = true;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainVbox = new global::Gtk.VBox ();
		this.mainVbox.Name = "mainVbox";
		this.mainVbox.Spacing = -1;
		// Container child mainVbox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='mainMenubar'><menu name='FileAction1' action='FileAction1'><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='EditAction' action='EditAction'><menuitem name='ReportSettingsAction' action='ReportSettingsAction'/></menu><menu name='HelpAction1' action='HelpAction1'><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
		this.mainMenubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/mainMenubar")));
		this.mainMenubar.Name = "mainMenubar";
		this.mainVbox.Add (this.mainMenubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.mainMenubar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child mainVbox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='mainToolbar'/></ui>");
		this.mainToolbar = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/mainToolbar")));
		this.mainToolbar.Name = "mainToolbar";
		this.mainToolbar.ShowArrow = false;
		this.mainToolbar.IconSize = ((global::Gtk.IconSize)(1));
		this.mainVbox.Add (this.mainToolbar);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.mainToolbar]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child mainVbox.Gtk.Box+BoxChild
		this.contentHbox = new global::Gtk.HBox ();
		this.contentHbox.Name = "contentHbox";
		this.contentHbox.Spacing = 6;
		// Container child contentHbox.Gtk.Box+BoxChild
		this.mainHPaned = new global::Gtk.HPaned ();
		this.mainHPaned.CanFocus = true;
		this.mainHPaned.Name = "mainHPaned";
		this.mainHPaned.Position = 606;
		// Container child mainHPaned.Gtk.Paned+PanedChild
		this.maindesignview1 = new global::MonoReports.Gui.Widgets.MainDesignView ();
		this.maindesignview1.Events = ((global::Gdk.EventMask)(256));
		this.maindesignview1.Name = "maindesignview1";
		this.mainHPaned.Add (this.maindesignview1);
		global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.mainHPaned [this.maindesignview1]));
		w4.Resize = false;
		// Container child mainHPaned.Gtk.Paned+PanedChild
		this.rightVPaned = new global::Gtk.VPaned ();
		this.rightVPaned.CanFocus = true;
		this.rightVPaned.Name = "rightVPaned";
		this.rightVPaned.Position = 291;
		// Container child rightVPaned.Gtk.Paned+PanedChild
		this.reportExplorer = new global::MonoReports.Gui.Widgets.ReportExplorer ();
		this.reportExplorer.Name = "reportExplorer";
		this.rightVPaned.Add (this.reportExplorer);
		global::Gtk.Paned.PanedChild w5 = ((global::Gtk.Paned.PanedChild)(this.rightVPaned [this.reportExplorer]));
		w5.Resize = false;
		// Container child rightVPaned.Gtk.Paned+PanedChild
		this.mainPropertygrid = new global::PropertyGrid.PropertyGrid ();
		this.mainPropertygrid.Name = "mainPropertygrid";
		this.mainPropertygrid.ShowToolbar = false;
		this.mainPropertygrid.ShowHelp = false;
		this.rightVPaned.Add (this.mainPropertygrid);
		this.mainHPaned.Add (this.rightVPaned);
		global::Gtk.Paned.PanedChild w7 = ((global::Gtk.Paned.PanedChild)(this.mainHPaned [this.rightVPaned]));
		w7.Resize = false;
		this.contentHbox.Add (this.mainHPaned);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.contentHbox [this.mainHPaned]));
		w8.Position = 0;
		this.mainVbox.Add (this.contentHbox);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.contentHbox]));
		w9.Position = 2;
		// Container child mainVbox.Gtk.Box+BoxChild
		this.bottomStatusbar = new global::Gtk.Statusbar ();
		this.bottomStatusbar.Name = "bottomStatusbar";
		this.bottomStatusbar.Spacing = 6;
		this.mainVbox.Add (this.bottomStatusbar);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.bottomStatusbar]));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		this.Add (this.mainVbox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1027;
		this.DefaultHeight = 697;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.aboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.saveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.editAction.Activated += new global::System.EventHandler (this.OnEditActionActivated);
		this.ReportSettingsAction.Activated += new global::System.EventHandler (this.OnReportSettingsActionActivated);
		this.mainPropertygrid.Changed += new global::System.EventHandler (this.OnMainPropertygridChanged);
	}
}
