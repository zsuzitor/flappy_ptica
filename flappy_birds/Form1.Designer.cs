namespace flappy_birds
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
            this.bird_form = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.s4et = new System.Windows.Forms.Label();
            this.column2_form = new System.Windows.Forms.PictureBox();
            this.column1_form = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird_form)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.column2_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.column1_form)).BeginInit();
            this.SuspendLayout();
            // 
            // bird_form
            // 
            this.bird_form.Location = new System.Drawing.Point(360, 217);
            this.bird_form.Name = "bird_form";
            this.bird_form.Size = new System.Drawing.Size(62, 55);
            this.bird_form.TabIndex = 0;
            this.bird_form.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.s4et);
            this.panel1.Controls.Add(this.column2_form);
            this.panel1.Controls.Add(this.column1_form);
            this.panel1.Controls.Add(this.bird_form);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 562);
            this.panel1.TabIndex = 1;
            // 
            // s4et
            // 
            this.s4et.AutoSize = true;
            this.s4et.Location = new System.Drawing.Point(13, 13);
            this.s4et.Name = "s4et";
            this.s4et.Size = new System.Drawing.Size(13, 13);
            this.s4et.TabIndex = 3;
            this.s4et.Text = "0";
            // 
            // column2_form
            // 
            this.column2_form.Location = new System.Drawing.Point(765, 359);
            this.column2_form.Name = "column2_form";
            this.column2_form.Size = new System.Drawing.Size(50, 200);
            this.column2_form.TabIndex = 2;
            this.column2_form.TabStop = false;
            // 
            // column1_form
            // 
            this.column1_form.Location = new System.Drawing.Point(763, 3);
            this.column1_form.Name = "column1_form";
            this.column1_form.Size = new System.Drawing.Size(50, 200);
            this.column1_form.TabIndex = 1;
            this.column1_form.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bird_form)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.column2_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.column1_form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox column2_form;
        private System.Windows.Forms.PictureBox column1_form;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label s4et;
    }
}

