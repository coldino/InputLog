namespace MouseTester
{
    partial class MainWindow
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
            this.logView = new System.Windows.Forms.ListView();
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // logView
            // 
            this.logView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTime,
            this.columnHeaderMsg});
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.Location = new System.Drawing.Point(0, 0);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(364, 435);
            this.logView.TabIndex = 0;
            this.logView.UseCompatibleStateImageBehavior = false;
            this.logView.View = System.Windows.Forms.View.Details;
            this.logView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogView_KeyDown);
            this.logView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LogView_KeyUp);
            this.logView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogView_MouseDown);
            this.logView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LogView_MouseUp);
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            // 
            // columnHeaderMsg
            // 
            this.columnHeaderMsg.Text = "Event";
            this.columnHeaderMsg.Width = 300;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 435);
            this.Controls.Add(this.logView);
            this.Name = "MainWindow";
            this.Text = "Input Tester";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView logView;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderMsg;
    }
}

