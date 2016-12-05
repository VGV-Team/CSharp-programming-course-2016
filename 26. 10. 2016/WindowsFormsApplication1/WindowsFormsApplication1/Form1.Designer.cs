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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbHeroHP = new System.Windows.Forms.ProgressBar();
            this.lStamina = new System.Windows.Forms.Label();
            this.bLightAttack = new System.Windows.Forms.Button();
            this.bHeavyAttack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbEnemyHP = new System.Windows.Forms.ProgressBar();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stamina:";
            // 
            // pbHeroHP
            // 
            this.pbHeroHP.Location = new System.Drawing.Point(133, 85);
            this.pbHeroHP.Name = "pbHeroHP";
            this.pbHeroHP.Size = new System.Drawing.Size(168, 31);
            this.pbHeroHP.TabIndex = 3;
            this.pbHeroHP.Value = 100;
            // 
            // lStamina
            // 
            this.lStamina.AutoSize = true;
            this.lStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lStamina.Location = new System.Drawing.Point(137, 132);
            this.lStamina.Name = "lStamina";
            this.lStamina.Size = new System.Drawing.Size(58, 31);
            this.lStamina.TabIndex = 4;
            this.lStamina.Text = "X/Y";
            // 
            // bLightAttack
            // 
            this.bLightAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLightAttack.Location = new System.Drawing.Point(12, 181);
            this.bLightAttack.Name = "bLightAttack";
            this.bLightAttack.Size = new System.Drawing.Size(289, 50);
            this.bLightAttack.TabIndex = 5;
            this.bLightAttack.Text = "Light Attack";
            this.bLightAttack.UseVisualStyleBackColor = true;
            this.bLightAttack.Click += new System.EventHandler(this.bLightAttack_Click);
            // 
            // bHeavyAttack
            // 
            this.bHeavyAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bHeavyAttack.Location = new System.Drawing.Point(12, 237);
            this.bHeavyAttack.Name = "bHeavyAttack";
            this.bHeavyAttack.Size = new System.Drawing.Size(289, 50);
            this.bHeavyAttack.TabIndex = 6;
            this.bHeavyAttack.Text = "Heavy Attack";
            this.bHeavyAttack.UseVisualStyleBackColor = true;
            this.bHeavyAttack.Click += new System.EventHandler(this.bHeavyAttack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(336, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enemy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(340, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "HP:";
            // 
            // pbEnemyHP
            // 
            this.pbEnemyHP.Location = new System.Drawing.Point(406, 85);
            this.pbEnemyHP.Name = "pbEnemyHP";
            this.pbEnemyHP.Size = new System.Drawing.Size(168, 31);
            this.pbEnemyHP.TabIndex = 9;
            this.pbEnemyHP.Value = 100;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(346, 144);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(234, 230);
            this.tbLog.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 416);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.pbEnemyHP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bHeavyAttack);
            this.Controls.Add(this.bLightAttack);
            this.Controls.Add(this.lStamina);
            this.Controls.Add(this.pbHeroHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbHeroHP;
        private System.Windows.Forms.Label lStamina;
        private System.Windows.Forms.Button bLightAttack;
        private System.Windows.Forms.Button bHeavyAttack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbEnemyHP;
        private System.Windows.Forms.TextBox tbLog;


    }
}

