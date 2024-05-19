
namespace AppFileMonitoring
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabActivity = new System.Windows.Forms.TabPage();
            this.gridActivity = new System.Windows.Forms.DataGridView();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.tabDirs = new System.Windows.Forms.TabPage();
            this.gridDirs = new System.Windows.Forms.DataGridView();
            this.groupBoxDirs = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dirAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.dirsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.regexOutPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regexOutFileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dirOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirInpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dirsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dirInpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirOutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.regexOutFileNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regexOutPathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridActivity)).BeginInit();
            this.tabDirs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDirs)).BeginInit();
            this.groupBoxDirs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(800, 25);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(0, 428);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(800, 22);
            this.statusbar.TabIndex = 1;
            this.statusbar.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabActivity);
            this.tabControl1.Controls.Add(this.tabDirs);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 403);
            this.tabControl1.TabIndex = 2;
            // 
            // tabActivity
            // 
            this.tabActivity.Controls.Add(this.gridActivity);
            this.tabActivity.Controls.Add(this.groupBoxActivity);
            this.tabActivity.Location = new System.Drawing.Point(4, 22);
            this.tabActivity.Name = "tabActivity";
            this.tabActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivity.Size = new System.Drawing.Size(792, 377);
            this.tabActivity.TabIndex = 0;
            this.tabActivity.Text = "tabActivity";
            this.tabActivity.UseVisualStyleBackColor = true;
            // 
            // gridActivity
            // 
            this.gridActivity.AutoGenerateColumns = false;
            this.gridActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.gridActivity.DataSource = this.filesBindingSource;
            this.gridActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridActivity.Location = new System.Drawing.Point(3, 59);
            this.gridActivity.Name = "gridActivity";
            this.gridActivity.ReadOnly = true;
            this.gridActivity.Size = new System.Drawing.Size(786, 315);
            this.gridActivity.TabIndex = 2;
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxActivity.Location = new System.Drawing.Point(3, 3);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(786, 56);
            this.groupBoxActivity.TabIndex = 1;
            this.groupBoxActivity.TabStop = false;
            // 
            // tabDirs
            // 
            this.tabDirs.Controls.Add(this.gridDirs);
            this.tabDirs.Controls.Add(this.groupBoxDirs);
            this.tabDirs.Controls.Add(this.menuStrip1);
            this.tabDirs.Location = new System.Drawing.Point(4, 22);
            this.tabDirs.Name = "tabDirs";
            this.tabDirs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirs.Size = new System.Drawing.Size(792, 377);
            this.tabDirs.TabIndex = 1;
            this.tabDirs.Text = "tabDirs";
            this.tabDirs.UseVisualStyleBackColor = true;
            // 
            // gridDirs
            // 
            this.gridDirs.AutoGenerateColumns = false;
            this.gridDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDirs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dirInpDataGridViewTextBoxColumn,
            this.dirOutDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.regexOutFileNameDataGridViewTextBoxColumn,
            this.regexOutPathDataGridViewTextBoxColumn});
            this.gridDirs.DataSource = this.dirsBindingSource;
            this.gridDirs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDirs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDirs.Location = new System.Drawing.Point(3, 76);
            this.gridDirs.Name = "gridDirs";
            this.gridDirs.ReadOnly = true;
            this.gridDirs.Size = new System.Drawing.Size(786, 298);
            this.gridDirs.TabIndex = 1;
            // 
            // groupBoxDirs
            // 
            this.groupBoxDirs.Controls.Add(this.button1);
            this.groupBoxDirs.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDirs.Location = new System.Drawing.Point(3, 27);
            this.groupBoxDirs.Name = "groupBoxDirs";
            this.groupBoxDirs.Size = new System.Drawing.Size(786, 49);
            this.groupBoxDirs.TabIndex = 0;
            this.groupBoxDirs.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirAdd,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dirAdd
            // 
            this.dirAdd.Name = "dirAdd";
            this.dirAdd.Size = new System.Drawing.Size(27, 20);
            this.dirAdd.Text = "+";
            this.dirAdd.Click += new System.EventHandler(this.dirAdd_Click);
            // 
            // dirsBindingSource
            // 
            this.dirsBindingSource.DataMember = "Dirs";
            this.dirsBindingSource.DataSource = typeof(AppFileMonitoring.StateAdapter);
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "Files";
            this.filesBindingSource.DataSource = typeof(AppFileMonitoring.StateAdapter);
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            this.statusCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regexOutPathDataGridViewTextBoxColumn
            // 
            this.regexOutPathDataGridViewTextBoxColumn.DataPropertyName = "RegexOutPath";
            this.regexOutPathDataGridViewTextBoxColumn.HeaderText = "RegexOutPath";
            this.regexOutPathDataGridViewTextBoxColumn.Name = "regexOutPathDataGridViewTextBoxColumn";
            this.regexOutPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regexOutFileNameDataGridViewTextBoxColumn
            // 
            this.regexOutFileNameDataGridViewTextBoxColumn.DataPropertyName = "RegexOutFileName";
            this.regexOutFileNameDataGridViewTextBoxColumn.HeaderText = "RegexOutFileName";
            this.regexOutFileNameDataGridViewTextBoxColumn.Name = "regexOutFileNameDataGridViewTextBoxColumn";
            this.regexOutFileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dirOutDataGridViewTextBoxColumn
            // 
            this.dirOutDataGridViewTextBoxColumn.DataPropertyName = "DirOut";
            this.dirOutDataGridViewTextBoxColumn.HeaderText = "DirOut";
            this.dirOutDataGridViewTextBoxColumn.Name = "dirOutDataGridViewTextBoxColumn";
            this.dirOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirInpDataGridViewTextBoxColumn
            // 
            this.dirInpDataGridViewTextBoxColumn.DataPropertyName = "DirInp";
            this.dirInpDataGridViewTextBoxColumn.HeaderText = "DirInp";
            this.dirInpDataGridViewTextBoxColumn.Name = "dirInpDataGridViewTextBoxColumn";
            this.dirInpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 377);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dirInpDataGridViewTextBoxColumn1,
            this.dirOutDataGridViewTextBoxColumn1,
            this.isActiveDataGridViewCheckBoxColumn1,
            this.regexOutFileNameDataGridViewTextBoxColumn1,
            this.regexOutPathDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.dirsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // dirsBindingSource1
            // 
            this.dirsBindingSource1.DataMember = "Dirs";
            this.dirsBindingSource1.DataSource = typeof(AppFileMonitoring.StateAdapter);
            // 
            // dirInpDataGridViewTextBoxColumn1
            // 
            this.dirInpDataGridViewTextBoxColumn1.DataPropertyName = "DirInp";
            this.dirInpDataGridViewTextBoxColumn1.HeaderText = "DirInp";
            this.dirInpDataGridViewTextBoxColumn1.Name = "dirInpDataGridViewTextBoxColumn1";
            // 
            // dirOutDataGridViewTextBoxColumn1
            // 
            this.dirOutDataGridViewTextBoxColumn1.DataPropertyName = "DirOut";
            this.dirOutDataGridViewTextBoxColumn1.HeaderText = "DirOut";
            this.dirOutDataGridViewTextBoxColumn1.Name = "dirOutDataGridViewTextBoxColumn1";
            // 
            // isActiveDataGridViewCheckBoxColumn1
            // 
            this.isActiveDataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn1.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn1.Name = "isActiveDataGridViewCheckBoxColumn1";
            // 
            // regexOutFileNameDataGridViewTextBoxColumn1
            // 
            this.regexOutFileNameDataGridViewTextBoxColumn1.DataPropertyName = "RegexOutFileName";
            this.regexOutFileNameDataGridViewTextBoxColumn1.HeaderText = "RegexOutFileName";
            this.regexOutFileNameDataGridViewTextBoxColumn1.Name = "regexOutFileNameDataGridViewTextBoxColumn1";
            // 
            // regexOutPathDataGridViewTextBoxColumn1
            // 
            this.regexOutPathDataGridViewTextBoxColumn1.DataPropertyName = "RegexOutPath";
            this.regexOutPathDataGridViewTextBoxColumn1.HeaderText = "RegexOutPath";
            this.regexOutPathDataGridViewTextBoxColumn1.Name = "regexOutPathDataGridViewTextBoxColumn1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.toolbar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridActivity)).EndInit();
            this.tabDirs.ResumeLayout(false);
            this.tabDirs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDirs)).EndInit();
            this.groupBoxDirs.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabActivity;
        private System.Windows.Forms.TabPage tabDirs;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private System.Windows.Forms.DataGridView gridActivity;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBoxDirs;
        private System.Windows.Forms.DataGridView gridDirs;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dirAdd;
        private System.Windows.Forms.BindingSource dirsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirInpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regexOutFileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regexOutPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirInpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirOutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regexOutFileNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regexOutPathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource dirsBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}