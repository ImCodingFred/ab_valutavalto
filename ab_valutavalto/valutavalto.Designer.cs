namespace ab_valutavalto
{
    partial class valutavalto
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
            this.btn_elvet = new System.Windows.Forms.Button();
            this.btn_ment = new System.Windows.Forms.Button();
            this.tb_osszeg = new System.Windows.Forms.TextBox();
            this.cb_deviza = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_fromhuf = new System.Windows.Forms.RadioButton();
            this.rb_tohuf = new System.Windows.Forms.RadioButton();
            this.l_hufegys = new System.Windows.Forms.Label();
            this.l_devertek = new System.Windows.Forms.Label();
            this.l_hufertek = new System.Windows.Forms.Label();
            this.l_devegseg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_arrow = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.l_dev = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_elvet
            // 
            this.btn_elvet.Location = new System.Drawing.Point(309, 371);
            this.btn_elvet.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_elvet.Name = "btn_elvet";
            this.btn_elvet.Size = new System.Drawing.Size(103, 23);
            this.btn_elvet.TabIndex = 20;
            this.btn_elvet.Text = "Elvetés";
            this.btn_elvet.UseVisualStyleBackColor = true;
            this.btn_elvet.Click += new System.EventHandler(this.btn_elvet_Click);
            // 
            // btn_ment
            // 
            this.btn_ment.Location = new System.Drawing.Point(112, 371);
            this.btn_ment.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(103, 23);
            this.btn_ment.TabIndex = 21;
            this.btn_ment.Text = "Mentés";
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.btn_ment_Click);
            // 
            // tb_osszeg
            // 
            this.tb_osszeg.Location = new System.Drawing.Point(394, 156);
            this.tb_osszeg.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tb_osszeg.Name = "tb_osszeg";
            this.tb_osszeg.Size = new System.Drawing.Size(135, 20);
            this.tb_osszeg.TabIndex = 19;
            this.tb_osszeg.TextChanged += new System.EventHandler(this.tb_osszeg_TextChanged);
            // 
            // cb_deviza
            // 
            this.cb_deviza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_deviza.FormattingEnabled = true;
            this.cb_deviza.Location = new System.Drawing.Point(112, 61);
            this.cb_deviza.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cb_deviza.Name = "cb_deviza";
            this.cb_deviza.Size = new System.Drawing.Size(163, 21);
            this.cb_deviza.TabIndex = 18;
            this.cb_deviza.SelectedIndexChanged += new System.EventHandler(this.cb_deviza_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_fromhuf);
            this.groupBox1.Controls.Add(this.rb_tohuf);
            this.groupBox1.Location = new System.Drawing.Point(30, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(261, 89);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Átváltás íránya";
            // 
            // rb_fromhuf
            // 
            this.rb_fromhuf.AutoSize = true;
            this.rb_fromhuf.Location = new System.Drawing.Point(17, 21);
            this.rb_fromhuf.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rb_fromhuf.Name = "rb_fromhuf";
            this.rb_fromhuf.Size = new System.Drawing.Size(73, 17);
            this.rb_fromhuf.TabIndex = 0;
            this.rb_fromhuf.TabStop = true;
            this.rb_fromhuf.Text = "HUF to -";
            this.rb_fromhuf.UseVisualStyleBackColor = true;
            this.rb_fromhuf.CheckedChanged += new System.EventHandler(this.rb_fromhuf_CheckedChanged);
            // 
            // rb_tohuf
            // 
            this.rb_tohuf.AutoSize = true;
            this.rb_tohuf.Location = new System.Drawing.Point(17, 55);
            this.rb_tohuf.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rb_tohuf.Name = "rb_tohuf";
            this.rb_tohuf.Size = new System.Drawing.Size(73, 17);
            this.rb_tohuf.TabIndex = 0;
            this.rb_tohuf.TabStop = true;
            this.rb_tohuf.Text = "- to HUF";
            this.rb_tohuf.UseVisualStyleBackColor = true;
            // 
            // l_hufegys
            // 
            this.l_hufegys.AutoSize = true;
            this.l_hufegys.Location = new System.Drawing.Point(481, 107);
            this.l_hufegys.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_hufegys.Name = "l_hufegys";
            this.l_hufegys.Size = new System.Drawing.Size(14, 13);
            this.l_hufegys.TabIndex = 6;
            this.l_hufegys.Text = "0";
            // 
            // l_devertek
            // 
            this.l_devertek.AutoSize = true;
            this.l_devertek.ForeColor = System.Drawing.Color.Red;
            this.l_devertek.Location = new System.Drawing.Point(379, 302);
            this.l_devertek.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_devertek.Name = "l_devertek";
            this.l_devertek.Size = new System.Drawing.Size(14, 13);
            this.l_devertek.TabIndex = 7;
            this.l_devertek.Text = "0";
            // 
            // l_hufertek
            // 
            this.l_hufertek.AutoSize = true;
            this.l_hufertek.ForeColor = System.Drawing.Color.Red;
            this.l_hufertek.Location = new System.Drawing.Point(44, 302);
            this.l_hufertek.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_hufertek.Name = "l_hufertek";
            this.l_hufertek.Size = new System.Drawing.Size(14, 13);
            this.l_hufertek.TabIndex = 8;
            this.l_hufertek.Text = "0";
            // 
            // l_devegseg
            // 
            this.l_devegseg.AutoSize = true;
            this.l_devegseg.Location = new System.Drawing.Point(496, 64);
            this.l_devegseg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_devegseg.Name = "l_devegseg";
            this.l_devegseg.Size = new System.Drawing.Size(14, 13);
            this.l_devegseg.TabIndex = 9;
            this.l_devegseg.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "HUF egység:";
            // 
            // l_arrow
            // 
            this.l_arrow.AutoSize = true;
            this.l_arrow.ForeColor = System.Drawing.Color.Red;
            this.l_arrow.Location = new System.Drawing.Point(212, 281);
            this.l_arrow.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_arrow.Name = "l_arrow";
            this.l_arrow.Size = new System.Drawing.Size(38, 13);
            this.l_arrow.TabIndex = 11;
            this.l_arrow.Text = "- - - >";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 159);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Összeg:";
            // 
            // l_dev
            // 
            this.l_dev.AutoSize = true;
            this.l_dev.ForeColor = System.Drawing.Color.Red;
            this.l_dev.Location = new System.Drawing.Point(379, 259);
            this.l_dev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_dev.Name = "l_dev";
            this.l_dev.Size = new System.Drawing.Size(11, 13);
            this.l_dev.TabIndex = 13;
            this.l_dev.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(44, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "HUF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Deviza egység:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Deviza:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // valutavalto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 405);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_elvet);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.tb_osszeg);
            this.Controls.Add(this.cb_deviza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_hufegys);
            this.Controls.Add(this.l_devertek);
            this.Controls.Add(this.l_hufertek);
            this.Controls.Add(this.l_devegseg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_arrow);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.l_dev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "valutavalto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "valutavalto";
            this.Load += new System.EventHandler(this.valutavalto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_elvet;
        private System.Windows.Forms.Button btn_ment;
        private System.Windows.Forms.TextBox tb_osszeg;
        private System.Windows.Forms.ComboBox cb_deviza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_fromhuf;
        private System.Windows.Forms.RadioButton rb_tohuf;
        private System.Windows.Forms.Label l_hufegys;
        private System.Windows.Forms.Label l_devertek;
        private System.Windows.Forms.Label l_hufertek;
        private System.Windows.Forms.Label l_devegseg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_arrow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_dev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}