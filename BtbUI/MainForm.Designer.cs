namespace BtbUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._open_button = new System.Windows.Forms.Button();
			this._main_panel = new System.Windows.Forms.Panel();
			this._main_splitContainer = new System.Windows.Forms.SplitContainer();
			this._battle_treeView = new System.Windows.Forms.TreeView();
			this._resetTransform_button = new System.Windows.Forms.Button();
			this._resetTranslation_button = new System.Windows.Forms.Button();
			this._resetZoom_button = new System.Windows.Forms.Button();
			this._translationY_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._translationX_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._translation_label = new System.Windows.Forms.Label();
			this._zoom_label = new System.Windows.Forms.Label();
			this._zoom_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._setbg_button = new System.Windows.Forms.Button();
			this._current_label = new System.Windows.Forms.Label();
			this._current_textBox = new System.Windows.Forms.TextBox();
			this._regionPenWidth_label = new System.Windows.Forms.Label();
			this._regionPenWidth_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._menu_label = new System.Windows.Forms.Label();
			this._region_groupBox = new System.Windows.Forms.GroupBox();
			this._regionPointSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._pointSize_label = new System.Windows.Forms.Label();
			this._regionSelectAllOpen_button = new System.Windows.Forms.Button();
			this._regionSelectAllClosed_button = new System.Windows.Forms.Button();
			this._regionDeselectAll_button = new System.Windows.Forms.Button();
			this._regionSelectAll_button = new System.Windows.Forms.Button();
			this._toolbar_label = new System.Windows.Forms.Label();
			this._details_splitContainer = new System.Windows.Forms.SplitContainer();
			this._selectedItem_panel = new System.Windows.Forms.Panel();
			this._canvas_groupBox = new System.Windows.Forms.GroupBox();
			this._canvasDrawGrid_label = new System.Windows.Forms.Label();
			this._canvasGridSize_label = new System.Windows.Forms.Label();
			this._canvasGridSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._canvasDrawGrid_checkBox = new System.Windows.Forms.CheckBox();
			this._draw_panel = new BtbUI.AntiFlickerPanel();
			this._main_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._main_splitContainer)).BeginInit();
			this._main_splitContainer.Panel1.SuspendLayout();
			this._main_splitContainer.Panel2.SuspendLayout();
			this._main_splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._translationY_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._translationX_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._zoom_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._regionPenWidth_numericUpDown)).BeginInit();
			this._region_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._regionPointSize_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._details_splitContainer)).BeginInit();
			this._details_splitContainer.Panel1.SuspendLayout();
			this._details_splitContainer.Panel2.SuspendLayout();
			this._details_splitContainer.SuspendLayout();
			this._canvas_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._canvasGridSize_numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// _open_button
			// 
			this._open_button.Location = new System.Drawing.Point(118, 12);
			this._open_button.Name = "_open_button";
			this._open_button.Size = new System.Drawing.Size(100, 23);
			this._open_button.TabIndex = 0;
			this._open_button.Text = "Open";
			this._open_button.UseVisualStyleBackColor = true;
			this._open_button.Click += new System.EventHandler(this._open_button_Click);
			// 
			// _main_panel
			// 
			this._main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._main_panel.Controls.Add(this._main_splitContainer);
			this._main_panel.Location = new System.Drawing.Point(12, 154);
			this._main_panel.Name = "_main_panel";
			this._main_panel.Size = new System.Drawing.Size(1072, 433);
			this._main_panel.TabIndex = 1;
			// 
			// _main_splitContainer
			// 
			this._main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._main_splitContainer.Location = new System.Drawing.Point(0, 0);
			this._main_splitContainer.Name = "_main_splitContainer";
			// 
			// _main_splitContainer.Panel1
			// 
			this._main_splitContainer.Panel1.Controls.Add(this._details_splitContainer);
			// 
			// _main_splitContainer.Panel2
			// 
			this._main_splitContainer.Panel2.Controls.Add(this._resetTransform_button);
			this._main_splitContainer.Panel2.Controls.Add(this._resetTranslation_button);
			this._main_splitContainer.Panel2.Controls.Add(this._resetZoom_button);
			this._main_splitContainer.Panel2.Controls.Add(this._translationY_numericUpDown);
			this._main_splitContainer.Panel2.Controls.Add(this._translationX_numericUpDown);
			this._main_splitContainer.Panel2.Controls.Add(this._translation_label);
			this._main_splitContainer.Panel2.Controls.Add(this._zoom_label);
			this._main_splitContainer.Panel2.Controls.Add(this._zoom_numericUpDown);
			this._main_splitContainer.Panel2.Controls.Add(this._draw_panel);
			this._main_splitContainer.Size = new System.Drawing.Size(1072, 433);
			this._main_splitContainer.SplitterDistance = 205;
			this._main_splitContainer.TabIndex = 0;
			// 
			// _battle_treeView
			// 
			this._battle_treeView.CheckBoxes = true;
			this._battle_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._battle_treeView.FullRowSelect = true;
			this._battle_treeView.HideSelection = false;
			this._battle_treeView.HotTracking = true;
			this._battle_treeView.Location = new System.Drawing.Point(0, 0);
			this._battle_treeView.Name = "_battle_treeView";
			this._battle_treeView.ShowLines = false;
			this._battle_treeView.Size = new System.Drawing.Size(205, 251);
			this._battle_treeView.TabIndex = 0;
			this._battle_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._battle_treeView_AfterSelect);
			this._battle_treeView.MouseLeave += new System.EventHandler(this._battle_treeView_MouseLeave);
			this._battle_treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this._battle_treeView_MouseMove);
			// 
			// _resetTransform_button
			// 
			this._resetTransform_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._resetTransform_button.Location = new System.Drawing.Point(742, 404);
			this._resetTransform_button.Name = "_resetTransform_button";
			this._resetTransform_button.Size = new System.Drawing.Size(100, 23);
			this._resetTransform_button.TabIndex = 25;
			this._resetTransform_button.Text = "Reset Transform";
			this._resetTransform_button.UseVisualStyleBackColor = true;
			this._resetTransform_button.Click += new System.EventHandler(this._resetTransform_button_Click);
			// 
			// _resetTranslation_button
			// 
			this._resetTranslation_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._resetTranslation_button.Location = new System.Drawing.Point(636, 404);
			this._resetTranslation_button.Name = "_resetTranslation_button";
			this._resetTranslation_button.Size = new System.Drawing.Size(100, 23);
			this._resetTranslation_button.TabIndex = 24;
			this._resetTranslation_button.Text = "Reset Translation";
			this._resetTranslation_button.UseVisualStyleBackColor = true;
			this._resetTranslation_button.Click += new System.EventHandler(this._resetTranslation_button_Click);
			// 
			// _resetZoom_button
			// 
			this._resetZoom_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._resetZoom_button.Location = new System.Drawing.Point(530, 404);
			this._resetZoom_button.Name = "_resetZoom_button";
			this._resetZoom_button.Size = new System.Drawing.Size(100, 23);
			this._resetZoom_button.TabIndex = 23;
			this._resetZoom_button.Text = "Reset Zoom";
			this._resetZoom_button.UseVisualStyleBackColor = true;
			this._resetZoom_button.Click += new System.EventHandler(this._resetZoom_button_Click);
			// 
			// _translationY_numericUpDown
			// 
			this._translationY_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._translationY_numericUpDown.Location = new System.Drawing.Point(424, 407);
			this._translationY_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this._translationY_numericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this._translationY_numericUpDown.Name = "_translationY_numericUpDown";
			this._translationY_numericUpDown.Size = new System.Drawing.Size(100, 20);
			this._translationY_numericUpDown.TabIndex = 22;
			this._translationY_numericUpDown.ValueChanged += new System.EventHandler(this._translationY_numericUpDown_ValueChanged);
			// 
			// _translationX_numericUpDown
			// 
			this._translationX_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._translationX_numericUpDown.Location = new System.Drawing.Point(318, 407);
			this._translationX_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this._translationX_numericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
			this._translationX_numericUpDown.Name = "_translationX_numericUpDown";
			this._translationX_numericUpDown.Size = new System.Drawing.Size(100, 20);
			this._translationX_numericUpDown.TabIndex = 20;
			this._translationX_numericUpDown.ValueChanged += new System.EventHandler(this._translationX_numericUpDown_ValueChanged);
			// 
			// _translation_label
			// 
			this._translation_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._translation_label.AutoSize = true;
			this._translation_label.Location = new System.Drawing.Point(217, 409);
			this._translation_label.Name = "_translation_label";
			this._translation_label.Size = new System.Drawing.Size(87, 13);
			this._translation_label.TabIndex = 19;
			this._translation_label.Text = "Canvas Pan X/Y";
			// 
			// _zoom_label
			// 
			this._zoom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._zoom_label.AutoSize = true;
			this._zoom_label.Location = new System.Drawing.Point(2, 409);
			this._zoom_label.Name = "_zoom_label";
			this._zoom_label.Size = new System.Drawing.Size(73, 13);
			this._zoom_label.TabIndex = 2;
			this._zoom_label.Text = "Canvas Zoom";
			// 
			// _zoom_numericUpDown
			// 
			this._zoom_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._zoom_numericUpDown.DecimalPlaces = 1;
			this._zoom_numericUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			this._zoom_numericUpDown.Location = new System.Drawing.Point(106, 407);
			this._zoom_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this._zoom_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._zoom_numericUpDown.Name = "_zoom_numericUpDown";
			this._zoom_numericUpDown.Size = new System.Drawing.Size(100, 20);
			this._zoom_numericUpDown.TabIndex = 1;
			this._zoom_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._zoom_numericUpDown.ValueChanged += new System.EventHandler(this._zoom_numericUpDown_ValueChanged);
			// 
			// _setbg_button
			// 
			this._setbg_button.Location = new System.Drawing.Point(224, 12);
			this._setbg_button.Name = "_setbg_button";
			this._setbg_button.Size = new System.Drawing.Size(100, 23);
			this._setbg_button.TabIndex = 2;
			this._setbg_button.Text = "Set Background";
			this._setbg_button.UseVisualStyleBackColor = true;
			this._setbg_button.Click += new System.EventHandler(this._setbg_button_Click);
			// 
			// _current_label
			// 
			this._current_label.AutoSize = true;
			this._current_label.Location = new System.Drawing.Point(12, 46);
			this._current_label.Name = "_current_label";
			this._current_label.Size = new System.Drawing.Size(81, 13);
			this._current_label.TabIndex = 4;
			this._current_label.Text = "Current BTB file";
			// 
			// _current_textBox
			// 
			this._current_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._current_textBox.Location = new System.Drawing.Point(118, 43);
			this._current_textBox.Name = "_current_textBox";
			this._current_textBox.ReadOnly = true;
			this._current_textBox.Size = new System.Drawing.Size(966, 20);
			this._current_textBox.TabIndex = 5;
			// 
			// _regionPenWidth_label
			// 
			this._regionPenWidth_label.AutoSize = true;
			this._regionPenWidth_label.Location = new System.Drawing.Point(6, 53);
			this._regionPenWidth_label.Name = "_regionPenWidth_label";
			this._regionPenWidth_label.Size = new System.Drawing.Size(58, 13);
			this._regionPenWidth_label.TabIndex = 7;
			this._regionPenWidth_label.Text = "Line Width";
			// 
			// _regionPenWidth_numericUpDown
			// 
			this._regionPenWidth_numericUpDown.Location = new System.Drawing.Point(113, 51);
			this._regionPenWidth_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._regionPenWidth_numericUpDown.Name = "_regionPenWidth_numericUpDown";
			this._regionPenWidth_numericUpDown.Size = new System.Drawing.Size(99, 20);
			this._regionPenWidth_numericUpDown.TabIndex = 9;
			this._regionPenWidth_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._regionPenWidth_numericUpDown.ValueChanged += new System.EventHandler(this._regionPenWidth_numericUpDown_ValueChanged);
			// 
			// _menu_label
			// 
			this._menu_label.AutoSize = true;
			this._menu_label.Location = new System.Drawing.Point(12, 17);
			this._menu_label.Name = "_menu_label";
			this._menu_label.Size = new System.Drawing.Size(53, 13);
			this._menu_label.TabIndex = 10;
			this._menu_label.Text = "File Menu";
			// 
			// _region_groupBox
			// 
			this._region_groupBox.Controls.Add(this._regionPointSize_numericUpDown);
			this._region_groupBox.Controls.Add(this._pointSize_label);
			this._region_groupBox.Controls.Add(this._regionPenWidth_numericUpDown);
			this._region_groupBox.Controls.Add(this._regionSelectAllOpen_button);
			this._region_groupBox.Controls.Add(this._regionSelectAllClosed_button);
			this._region_groupBox.Controls.Add(this._regionPenWidth_label);
			this._region_groupBox.Controls.Add(this._regionDeselectAll_button);
			this._region_groupBox.Controls.Add(this._regionSelectAll_button);
			this._region_groupBox.Enabled = false;
			this._region_groupBox.Location = new System.Drawing.Point(118, 69);
			this._region_groupBox.Name = "_region_groupBox";
			this._region_groupBox.Size = new System.Drawing.Size(428, 79);
			this._region_groupBox.TabIndex = 11;
			this._region_groupBox.TabStop = false;
			this._region_groupBox.Text = "Region Options";
			// 
			// _regionPointSize_numericUpDown
			// 
			this._regionPointSize_numericUpDown.Location = new System.Drawing.Point(323, 51);
			this._regionPointSize_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._regionPointSize_numericUpDown.Name = "_regionPointSize_numericUpDown";
			this._regionPointSize_numericUpDown.Size = new System.Drawing.Size(99, 20);
			this._regionPointSize_numericUpDown.TabIndex = 22;
			this._regionPointSize_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._regionPointSize_numericUpDown.ValueChanged += new System.EventHandler(this._regionPointSize_numericUpDown_ValueChanged);
			// 
			// _pointSize_label
			// 
			this._pointSize_label.AutoSize = true;
			this._pointSize_label.Location = new System.Drawing.Point(218, 53);
			this._pointSize_label.Name = "_pointSize_label";
			this._pointSize_label.Size = new System.Drawing.Size(54, 13);
			this._pointSize_label.TabIndex = 21;
			this._pointSize_label.Text = "Point Size";
			// 
			// _regionSelectAllOpen_button
			// 
			this._regionSelectAllOpen_button.Location = new System.Drawing.Point(218, 19);
			this._regionSelectAllOpen_button.Name = "_regionSelectAllOpen_button";
			this._regionSelectAllOpen_button.Size = new System.Drawing.Size(100, 23);
			this._regionSelectAllOpen_button.TabIndex = 15;
			this._regionSelectAllOpen_button.Text = "Select All Open";
			this._regionSelectAllOpen_button.UseVisualStyleBackColor = true;
			this._regionSelectAllOpen_button.Click += new System.EventHandler(this._regionSelectAllOpen_button_Click);
			// 
			// _regionSelectAllClosed_button
			// 
			this._regionSelectAllClosed_button.Location = new System.Drawing.Point(112, 19);
			this._regionSelectAllClosed_button.Name = "_regionSelectAllClosed_button";
			this._regionSelectAllClosed_button.Size = new System.Drawing.Size(100, 23);
			this._regionSelectAllClosed_button.TabIndex = 14;
			this._regionSelectAllClosed_button.Text = "Select All Closed";
			this._regionSelectAllClosed_button.UseVisualStyleBackColor = true;
			this._regionSelectAllClosed_button.Click += new System.EventHandler(this._regionSelectAllClosed_button_Click);
			// 
			// _regionDeselectAll_button
			// 
			this._regionDeselectAll_button.Location = new System.Drawing.Point(323, 19);
			this._regionDeselectAll_button.Name = "_regionDeselectAll_button";
			this._regionDeselectAll_button.Size = new System.Drawing.Size(100, 23);
			this._regionDeselectAll_button.TabIndex = 13;
			this._regionDeselectAll_button.Text = "Deselect All";
			this._regionDeselectAll_button.UseVisualStyleBackColor = true;
			this._regionDeselectAll_button.Click += new System.EventHandler(this._regionDeselectAll_button_Click);
			// 
			// _regionSelectAll_button
			// 
			this._regionSelectAll_button.Location = new System.Drawing.Point(6, 19);
			this._regionSelectAll_button.Name = "_regionSelectAll_button";
			this._regionSelectAll_button.Size = new System.Drawing.Size(100, 23);
			this._regionSelectAll_button.TabIndex = 12;
			this._regionSelectAll_button.Text = "Select All";
			this._regionSelectAll_button.UseVisualStyleBackColor = true;
			this._regionSelectAll_button.Click += new System.EventHandler(this._regionSelectAll_button_Click);
			// 
			// _toolbar_label
			// 
			this._toolbar_label.AutoSize = true;
			this._toolbar_label.Location = new System.Drawing.Point(12, 73);
			this._toolbar_label.Name = "_toolbar_label";
			this._toolbar_label.Size = new System.Drawing.Size(43, 13);
			this._toolbar_label.TabIndex = 12;
			this._toolbar_label.Text = "Toolbar";
			// 
			// _details_splitContainer
			// 
			this._details_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._details_splitContainer.Location = new System.Drawing.Point(0, 0);
			this._details_splitContainer.Name = "_details_splitContainer";
			this._details_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _details_splitContainer.Panel1
			// 
			this._details_splitContainer.Panel1.Controls.Add(this._battle_treeView);
			// 
			// _details_splitContainer.Panel2
			// 
			this._details_splitContainer.Panel2.Controls.Add(this._selectedItem_panel);
			this._details_splitContainer.Size = new System.Drawing.Size(205, 433);
			this._details_splitContainer.SplitterDistance = 251;
			this._details_splitContainer.TabIndex = 0;
			// 
			// _selectedItem_panel
			// 
			this._selectedItem_panel.BackColor = System.Drawing.SystemColors.Control;
			this._selectedItem_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._selectedItem_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._selectedItem_panel.Location = new System.Drawing.Point(0, 0);
			this._selectedItem_panel.Name = "_selectedItem_panel";
			this._selectedItem_panel.Size = new System.Drawing.Size(205, 178);
			this._selectedItem_panel.TabIndex = 0;
			// 
			// _canvas_groupBox
			// 
			this._canvas_groupBox.Controls.Add(this._canvasDrawGrid_checkBox);
			this._canvas_groupBox.Controls.Add(this._canvasGridSize_numericUpDown);
			this._canvas_groupBox.Controls.Add(this._canvasGridSize_label);
			this._canvas_groupBox.Controls.Add(this._canvasDrawGrid_label);
			this._canvas_groupBox.Location = new System.Drawing.Point(552, 69);
			this._canvas_groupBox.Name = "_canvas_groupBox";
			this._canvas_groupBox.Size = new System.Drawing.Size(218, 79);
			this._canvas_groupBox.TabIndex = 13;
			this._canvas_groupBox.TabStop = false;
			this._canvas_groupBox.Text = "Canvas";
			// 
			// _canvasDrawGrid_label
			// 
			this._canvasDrawGrid_label.AutoSize = true;
			this._canvasDrawGrid_label.Location = new System.Drawing.Point(6, 24);
			this._canvasDrawGrid_label.Name = "_canvasDrawGrid_label";
			this._canvasDrawGrid_label.Size = new System.Drawing.Size(54, 13);
			this._canvasDrawGrid_label.TabIndex = 0;
			this._canvasDrawGrid_label.Text = "Draw Grid";
			// 
			// _canvasGridSize_label
			// 
			this._canvasGridSize_label.AutoSize = true;
			this._canvasGridSize_label.Location = new System.Drawing.Point(6, 53);
			this._canvasGridSize_label.Name = "_canvasGridSize_label";
			this._canvasGridSize_label.Size = new System.Drawing.Size(49, 13);
			this._canvasGridSize_label.TabIndex = 25;
			this._canvasGridSize_label.Text = "Grid Size";
			// 
			// _canvasGridSize_numericUpDown
			// 
			this._canvasGridSize_numericUpDown.Location = new System.Drawing.Point(112, 51);
			this._canvasGridSize_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._canvasGridSize_numericUpDown.Name = "_canvasGridSize_numericUpDown";
			this._canvasGridSize_numericUpDown.Size = new System.Drawing.Size(100, 20);
			this._canvasGridSize_numericUpDown.TabIndex = 28;
			this._canvasGridSize_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._canvasGridSize_numericUpDown.ValueChanged += new System.EventHandler(this._canvasGridSize_numericUpDown_ValueChanged);
			// 
			// _canvasDrawGrid_checkBox
			// 
			this._canvasDrawGrid_checkBox.AutoSize = true;
			this._canvasDrawGrid_checkBox.Location = new System.Drawing.Point(113, 23);
			this._canvasDrawGrid_checkBox.Name = "_canvasDrawGrid_checkBox";
			this._canvasDrawGrid_checkBox.Size = new System.Drawing.Size(15, 14);
			this._canvasDrawGrid_checkBox.TabIndex = 29;
			this._canvasDrawGrid_checkBox.UseVisualStyleBackColor = true;
			this._canvasDrawGrid_checkBox.CheckedChanged += new System.EventHandler(this._canvasDrawGrid_checkBox_CheckedChanged);
			// 
			// _draw_panel
			// 
			this._draw_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._draw_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
			this._draw_panel.Location = new System.Drawing.Point(0, 0);
			this._draw_panel.Name = "_draw_panel";
			this._draw_panel.Size = new System.Drawing.Size(863, 401);
			this._draw_panel.TabIndex = 0;
			this._draw_panel.Paint += new System.Windows.Forms.PaintEventHandler(this._draw_panel_Paint);
			this._draw_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this._draw_panel_MouseDown);
			this._draw_panel.MouseHover += new System.EventHandler(this._draw_panel_MouseHover);
			this._draw_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this._draw_panel_MouseMove);
			this._draw_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this._draw_panel_MouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 599);
			this.Controls.Add(this._canvas_groupBox);
			this.Controls.Add(this._toolbar_label);
			this.Controls.Add(this._region_groupBox);
			this.Controls.Add(this._menu_label);
			this.Controls.Add(this._current_textBox);
			this.Controls.Add(this._current_label);
			this.Controls.Add(this._setbg_button);
			this.Controls.Add(this._main_panel);
			this.Controls.Add(this._open_button);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "BTB UI";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this._main_panel.ResumeLayout(false);
			this._main_splitContainer.Panel1.ResumeLayout(false);
			this._main_splitContainer.Panel2.ResumeLayout(false);
			this._main_splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._main_splitContainer)).EndInit();
			this._main_splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._translationY_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._translationX_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._zoom_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._regionPenWidth_numericUpDown)).EndInit();
			this._region_groupBox.ResumeLayout(false);
			this._region_groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._regionPointSize_numericUpDown)).EndInit();
			this._details_splitContainer.Panel1.ResumeLayout(false);
			this._details_splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._details_splitContainer)).EndInit();
			this._details_splitContainer.ResumeLayout(false);
			this._canvas_groupBox.ResumeLayout(false);
			this._canvas_groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._canvasGridSize_numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _open_button;
        private System.Windows.Forms.Panel _main_panel;
        private System.Windows.Forms.SplitContainer _main_splitContainer;
        private System.Windows.Forms.TreeView _battle_treeView;
        private System.Windows.Forms.Button _setbg_button;
        private System.Windows.Forms.Label _zoom_label;
        private System.Windows.Forms.NumericUpDown _zoom_numericUpDown;
        private System.Windows.Forms.Label _current_label;
        private System.Windows.Forms.TextBox _current_textBox;
        private System.Windows.Forms.Label _regionPenWidth_label;
        private System.Windows.Forms.NumericUpDown _regionPenWidth_numericUpDown;
        private System.Windows.Forms.Label _menu_label;
        private System.Windows.Forms.GroupBox _region_groupBox;
        private System.Windows.Forms.Button _regionDeselectAll_button;
        private System.Windows.Forms.Button _regionSelectAll_button;
        private System.Windows.Forms.Button _regionSelectAllOpen_button;
        private System.Windows.Forms.Button _regionSelectAllClosed_button;
        private System.Windows.Forms.Label _toolbar_label;
        private System.Windows.Forms.NumericUpDown _translationY_numericUpDown;
        private System.Windows.Forms.NumericUpDown _translationX_numericUpDown;
        private System.Windows.Forms.Label _translation_label;
        private System.Windows.Forms.Button _resetTransform_button;
        private System.Windows.Forms.Button _resetTranslation_button;
        private System.Windows.Forms.Button _resetZoom_button;
        private System.Windows.Forms.NumericUpDown _regionPointSize_numericUpDown;
        private System.Windows.Forms.Label _pointSize_label;
		private AntiFlickerPanel _draw_panel;
		private System.Windows.Forms.SplitContainer _details_splitContainer;
		private System.Windows.Forms.Panel _selectedItem_panel;
		private System.Windows.Forms.GroupBox _canvas_groupBox;
		private System.Windows.Forms.CheckBox _canvasDrawGrid_checkBox;
		private System.Windows.Forms.NumericUpDown _canvasGridSize_numericUpDown;
		private System.Windows.Forms.Label _canvasGridSize_label;
		private System.Windows.Forms.Label _canvasDrawGrid_label;
	}
}

