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
			this._details_splitContainer = new System.Windows.Forms.SplitContainer();
			this._battle_treeView = new System.Windows.Forms.TreeView();
			this._selectedItem_panel = new System.Windows.Forms.Panel();
			this._canvasDrawGrid_checkBox = new System.Windows.Forms.CheckBox();
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
			this._calcWalkable_button = new System.Windows.Forms.Button();
			this._regionFillSelected_checkBox = new System.Windows.Forms.CheckBox();
			this._regionSelectAllOpen_button = new System.Windows.Forms.Button();
			this._regionSelectAllClosed_button = new System.Windows.Forms.Button();
			this._regionDeselectAll_button = new System.Windows.Forms.Button();
			this._regionSelectAll_button = new System.Windows.Forms.Button();
			this._regionPointSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._pointSize_label = new System.Windows.Forms.Label();
			this._toolbar_label = new System.Windows.Forms.Label();
			this._canvasGridSize_numericUpDown = new System.Windows.Forms.NumericUpDown();
			this._canvasGridSize_label = new System.Windows.Forms.Label();
			this._toolbar_tabControl = new System.Windows.Forms.TabControl();
			this._actions_tabPage = new System.Windows.Forms.TabPage();
			this._options_tabPage = new System.Windows.Forms.TabPage();
			this._optionsDraw_groupBox = new System.Windows.Forms.GroupBox();
			this._save_button = new System.Windows.Forms.Button();
			this._obstacle_groupBox = new System.Windows.Forms.GroupBox();
			this._delimeter0_panel = new System.Windows.Forms.Panel();
			this._obstacleSelectAll_button = new System.Windows.Forms.Button();
			this._obstacleSelectMove_button = new System.Windows.Forms.Button();
			this._obstacleSelectProj_button = new System.Windows.Forms.Button();
			this._obstacleDeselectAll_button = new System.Windows.Forms.Button();
			this._draw_panel = new BtbUI.AntiFlickerPanel();
			this._main_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._main_splitContainer)).BeginInit();
			this._main_splitContainer.Panel1.SuspendLayout();
			this._main_splitContainer.Panel2.SuspendLayout();
			this._main_splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._details_splitContainer)).BeginInit();
			this._details_splitContainer.Panel1.SuspendLayout();
			this._details_splitContainer.Panel2.SuspendLayout();
			this._details_splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._translationY_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._translationX_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._zoom_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._regionPenWidth_numericUpDown)).BeginInit();
			this._region_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._regionPointSize_numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._canvasGridSize_numericUpDown)).BeginInit();
			this._toolbar_tabControl.SuspendLayout();
			this._actions_tabPage.SuspendLayout();
			this._options_tabPage.SuspendLayout();
			this._optionsDraw_groupBox.SuspendLayout();
			this._obstacle_groupBox.SuspendLayout();
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
			this._main_panel.Location = new System.Drawing.Point(12, 188);
			this._main_panel.Name = "_main_panel";
			this._main_panel.Size = new System.Drawing.Size(1344, 399);
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
			this._main_splitContainer.Panel2.Controls.Add(this._canvasDrawGrid_checkBox);
			this._main_splitContainer.Panel2.Controls.Add(this._resetTransform_button);
			this._main_splitContainer.Panel2.Controls.Add(this._resetTranslation_button);
			this._main_splitContainer.Panel2.Controls.Add(this._resetZoom_button);
			this._main_splitContainer.Panel2.Controls.Add(this._translationY_numericUpDown);
			this._main_splitContainer.Panel2.Controls.Add(this._translationX_numericUpDown);
			this._main_splitContainer.Panel2.Controls.Add(this._translation_label);
			this._main_splitContainer.Panel2.Controls.Add(this._zoom_label);
			this._main_splitContainer.Panel2.Controls.Add(this._zoom_numericUpDown);
			this._main_splitContainer.Panel2.Controls.Add(this._draw_panel);
			this._main_splitContainer.Size = new System.Drawing.Size(1344, 399);
			this._main_splitContainer.SplitterDistance = 257;
			this._main_splitContainer.TabIndex = 0;
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
			this._details_splitContainer.Size = new System.Drawing.Size(257, 399);
			this._details_splitContainer.SplitterDistance = 231;
			this._details_splitContainer.TabIndex = 0;
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
			this._battle_treeView.Size = new System.Drawing.Size(257, 231);
			this._battle_treeView.TabIndex = 0;
			this._battle_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._battle_treeView_AfterSelect);
			this._battle_treeView.MouseLeave += new System.EventHandler(this._battle_treeView_MouseLeave);
			this._battle_treeView.MouseMove += new System.Windows.Forms.MouseEventHandler(this._battle_treeView_MouseMove);
			// 
			// _selectedItem_panel
			// 
			this._selectedItem_panel.BackColor = System.Drawing.SystemColors.Control;
			this._selectedItem_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._selectedItem_panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._selectedItem_panel.Location = new System.Drawing.Point(0, 0);
			this._selectedItem_panel.Name = "_selectedItem_panel";
			this._selectedItem_panel.Size = new System.Drawing.Size(257, 164);
			this._selectedItem_panel.TabIndex = 0;
			// 
			// _canvasDrawGrid_checkBox
			// 
			this._canvasDrawGrid_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._canvasDrawGrid_checkBox.AutoSize = true;
			this._canvasDrawGrid_checkBox.Location = new System.Drawing.Point(848, 373);
			this._canvasDrawGrid_checkBox.Name = "_canvasDrawGrid_checkBox";
			this._canvasDrawGrid_checkBox.Size = new System.Drawing.Size(73, 17);
			this._canvasDrawGrid_checkBox.TabIndex = 29;
			this._canvasDrawGrid_checkBox.Text = "Draw Grid";
			this._canvasDrawGrid_checkBox.UseVisualStyleBackColor = true;
			this._canvasDrawGrid_checkBox.CheckedChanged += new System.EventHandler(this._canvasDrawGrid_checkBox_CheckedChanged);
			// 
			// _resetTransform_button
			// 
			this._resetTransform_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._resetTransform_button.Location = new System.Drawing.Point(742, 370);
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
			this._resetTranslation_button.Location = new System.Drawing.Point(636, 370);
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
			this._resetZoom_button.Location = new System.Drawing.Point(530, 370);
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
			this._translationY_numericUpDown.Location = new System.Drawing.Point(424, 373);
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
			this._translationX_numericUpDown.Location = new System.Drawing.Point(318, 373);
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
			this._translation_label.Location = new System.Drawing.Point(217, 375);
			this._translation_label.Name = "_translation_label";
			this._translation_label.Size = new System.Drawing.Size(87, 13);
			this._translation_label.TabIndex = 19;
			this._translation_label.Text = "Canvas Pan X/Y";
			// 
			// _zoom_label
			// 
			this._zoom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._zoom_label.AutoSize = true;
			this._zoom_label.Location = new System.Drawing.Point(2, 375);
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
			this._zoom_numericUpDown.Location = new System.Drawing.Point(106, 373);
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
			this._setbg_button.Location = new System.Drawing.Point(330, 12);
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
			this._current_textBox.Size = new System.Drawing.Size(1238, 20);
			this._current_textBox.TabIndex = 5;
			// 
			// _regionPenWidth_label
			// 
			this._regionPenWidth_label.AutoSize = true;
			this._regionPenWidth_label.Location = new System.Drawing.Point(6, 24);
			this._regionPenWidth_label.Name = "_regionPenWidth_label";
			this._regionPenWidth_label.Size = new System.Drawing.Size(95, 13);
			this._regionPenWidth_label.TabIndex = 7;
			this._regionPenWidth_label.Text = "Region Line Width";
			// 
			// _regionPenWidth_numericUpDown
			// 
			this._regionPenWidth_numericUpDown.Location = new System.Drawing.Point(113, 22);
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
			this._region_groupBox.Controls.Add(this._calcWalkable_button);
			this._region_groupBox.Controls.Add(this._regionFillSelected_checkBox);
			this._region_groupBox.Controls.Add(this._regionSelectAllOpen_button);
			this._region_groupBox.Controls.Add(this._regionSelectAllClosed_button);
			this._region_groupBox.Controls.Add(this._regionDeselectAll_button);
			this._region_groupBox.Controls.Add(this._regionSelectAll_button);
			this._region_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._region_groupBox.Enabled = false;
			this._region_groupBox.Location = new System.Drawing.Point(439, 3);
			this._region_groupBox.Name = "_region_groupBox";
			this._region_groupBox.Size = new System.Drawing.Size(788, 77);
			this._region_groupBox.TabIndex = 11;
			this._region_groupBox.TabStop = false;
			this._region_groupBox.Text = "Region";
			// 
			// _calcWalkable_button
			// 
			this._calcWalkable_button.Location = new System.Drawing.Point(112, 48);
			this._calcWalkable_button.Name = "_calcWalkable_button";
			this._calcWalkable_button.Size = new System.Drawing.Size(100, 23);
			this._calcWalkable_button.TabIndex = 19;
			this._calcWalkable_button.Text = "Calc Walkable";
			this._calcWalkable_button.UseVisualStyleBackColor = true;
			this._calcWalkable_button.Click += new System.EventHandler(this._calcWalkable_button_Click);
			// 
			// _regionFillSelected_checkBox
			// 
			this._regionFillSelected_checkBox.AutoSize = true;
			this._regionFillSelected_checkBox.Location = new System.Drawing.Point(6, 52);
			this._regionFillSelected_checkBox.Name = "_regionFillSelected_checkBox";
			this._regionFillSelected_checkBox.Size = new System.Drawing.Size(83, 17);
			this._regionFillSelected_checkBox.TabIndex = 18;
			this._regionFillSelected_checkBox.Text = "Fill Selected";
			this._regionFillSelected_checkBox.UseVisualStyleBackColor = true;
			this._regionFillSelected_checkBox.CheckedChanged += new System.EventHandler(this._regionFillSelected_checkBox_CheckedChanged);
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
			// _regionPointSize_numericUpDown
			// 
			this._regionPointSize_numericUpDown.Location = new System.Drawing.Point(113, 51);
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
			this._pointSize_label.Location = new System.Drawing.Point(6, 53);
			this._pointSize_label.Name = "_pointSize_label";
			this._pointSize_label.Size = new System.Drawing.Size(91, 13);
			this._pointSize_label.TabIndex = 21;
			this._pointSize_label.Text = "Region Point Size";
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
			// _canvasGridSize_numericUpDown
			// 
			this._canvasGridSize_numericUpDown.Location = new System.Drawing.Point(324, 22);
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
			// _canvasGridSize_label
			// 
			this._canvasGridSize_label.AutoSize = true;
			this._canvasGridSize_label.Location = new System.Drawing.Point(218, 24);
			this._canvasGridSize_label.Name = "_canvasGridSize_label";
			this._canvasGridSize_label.Size = new System.Drawing.Size(49, 13);
			this._canvasGridSize_label.TabIndex = 25;
			this._canvasGridSize_label.Text = "Grid Size";
			// 
			// _toolbar_tabControl
			// 
			this._toolbar_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._toolbar_tabControl.Controls.Add(this._actions_tabPage);
			this._toolbar_tabControl.Controls.Add(this._options_tabPage);
			this._toolbar_tabControl.Location = new System.Drawing.Point(118, 73);
			this._toolbar_tabControl.Name = "_toolbar_tabControl";
			this._toolbar_tabControl.SelectedIndex = 0;
			this._toolbar_tabControl.Size = new System.Drawing.Size(1238, 109);
			this._toolbar_tabControl.TabIndex = 14;
			// 
			// _actions_tabPage
			// 
			this._actions_tabPage.Controls.Add(this._region_groupBox);
			this._actions_tabPage.Controls.Add(this._delimeter0_panel);
			this._actions_tabPage.Controls.Add(this._obstacle_groupBox);
			this._actions_tabPage.Location = new System.Drawing.Point(4, 22);
			this._actions_tabPage.Name = "_actions_tabPage";
			this._actions_tabPage.Padding = new System.Windows.Forms.Padding(3);
			this._actions_tabPage.Size = new System.Drawing.Size(1230, 83);
			this._actions_tabPage.TabIndex = 0;
			this._actions_tabPage.Text = "Actions";
			this._actions_tabPage.UseVisualStyleBackColor = true;
			// 
			// _options_tabPage
			// 
			this._options_tabPage.Controls.Add(this._optionsDraw_groupBox);
			this._options_tabPage.Location = new System.Drawing.Point(4, 22);
			this._options_tabPage.Name = "_options_tabPage";
			this._options_tabPage.Padding = new System.Windows.Forms.Padding(3);
			this._options_tabPage.Size = new System.Drawing.Size(1230, 83);
			this._options_tabPage.TabIndex = 1;
			this._options_tabPage.Text = "Options";
			this._options_tabPage.UseVisualStyleBackColor = true;
			// 
			// _optionsDraw_groupBox
			// 
			this._optionsDraw_groupBox.Controls.Add(this._canvasGridSize_numericUpDown);
			this._optionsDraw_groupBox.Controls.Add(this._canvasGridSize_label);
			this._optionsDraw_groupBox.Controls.Add(this._regionPenWidth_label);
			this._optionsDraw_groupBox.Controls.Add(this._regionPenWidth_numericUpDown);
			this._optionsDraw_groupBox.Controls.Add(this._regionPointSize_numericUpDown);
			this._optionsDraw_groupBox.Controls.Add(this._pointSize_label);
			this._optionsDraw_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._optionsDraw_groupBox.Location = new System.Drawing.Point(3, 3);
			this._optionsDraw_groupBox.Name = "_optionsDraw_groupBox";
			this._optionsDraw_groupBox.Size = new System.Drawing.Size(1224, 77);
			this._optionsDraw_groupBox.TabIndex = 29;
			this._optionsDraw_groupBox.TabStop = false;
			this._optionsDraw_groupBox.Text = "Draw";
			// 
			// _save_button
			// 
			this._save_button.Enabled = false;
			this._save_button.Location = new System.Drawing.Point(224, 12);
			this._save_button.Name = "_save_button";
			this._save_button.Size = new System.Drawing.Size(100, 23);
			this._save_button.TabIndex = 15;
			this._save_button.Text = "Save";
			this._save_button.UseVisualStyleBackColor = true;
			this._save_button.Click += new System.EventHandler(this._save_button_Click);
			// 
			// _obstacle_groupBox
			// 
			this._obstacle_groupBox.Controls.Add(this._obstacleDeselectAll_button);
			this._obstacle_groupBox.Controls.Add(this._obstacleSelectProj_button);
			this._obstacle_groupBox.Controls.Add(this._obstacleSelectMove_button);
			this._obstacle_groupBox.Controls.Add(this._obstacleSelectAll_button);
			this._obstacle_groupBox.Dock = System.Windows.Forms.DockStyle.Left;
			this._obstacle_groupBox.Enabled = false;
			this._obstacle_groupBox.Location = new System.Drawing.Point(3, 3);
			this._obstacle_groupBox.Name = "_obstacle_groupBox";
			this._obstacle_groupBox.Size = new System.Drawing.Size(431, 77);
			this._obstacle_groupBox.TabIndex = 12;
			this._obstacle_groupBox.TabStop = false;
			this._obstacle_groupBox.Text = "Obstacle";
			// 
			// _delimeter0_panel
			// 
			this._delimeter0_panel.Dock = System.Windows.Forms.DockStyle.Left;
			this._delimeter0_panel.Location = new System.Drawing.Point(434, 3);
			this._delimeter0_panel.Name = "_delimeter0_panel";
			this._delimeter0_panel.Size = new System.Drawing.Size(5, 77);
			this._delimeter0_panel.TabIndex = 13;
			// 
			// _obstacleSelectAll_button
			// 
			this._obstacleSelectAll_button.Location = new System.Drawing.Point(6, 19);
			this._obstacleSelectAll_button.Name = "_obstacleSelectAll_button";
			this._obstacleSelectAll_button.Size = new System.Drawing.Size(100, 23);
			this._obstacleSelectAll_button.TabIndex = 20;
			this._obstacleSelectAll_button.Text = "Select All";
			this._obstacleSelectAll_button.UseVisualStyleBackColor = true;
			this._obstacleSelectAll_button.Click += new System.EventHandler(this._obstacleSelectAll_button_Click);
			// 
			// _obstacleSelectMove_button
			// 
			this._obstacleSelectMove_button.Location = new System.Drawing.Point(112, 19);
			this._obstacleSelectMove_button.Name = "_obstacleSelectMove_button";
			this._obstacleSelectMove_button.Size = new System.Drawing.Size(100, 23);
			this._obstacleSelectMove_button.TabIndex = 20;
			this._obstacleSelectMove_button.Text = "Select All Move";
			this._obstacleSelectMove_button.UseVisualStyleBackColor = true;
			this._obstacleSelectMove_button.Click += new System.EventHandler(this._obstacleSelectMove_button_Click);
			// 
			// _obstacleSelectProj_button
			// 
			this._obstacleSelectProj_button.Location = new System.Drawing.Point(218, 19);
			this._obstacleSelectProj_button.Name = "_obstacleSelectProj_button";
			this._obstacleSelectProj_button.Size = new System.Drawing.Size(100, 23);
			this._obstacleSelectProj_button.TabIndex = 21;
			this._obstacleSelectProj_button.Text = "Select All Proj";
			this._obstacleSelectProj_button.UseVisualStyleBackColor = true;
			this._obstacleSelectProj_button.Click += new System.EventHandler(this._obstacleSelectProj_button_Click);
			// 
			// _obstacleDeselectAll_button
			// 
			this._obstacleDeselectAll_button.Location = new System.Drawing.Point(324, 19);
			this._obstacleDeselectAll_button.Name = "_obstacleDeselectAll_button";
			this._obstacleDeselectAll_button.Size = new System.Drawing.Size(100, 23);
			this._obstacleDeselectAll_button.TabIndex = 22;
			this._obstacleDeselectAll_button.Text = "Deselect All";
			this._obstacleDeselectAll_button.UseVisualStyleBackColor = true;
			this._obstacleDeselectAll_button.Click += new System.EventHandler(this._obstacleDeselectAll_button_Click);
			// 
			// _draw_panel
			// 
			this._draw_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._draw_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
			this._draw_panel.Location = new System.Drawing.Point(0, 0);
			this._draw_panel.Name = "_draw_panel";
			this._draw_panel.Size = new System.Drawing.Size(1083, 367);
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
			this.ClientSize = new System.Drawing.Size(1368, 599);
			this.Controls.Add(this._save_button);
			this.Controls.Add(this._toolbar_tabControl);
			this.Controls.Add(this._toolbar_label);
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
			this._details_splitContainer.Panel1.ResumeLayout(false);
			this._details_splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._details_splitContainer)).EndInit();
			this._details_splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._translationY_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._translationX_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._zoom_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._regionPenWidth_numericUpDown)).EndInit();
			this._region_groupBox.ResumeLayout(false);
			this._region_groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._regionPointSize_numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._canvasGridSize_numericUpDown)).EndInit();
			this._toolbar_tabControl.ResumeLayout(false);
			this._actions_tabPage.ResumeLayout(false);
			this._options_tabPage.ResumeLayout(false);
			this._optionsDraw_groupBox.ResumeLayout(false);
			this._optionsDraw_groupBox.PerformLayout();
			this._obstacle_groupBox.ResumeLayout(false);
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
		private System.Windows.Forms.CheckBox _canvasDrawGrid_checkBox;
		private System.Windows.Forms.NumericUpDown _canvasGridSize_numericUpDown;
		private System.Windows.Forms.Label _canvasGridSize_label;
		private System.Windows.Forms.TabControl _toolbar_tabControl;
		private System.Windows.Forms.TabPage _actions_tabPage;
		private System.Windows.Forms.TabPage _options_tabPage;
		private System.Windows.Forms.GroupBox _optionsDraw_groupBox;
		private System.Windows.Forms.CheckBox _regionFillSelected_checkBox;
		private System.Windows.Forms.Button _calcWalkable_button;
        private System.Windows.Forms.Button _save_button;
		private System.Windows.Forms.GroupBox _obstacle_groupBox;
		private System.Windows.Forms.Panel _delimeter0_panel;
		private System.Windows.Forms.Button _obstacleSelectMove_button;
		private System.Windows.Forms.Button _obstacleSelectAll_button;
		private System.Windows.Forms.Button _obstacleDeselectAll_button;
		private System.Windows.Forms.Button _obstacleSelectProj_button;
	}
}

