namespace Lap_6
{
    partial class Form1
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.tmSidebar = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.Blue;
            this.pnlSideBar.Controls.Add(this.button5);
            this.pnlSideBar.Controls.Add(this.button1);
            this.pnlSideBar.Controls.Add(this.button4);
            this.pnlSideBar.Controls.Add(this.button2);
            this.pnlSideBar.Controls.Add(this.button3);
            this.pnlSideBar.Location = new System.Drawing.Point(282, 90);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(156, 261);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(156, 55);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(156, 55);
            this.pnlSideBar.TabIndex = 1;
            // 
            // tmSidebar
            // 
            this.tmSidebar.Enabled = true;
            this.tmSidebar.Interval = 10;
            this.tmSidebar.Tick += new System.EventHandler(this.tmSidebar_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open Sidebar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Button 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Button 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-1, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 55);
            this.button4.TabIndex = 2;
            this.button4.Text = "Button 3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-1, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 55);
            this.button5.TabIndex = 2;
            this.button5.Text = "Button 4";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 456);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Timer tmSidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

