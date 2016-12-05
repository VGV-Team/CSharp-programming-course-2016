namespace WindowsFormsApplication1fsdf
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
            this.bWrite = new System.Windows.Forms.Button();
            this.tbNotepad = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.bDraw = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(582, 227);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(75, 23);
            this.bWrite.TabIndex = 0;
            this.bWrite.Text = "Write";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // tbNotepad
            // 
            this.tbNotepad.Location = new System.Drawing.Point(397, 12);
            this.tbNotepad.Multiline = true;
            this.tbNotepad.Name = "tbNotepad";
            this.tbNotepad.Size = new System.Drawing.Size(260, 209);
            this.tbNotepad.TabIndex = 1;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(12, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(200, 200);
            this.pbPicture.TabIndex = 2;
            this.pbPicture.TabStop = false;
            // 
            // bDraw
            // 
            this.bDraw.Location = new System.Drawing.Point(12, 227);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(75, 23);
            this.bDraw.TabIndex = 3;
            this.bDraw.Text = "Draw";
            this.bDraw.UseVisualStyleBackColor = true;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click);
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(137, 227);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(75, 23);
            this.bRead.TabIndex = 4;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 262);
            this.Controls.Add(this.bRead);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.tbNotepad);
            this.Controls.Add(this.bWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.TextBox tbNotepad;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Button bRead;
    }
}

