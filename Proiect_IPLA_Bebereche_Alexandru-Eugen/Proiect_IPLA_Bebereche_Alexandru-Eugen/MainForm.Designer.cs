namespace Proiect_IPLA_Bebereche_Alexandru_Eugen
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
            this.lvEmp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveAsCSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateWordReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEmp
            // 
            this.lvEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvEmp.FullRowSelect = true;
            this.lvEmp.GridLines = true;
            this.lvEmp.HideSelection = false;
            this.lvEmp.Location = new System.Drawing.Point(12, 119);
            this.lvEmp.Name = "lvEmp";
            this.lvEmp.Size = new System.Drawing.Size(493, 262);
            this.lvEmp.TabIndex = 0;
            this.lvEmp.UseCompatibleStateImageBehavior = false;
            this.lvEmp.View = System.Windows.Forms.View.Details;
            this.lvEmp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvEmp_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Salary";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Position";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hire Date";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Free days left";
            this.columnHeader5.Width = 102;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(152, 48);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(227, 46);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsCSVToolStripMenuItem1,
            this.generateWordReportToolStripMenuItem,
            this.excelStatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveAsCSVToolStripMenuItem1
            // 
            this.saveAsCSVToolStripMenuItem1.Name = "saveAsCSVToolStripMenuItem1";
            this.saveAsCSVToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.saveAsCSVToolStripMenuItem1.Text = "Salveaza CSV";
            this.saveAsCSVToolStripMenuItem1.Click += new System.EventHandler(this.saveAsCSVToolStripMenuItem1_Click);
            // 
            // generateWordReportToolStripMenuItem
            // 
            this.generateWordReportToolStripMenuItem.Name = "generateWordReportToolStripMenuItem";
            this.generateWordReportToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.generateWordReportToolStripMenuItem.Text = "Genereaza raport Word";
            this.generateWordReportToolStripMenuItem.Click += new System.EventHandler(this.generateWordReportToolStripMenuItem_Click);
            // 
            // excelStatsToolStripMenuItem
            // 
            this.excelStatsToolStripMenuItem.Name = "excelStatsToolStripMenuItem";
            this.excelStatsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.excelStatsToolStripMenuItem.Text = "Excel Stats";
            this.excelStatsToolStripMenuItem.Click += new System.EventHandler(this.excelStatsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 426);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lvEmp);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEmp;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsCSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generateWordReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelStatsToolStripMenuItem;
    }
}

