namespace DependenciesChecker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DX_lbl = new System.Windows.Forms.Label();
            this.NET_lbl = new System.Windows.Forms.Label();
            this.vcx64_lbl = new System.Windows.Forms.Label();
            this.vcx86_lbl = new System.Windows.Forms.Label();
            this.MSBT_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS Build Tools:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "VCredist x86 2013:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "VCredist x64 2013:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = ".NET Framework:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(17, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "DirectX:";
            // 
            // DX_lbl
            // 
            this.DX_lbl.AutoSize = true;
            this.DX_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DX_lbl.Location = new System.Drawing.Point(148, 18);
            this.DX_lbl.Name = "DX_lbl";
            this.DX_lbl.Size = new System.Drawing.Size(30, 17);
            this.DX_lbl.TabIndex = 5;
            this.DX_lbl.Text = "null";
            // 
            // NET_lbl
            // 
            this.NET_lbl.AutoSize = true;
            this.NET_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NET_lbl.Location = new System.Drawing.Point(148, 35);
            this.NET_lbl.Name = "NET_lbl";
            this.NET_lbl.Size = new System.Drawing.Size(30, 17);
            this.NET_lbl.TabIndex = 6;
            this.NET_lbl.Text = "null";
            // 
            // vcx64_lbl
            // 
            this.vcx64_lbl.AutoSize = true;
            this.vcx64_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vcx64_lbl.Location = new System.Drawing.Point(148, 69);
            this.vcx64_lbl.Name = "vcx64_lbl";
            this.vcx64_lbl.Size = new System.Drawing.Size(30, 17);
            this.vcx64_lbl.TabIndex = 7;
            this.vcx64_lbl.Text = "null";
            // 
            // vcx86_lbl
            // 
            this.vcx86_lbl.AutoSize = true;
            this.vcx86_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vcx86_lbl.Location = new System.Drawing.Point(148, 52);
            this.vcx86_lbl.Name = "vcx86_lbl";
            this.vcx86_lbl.Size = new System.Drawing.Size(30, 17);
            this.vcx86_lbl.TabIndex = 8;
            this.vcx86_lbl.Text = "null";
            // 
            // MSBT_lbl
            // 
            this.MSBT_lbl.AutoSize = true;
            this.MSBT_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MSBT_lbl.Location = new System.Drawing.Point(148, 86);
            this.MSBT_lbl.Name = "MSBT_lbl";
            this.MSBT_lbl.Size = new System.Drawing.Size(30, 17);
            this.MSBT_lbl.TabIndex = 9;
            this.MSBT_lbl.Text = "null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 147);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MSBT_lbl);
            this.Controls.Add(this.vcx86_lbl);
            this.Controls.Add(this.vcx64_lbl);
            this.Controls.Add(this.NET_lbl);
            this.Controls.Add(this.DX_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DependenciesChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DX_lbl;
        private System.Windows.Forms.Label NET_lbl;
        private System.Windows.Forms.Label vcx64_lbl;
        private System.Windows.Forms.Label vcx86_lbl;
        private System.Windows.Forms.Label MSBT_lbl;
        private System.Windows.Forms.Button button1;
    }
}

