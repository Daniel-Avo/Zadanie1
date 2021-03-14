
namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
            this.combo_interfaces = new System.Windows.Forms.ComboBox();
            this.toy_box = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.b_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.propertybox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_interfaces
            // 
            this.combo_interfaces.FormattingEnabled = true;
            this.combo_interfaces.Location = new System.Drawing.Point(472, 109);
            this.combo_interfaces.Name = "combo_interfaces";
            this.combo_interfaces.Size = new System.Drawing.Size(121, 21);
            this.combo_interfaces.TabIndex = 0;
            this.combo_interfaces.SelectedIndexChanged += new System.EventHandler(this.combo_interfaces_SelectedIndexChanged);
            // 
            // toy_box
            // 
            this.toy_box.FormattingEnabled = true;
            this.toy_box.Location = new System.Drawing.Point(472, 150);
            this.toy_box.Name = "toy_box";
            this.toy_box.Size = new System.Drawing.Size(121, 21);
            this.toy_box.TabIndex = 1;
            this.toy_box.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(333, 326);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(138, 98);
            this.b_add.TabIndex = 3;
            this.b_add.Text = "Add object";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // modelbox
            // 
            this.modelbox.Location = new System.Drawing.Point(472, 188);
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(121, 20);
            this.modelbox.TabIndex = 8;
            // 
            // propertybox
            // 
            this.propertybox.Location = new System.Drawing.Point(472, 224);
            this.propertybox.Name = "propertybox";
            this.propertybox.Size = new System.Drawing.Size(121, 20);
            this.propertybox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // b_change
            // 
            this.b_change.Location = new System.Drawing.Point(550, 326);
            this.b_change.Name = "b_change";
            this.b_change.Size = new System.Drawing.Size(147, 98);
            this.b_change.TabIndex = 12;
            this.b_change.Text = "Change property";
            this.b_change.UseVisualStyleBackColor = true;
            this.b_change.Click += new System.EventHandler(this.b_change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 580);
            this.Controls.Add(this.b_change);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.propertybox);
            this.Controls.Add(this.modelbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.toy_box);
            this.Controls.Add(this.combo_interfaces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ComboBox combo_interfaces;
        private System.Windows.Forms.ComboBox toy_box;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modelbox;
        private System.Windows.Forms.TextBox propertybox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_change;
    }
}

