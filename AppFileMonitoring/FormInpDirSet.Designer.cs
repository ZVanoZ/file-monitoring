namespace AppFileMonitoring
{
    partial class FormInpDirSet
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inpDirSelect = new System.Windows.Forms.Button();
            this.inpDir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outDirSelect = new System.Windows.Forms.Button();
            this.outDir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regexDirName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regexFileName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inpDirSelect);
            this.groupBox1.Controls.Add(this.inpDir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input dir";
            // 
            // inpDirSelect
            // 
            this.inpDirSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inpDirSelect.Location = new System.Drawing.Point(765, 16);
            this.inpDirSelect.Name = "inpDirSelect";
            this.inpDirSelect.Size = new System.Drawing.Size(29, 23);
            this.inpDirSelect.TabIndex = 7;
            this.inpDirSelect.Text = "...";
            this.inpDirSelect.UseVisualStyleBackColor = true;
            this.inpDirSelect.Click += new System.EventHandler(this.inpDirSelect_Click);
            // 
            // inpDir
            // 
            this.inpDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpDir.Location = new System.Drawing.Point(6, 19);
            this.inpDir.Name = "inpDir";
            this.inpDir.ReadOnly = true;
            this.inpDir.Size = new System.Drawing.Size(753, 20);
            this.inpDir.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outDirSelect);
            this.groupBox2.Controls.Add(this.outDir);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output dir";
            // 
            // outDirSelect
            // 
            this.outDirSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outDirSelect.Location = new System.Drawing.Point(765, 16);
            this.outDirSelect.Name = "outDirSelect";
            this.outDirSelect.Size = new System.Drawing.Size(29, 23);
            this.outDirSelect.TabIndex = 7;
            this.outDirSelect.Text = "...";
            this.outDirSelect.UseVisualStyleBackColor = true;
            this.outDirSelect.Click += new System.EventHandler(this.outDirSelect_Click);
            // 
            // outDir
            // 
            this.outDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outDir.Location = new System.Drawing.Point(6, 19);
            this.outDir.Name = "outDir";
            this.outDir.ReadOnly = true;
            this.outDir.Size = new System.Drawing.Size(753, 20);
            this.outDir.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 8;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(6, 104);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(63, 17);
            this.isActive.TabIndex = 9;
            this.isActive.Text = "isActive";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.regexDirName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.regexFileName);
            this.groupBox3.Location = new System.Drawing.Point(6, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(788, 92);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dir Name";
            // 
            // regexDirName
            // 
            this.regexDirName.Location = new System.Drawing.Point(85, 52);
            this.regexDirName.Name = "regexDirName";
            this.regexDirName.Size = new System.Drawing.Size(697, 20);
            this.regexDirName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Name";
            // 
            // regexFileName
            // 
            this.regexFileName.Location = new System.Drawing.Point(85, 26);
            this.regexFileName.Name = "regexFileName";
            this.regexFileName.Size = new System.Drawing.Size(697, 20);
            this.regexFileName.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(291, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(396, 11);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInpDirSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormInpDirSet";
            this.Text = "FormDirAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inpDirSelect;
        private System.Windows.Forms.TextBox inpDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button outDirSelect;
        private System.Windows.Forms.TextBox outDir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regexFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regexDirName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}