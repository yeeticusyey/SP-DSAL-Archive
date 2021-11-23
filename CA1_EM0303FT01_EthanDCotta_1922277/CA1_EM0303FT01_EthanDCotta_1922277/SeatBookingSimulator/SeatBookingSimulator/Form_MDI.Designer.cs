
namespace SeatBookingSimulator
{
    partial class Form_MDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeDistancingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smartModeSafeDistancingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalModeToolStripMenuItem,
            this.safeDistancingModeToolStripMenuItem,
            this.smartModeSafeDistancingToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // normalModeToolStripMenuItem
            // 
            this.normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            this.normalModeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.normalModeToolStripMenuItem.Text = "Normal Mode";
            this.normalModeToolStripMenuItem.Click += new System.EventHandler(this.normalModeToolStripMenuItem_Click);
            // 
            // safeDistancingModeToolStripMenuItem
            // 
            this.safeDistancingModeToolStripMenuItem.Name = "safeDistancingModeToolStripMenuItem";
            this.safeDistancingModeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.safeDistancingModeToolStripMenuItem.Text = "Safe Distancing Mode";
            this.safeDistancingModeToolStripMenuItem.Click += new System.EventHandler(this.safeDistancingModeToolStripMenuItem_Click);
            // 
            // smartModeSafeDistancingToolStripMenuItem
            // 
            this.smartModeSafeDistancingToolStripMenuItem.Name = "smartModeSafeDistancingToolStripMenuItem";
            this.smartModeSafeDistancingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.smartModeSafeDistancingToolStripMenuItem.Text = "Smart Mode (Safe Distancing)";
            this.smartModeSafeDistancingToolStripMenuItem.Click += new System.EventHandler(this.smartModeSafeDistancingToolStripMenuItem_Click);
            // 
            // Form_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MDI";
            this.Text = "Cinema Seat Booking and Arrangement Simulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeDistancingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smartModeSafeDistancingToolStripMenuItem;
    }
}

