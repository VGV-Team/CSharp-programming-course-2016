namespace WindowsFormsApplication1
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
            this.pbPictureBox = new System.Windows.Forms.PictureBox();
            this.bDraw = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPictureBox
            // 
            this.pbPictureBox.Location = new System.Drawing.Point(12, 12);
            this.pbPictureBox.Name = "pbPictureBox";
            this.pbPictureBox.Size = new System.Drawing.Size(200, 200);
            this.pbPictureBox.TabIndex = 0;
            this.pbPictureBox.TabStop = false;
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(218, 12);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(75, 23);
            this.bDraw.TabIndex = 1;
            this.bDraw.Text = "Draw";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(218, 189);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 257);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.pbPictureBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPictureBox;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bStart;
    }
}

