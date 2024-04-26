namespace ab_valutavalto
{
    partial class arfolyamrogz
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_devnem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_devegys = new System.Windows.Forms.TextBox();
            this.tb_hufegys = new System.Windows.Forms.TextBox();
            this.btn_elvet = new System.Windows.Forms.Button();
            this.btn_ment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cb_devnem
            // 
            this.cb_devnem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_devnem.FormattingEnabled = true;
            this.cb_devnem.Location = new System.Drawing.Point(125, 72);
            this.cb_devnem.Name = "cb_devnem";
            this.cb_devnem.Size = new System.Drawing.Size(121, 21);
            this.cb_devnem.TabIndex = 1;
            this.cb_devnem.SelectedIndexChanged += new System.EventHandler(this.cb_devnem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dátum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Devizanem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "HUF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_hufegys);
            this.groupBox1.Controls.Add(this.tb_devegys);
            this.groupBox1.Location = new System.Drawing.Point(265, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egység";
            // 
            // tb_devegys
            // 
            this.tb_devegys.Location = new System.Drawing.Point(30, 32);
            this.tb_devegys.Name = "tb_devegys";
            this.tb_devegys.Size = new System.Drawing.Size(100, 20);
            this.tb_devegys.TabIndex = 0;
            this.tb_devegys.TextChanged += new System.EventHandler(this.tb_devegys_TextChanged);
            // 
            // tb_hufegys
            // 
            this.tb_hufegys.Location = new System.Drawing.Point(30, 63);
            this.tb_hufegys.Name = "tb_hufegys";
            this.tb_hufegys.Size = new System.Drawing.Size(100, 20);
            this.tb_hufegys.TabIndex = 0;
            this.tb_hufegys.TextChanged += new System.EventHandler(this.tb_hufegys_TextChanged);
            // 
            // btn_elvet
            // 
            this.btn_elvet.Location = new System.Drawing.Point(295, 161);
            this.btn_elvet.Name = "btn_elvet";
            this.btn_elvet.Size = new System.Drawing.Size(75, 23);
            this.btn_elvet.TabIndex = 4;
            this.btn_elvet.Text = "Elvetés";
            this.btn_elvet.UseVisualStyleBackColor = true;
            this.btn_elvet.Click += new System.EventHandler(this.btn_elvet_Click);
            // 
            // btn_ment
            // 
            this.btn_ment.Location = new System.Drawing.Point(94, 161);
            this.btn_ment.Name = "btn_ment";
            this.btn_ment.Size = new System.Drawing.Size(75, 23);
            this.btn_ment.TabIndex = 5;
            this.btn_ment.Text = "Mentés";
            this.btn_ment.UseVisualStyleBackColor = true;
            this.btn_ment.Click += new System.EventHandler(this.btn_ment_Click);
            // 
            // arfolyamrogz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 196);
            this.Controls.Add(this.btn_elvet);
            this.Controls.Add(this.btn_ment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_devnem);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "arfolyamrogz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "arfolyamrogz";
            this.Load += new System.EventHandler(this.arfolyamrogz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_devnem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_hufegys;
        private System.Windows.Forms.TextBox tb_devegys;
        private System.Windows.Forms.Button btn_elvet;
        private System.Windows.Forms.Button btn_ment;
    }
}