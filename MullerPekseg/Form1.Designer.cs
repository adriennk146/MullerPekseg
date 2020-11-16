namespace MullerPekseg
{
    partial class MullerPeksegForm
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
            this.tabok = new System.Windows.Forms.TabControl();
            this.Adatok = new System.Windows.Forms.TabPage();
            this.statisztikak = new System.Windows.Forms.TabPage();
            this.pekarukGB = new System.Windows.Forms.GroupBox();
            this.nevTB = new System.Windows.Forms.TextBox();
            this.arTB = new System.Windows.Forms.TextBox();
            this.laktozmentesCB = new System.Windows.Forms.CheckBox();
            this.hozzaadasBtn = new System.Windows.Forms.Button();
            this.peksegekGB = new System.Windows.Forms.GroupBox();
            this.hozzaad2Btn = new System.Windows.Forms.Button();
            this.peskegNevTB = new System.Windows.Forms.TextBox();
            this.pluszBtn = new System.Windows.Forms.Button();
            this.peksegekStatLstBx = new System.Windows.Forms.ListBox();
            this.statLbl = new System.Windows.Forms.Label();
            this.peksegekLstBx = new System.Windows.Forms.ListBox();
            this.pekaruPeksegLstVw = new System.Windows.Forms.ListView();
            this.pekaruLstBx = new System.Windows.Forms.ListBox();
            this.torlesBtn = new System.Windows.Forms.Button();
            this.tabok.SuspendLayout();
            this.Adatok.SuspendLayout();
            this.statisztikak.SuspendLayout();
            this.pekarukGB.SuspendLayout();
            this.peksegekGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabok
            // 
            this.tabok.Controls.Add(this.Adatok);
            this.tabok.Controls.Add(this.statisztikak);
            this.tabok.Location = new System.Drawing.Point(0, 3);
            this.tabok.Name = "tabok";
            this.tabok.SelectedIndex = 0;
            this.tabok.Size = new System.Drawing.Size(799, 449);
            this.tabok.TabIndex = 0;
            // 
            // Adatok
            // 
            this.Adatok.Controls.Add(this.peksegekGB);
            this.Adatok.Controls.Add(this.pekarukGB);
            this.Adatok.Location = new System.Drawing.Point(4, 22);
            this.Adatok.Name = "Adatok";
            this.Adatok.Padding = new System.Windows.Forms.Padding(3);
            this.Adatok.Size = new System.Drawing.Size(791, 423);
            this.Adatok.TabIndex = 0;
            this.Adatok.Text = "Adatok";
            this.Adatok.UseVisualStyleBackColor = true;
            // 
            // statisztikak
            // 
            this.statisztikak.Controls.Add(this.statLbl);
            this.statisztikak.Controls.Add(this.peksegekStatLstBx);
            this.statisztikak.Location = new System.Drawing.Point(4, 22);
            this.statisztikak.Name = "statisztikak";
            this.statisztikak.Padding = new System.Windows.Forms.Padding(3);
            this.statisztikak.Size = new System.Drawing.Size(791, 423);
            this.statisztikak.TabIndex = 1;
            this.statisztikak.Text = "Statisztikák";
            this.statisztikak.UseVisualStyleBackColor = true;
            // 
            // pekarukGB
            // 
            this.pekarukGB.Controls.Add(this.torlesBtn);
            this.pekarukGB.Controls.Add(this.pekaruLstBx);
            this.pekarukGB.Controls.Add(this.hozzaadasBtn);
            this.pekarukGB.Controls.Add(this.laktozmentesCB);
            this.pekarukGB.Controls.Add(this.arTB);
            this.pekarukGB.Controls.Add(this.nevTB);
            this.pekarukGB.Location = new System.Drawing.Point(22, 15);
            this.pekarukGB.Name = "pekarukGB";
            this.pekarukGB.Size = new System.Drawing.Size(751, 176);
            this.pekarukGB.TabIndex = 0;
            this.pekarukGB.TabStop = false;
            this.pekarukGB.Text = "Pékáruk";
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(31, 27);
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(153, 20);
            this.nevTB.TabIndex = 0;
            // 
            // arTB
            // 
            this.arTB.Location = new System.Drawing.Point(31, 53);
            this.arTB.Name = "arTB";
            this.arTB.Size = new System.Drawing.Size(153, 20);
            this.arTB.TabIndex = 1;
            // 
            // laktozmentesCB
            // 
            this.laktozmentesCB.AutoSize = true;
            this.laktozmentesCB.Location = new System.Drawing.Point(37, 83);
            this.laktozmentesCB.Name = "laktozmentesCB";
            this.laktozmentesCB.Size = new System.Drawing.Size(88, 17);
            this.laktozmentesCB.TabIndex = 2;
            this.laktozmentesCB.Text = "laktózmentes";
            this.laktozmentesCB.UseVisualStyleBackColor = true;
            // 
            // hozzaadasBtn
            // 
            this.hozzaadasBtn.Location = new System.Drawing.Point(31, 123);
            this.hozzaadasBtn.Name = "hozzaadasBtn";
            this.hozzaadasBtn.Size = new System.Drawing.Size(144, 27);
            this.hozzaadasBtn.TabIndex = 3;
            this.hozzaadasBtn.Text = "Hozzáadás";
            this.hozzaadasBtn.UseVisualStyleBackColor = true;
            this.hozzaadasBtn.Click += new System.EventHandler(this.hozzaadasBtn_Click);
            // 
            // peksegekGB
            // 
            this.peksegekGB.Controls.Add(this.pekaruPeksegLstVw);
            this.peksegekGB.Controls.Add(this.pluszBtn);
            this.peksegekGB.Controls.Add(this.peksegekLstBx);
            this.peksegekGB.Controls.Add(this.hozzaad2Btn);
            this.peksegekGB.Controls.Add(this.peskegNevTB);
            this.peksegekGB.Location = new System.Drawing.Point(22, 210);
            this.peksegekGB.Name = "peksegekGB";
            this.peksegekGB.Size = new System.Drawing.Size(751, 189);
            this.peksegekGB.TabIndex = 5;
            this.peksegekGB.TabStop = false;
            this.peksegekGB.Text = "Pékségek";
            // 
            // hozzaad2Btn
            // 
            this.hozzaad2Btn.Location = new System.Drawing.Point(37, 95);
            this.hozzaad2Btn.Name = "hozzaad2Btn";
            this.hozzaad2Btn.Size = new System.Drawing.Size(144, 27);
            this.hozzaad2Btn.TabIndex = 3;
            this.hozzaad2Btn.Text = "Hozzáadás";
            this.hozzaad2Btn.UseVisualStyleBackColor = true;
            this.hozzaad2Btn.Click += new System.EventHandler(this.hozzaad2Btn_Click);
            // 
            // peskegNevTB
            // 
            this.peskegNevTB.Location = new System.Drawing.Point(31, 38);
            this.peskegNevTB.Name = "peskegNevTB";
            this.peskegNevTB.Size = new System.Drawing.Size(153, 20);
            this.peskegNevTB.TabIndex = 0;
            // 
            // pluszBtn
            // 
            this.pluszBtn.Location = new System.Drawing.Point(597, 128);
            this.pluszBtn.Name = "pluszBtn";
            this.pluszBtn.Size = new System.Drawing.Size(43, 27);
            this.pluszBtn.TabIndex = 6;
            this.pluszBtn.Text = "+";
            this.pluszBtn.UseVisualStyleBackColor = true;
            // 
            // peksegekStatLstBx
            // 
            this.peksegekStatLstBx.FormattingEnabled = true;
            this.peksegekStatLstBx.Location = new System.Drawing.Point(21, 23);
            this.peksegekStatLstBx.Name = "peksegekStatLstBx";
            this.peksegekStatLstBx.Size = new System.Drawing.Size(260, 160);
            this.peksegekStatLstBx.TabIndex = 0;
            // 
            // statLbl
            // 
            this.statLbl.AutoSize = true;
            this.statLbl.Location = new System.Drawing.Point(313, 23);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(35, 13);
            this.statLbl.TabIndex = 1;
            this.statLbl.Text = "label1";
            // 
            // peksegekLstBx
            // 
            this.peksegekLstBx.FormattingEnabled = true;
            this.peksegekLstBx.Location = new System.Drawing.Point(261, 27);
            this.peksegekLstBx.Name = "peksegekLstBx";
            this.peksegekLstBx.Size = new System.Drawing.Size(219, 134);
            this.peksegekLstBx.TabIndex = 4;
            // 
            // pekaruPeksegLstVw
            // 
            this.pekaruPeksegLstVw.HideSelection = false;
            this.pekaruPeksegLstVw.Location = new System.Drawing.Point(510, 27);
            this.pekaruPeksegLstVw.Name = "pekaruPeksegLstVw";
            this.pekaruPeksegLstVw.Size = new System.Drawing.Size(204, 95);
            this.pekaruPeksegLstVw.TabIndex = 5;
            this.pekaruPeksegLstVw.UseCompatibleStateImageBehavior = false;
            // 
            // pekaruLstBx
            // 
            this.pekaruLstBx.FormattingEnabled = true;
            this.pekaruLstBx.Location = new System.Drawing.Point(261, 27);
            this.pekaruLstBx.Name = "pekaruLstBx";
            this.pekaruLstBx.Size = new System.Drawing.Size(453, 82);
            this.pekaruLstBx.TabIndex = 7;
            this.pekaruLstBx.SelectedIndexChanged += new System.EventHandler(this.pekaruLstBx_SelectedIndexChanged);
            // 
            // torlesBtn
            // 
            this.torlesBtn.Location = new System.Drawing.Point(261, 123);
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(144, 27);
            this.torlesBtn.TabIndex = 8;
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.UseVisualStyleBackColor = true;
            this.torlesBtn.Visible = false;
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // MullerPeksegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabok);
            this.Name = "MullerPeksegForm";
            this.Text = "Müller Pékség";
            this.tabok.ResumeLayout(false);
            this.Adatok.ResumeLayout(false);
            this.statisztikak.ResumeLayout(false);
            this.statisztikak.PerformLayout();
            this.pekarukGB.ResumeLayout(false);
            this.pekarukGB.PerformLayout();
            this.peksegekGB.ResumeLayout(false);
            this.peksegekGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabok;
        private System.Windows.Forms.TabPage Adatok;
        private System.Windows.Forms.GroupBox peksegekGB;
        private System.Windows.Forms.ListView pekaruPeksegLstVw;
        private System.Windows.Forms.Button pluszBtn;
        private System.Windows.Forms.ListBox peksegekLstBx;
        private System.Windows.Forms.Button hozzaad2Btn;
        private System.Windows.Forms.TextBox peskegNevTB;
        private System.Windows.Forms.GroupBox pekarukGB;
        private System.Windows.Forms.Button hozzaadasBtn;
        private System.Windows.Forms.CheckBox laktozmentesCB;
        private System.Windows.Forms.TextBox arTB;
        private System.Windows.Forms.TextBox nevTB;
        private System.Windows.Forms.TabPage statisztikak;
        private System.Windows.Forms.Label statLbl;
        private System.Windows.Forms.ListBox peksegekStatLstBx;
        private System.Windows.Forms.ListBox pekaruLstBx;
        private System.Windows.Forms.Button torlesBtn;
    }
}

