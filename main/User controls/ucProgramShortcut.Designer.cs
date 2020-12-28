﻿namespace client.User_controls
{
    partial class ucProgramShortcut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdNumUp = new System.Windows.Forms.Button();
            this.cmdNumDown = new System.Windows.Forms.Button();
            this.picShortcut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShortcut)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(114, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 21);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Program name";
            this.lblName.MouseEnter += new System.EventHandler(this.ucProgramShortcut_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.ucProgramShortcut_MouseLeave);
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.cmdDelete.FlatAppearance.BorderSize = 0;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ForeColor = System.Drawing.Color.White;
            this.cmdDelete.Location = new System.Drawing.Point(345, 11);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(83, 27);
            this.cmdDelete.TabIndex = 21;
            this.cmdDelete.Text = "Delete Group";
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            this.cmdDelete.MouseEnter += new System.EventHandler(this.ucProgramShortcut_MouseEnter);
            this.cmdDelete.MouseLeave += new System.EventHandler(this.ucProgramShortcut_MouseLeave);
            // 
            // cmdNumUp
            // 
            this.cmdNumUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cmdNumUp.BackgroundImage = global::client.Properties.Resources.NumUpWhite;
            this.cmdNumUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNumUp.FlatAppearance.BorderSize = 0;
            this.cmdNumUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNumUp.Location = new System.Drawing.Point(16, 12);
            this.cmdNumUp.Name = "cmdNumUp";
            this.cmdNumUp.Size = new System.Drawing.Size(14, 7);
            this.cmdNumUp.TabIndex = 30;
            this.cmdNumUp.UseVisualStyleBackColor = false;
            this.cmdNumUp.Click += new System.EventHandler(this.cmdNumUp_Click);
            this.cmdNumUp.MouseEnter += new System.EventHandler(this.ucProgramShortcut_MouseEnter);
            this.cmdNumUp.MouseLeave += new System.EventHandler(this.ucProgramShortcut_MouseLeave);
            // 
            // cmdNumDown
            // 
            this.cmdNumDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cmdNumDown.BackgroundImage = global::client.Properties.Resources.NumDownWhite;
            this.cmdNumDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNumDown.FlatAppearance.BorderSize = 0;
            this.cmdNumDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNumDown.Location = new System.Drawing.Point(16, 30);
            this.cmdNumDown.Name = "cmdNumDown";
            this.cmdNumDown.Size = new System.Drawing.Size(14, 7);
            this.cmdNumDown.TabIndex = 29;
            this.cmdNumDown.UseVisualStyleBackColor = false;
            this.cmdNumDown.Click += new System.EventHandler(this.cmdNumDown_Click);
            this.cmdNumDown.MouseEnter += new System.EventHandler(this.ucProgramShortcut_MouseEnter);
            this.cmdNumDown.MouseLeave += new System.EventHandler(this.ucProgramShortcut_MouseLeave);
            // 
            // picShortcut
            // 
            this.picShortcut.BackgroundImage = global::client.Properties.Resources.AddWhite;
            this.picShortcut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShortcut.Location = new System.Drawing.Point(69, 9);
            this.picShortcut.Margin = new System.Windows.Forms.Padding(30, 30, 10, 30);
            this.picShortcut.Name = "picShortcut";
            this.picShortcut.Size = new System.Drawing.Size(30, 30);
            this.picShortcut.TabIndex = 17;
            this.picShortcut.TabStop = false;
            this.picShortcut.MouseEnter += new System.EventHandler(this.ucProgramShortcut_MouseEnter);
            this.picShortcut.MouseLeave += new System.EventHandler(this.ucProgramShortcut_MouseLeave);
            // 
            // ucProgramShortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.cmdNumUp);
            this.Controls.Add(this.cmdNumDown);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picShortcut);
            this.Name = "ucProgramShortcut";
            this.Size = new System.Drawing.Size(450, 50);
            this.Load += new System.EventHandler(this.ucProgramShortcut_Load);
            this.Click += new System.EventHandler(this.ucProgramShortcut_Click);
            this.MouseEnter += new System.EventHandler(this.ucProgramShortcut_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucProgramShortcut_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picShortcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picShortcut;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdNumUp;
        private System.Windows.Forms.Button cmdNumDown;
    }
}
