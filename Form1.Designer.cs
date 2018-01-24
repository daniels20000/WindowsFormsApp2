namespace POSK
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
            this.components = new System.ComponentModel.Container();
            this.Ax = new System.Windows.Forms.Label();
            this.Bx = new System.Windows.Forms.Label();
            this.Cx = new System.Windows.Forms.Label();
            this.Dx = new System.Windows.Forms.Label();
            this.buttonMov = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRozkaz1 = new System.Windows.Forms.Label();
            this.labelRozkaz2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRozkaz3 = new System.Windows.Forms.Label();
            this.commit = new System.Windows.Forms.Button();
            this.natychmiastowe = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelKolejka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doKolejki = new System.Windows.Forms.Button();
            this.wykonajKolejke = new System.Windows.Forms.Button();
            this.krokowa = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonOtworz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.buttonPush = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonPrzerwanie = new System.Windows.Forms.Button();
            this.AHBox = new System.Windows.Forms.TextBox();
            this.ALBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ax
            // 
            this.Ax.AutoSize = true;
            this.Ax.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Ax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ax.Location = new System.Drawing.Point(98, 40);
            this.Ax.MinimumSize = new System.Drawing.Size(150, 13);
            this.Ax.Name = "Ax";
            this.Ax.Size = new System.Drawing.Size(150, 17);
            this.Ax.TabIndex = 0;
            this.Ax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bx
            // 
            this.Bx.AutoSize = true;
            this.Bx.BackColor = System.Drawing.Color.Crimson;
            this.Bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bx.Location = new System.Drawing.Point(98, 70);
            this.Bx.MinimumSize = new System.Drawing.Size(150, 13);
            this.Bx.Name = "Bx";
            this.Bx.Size = new System.Drawing.Size(150, 17);
            this.Bx.TabIndex = 1;
            this.Bx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cx
            // 
            this.Cx.AutoSize = true;
            this.Cx.BackColor = System.Drawing.Color.Coral;
            this.Cx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cx.Location = new System.Drawing.Point(98, 100);
            this.Cx.MinimumSize = new System.Drawing.Size(150, 13);
            this.Cx.Name = "Cx";
            this.Cx.Size = new System.Drawing.Size(150, 17);
            this.Cx.TabIndex = 2;
            this.Cx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dx
            // 
            this.Dx.AutoSize = true;
            this.Dx.BackColor = System.Drawing.Color.Cyan;
            this.Dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dx.Location = new System.Drawing.Point(98, 130);
            this.Dx.MinimumSize = new System.Drawing.Size(150, 13);
            this.Dx.Name = "Dx";
            this.Dx.Size = new System.Drawing.Size(150, 17);
            this.Dx.TabIndex = 3;
            this.Dx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMov
            // 
            this.buttonMov.Location = new System.Drawing.Point(269, 34);
            this.buttonMov.Name = "buttonMov";
            this.buttonMov.Size = new System.Drawing.Size(75, 23);
            this.buttonMov.TabIndex = 4;
            this.buttonMov.Text = "MOV";
            this.buttonMov.UseVisualStyleBackColor = true;
            this.buttonMov.Click += new System.EventHandler(this.Mov_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(269, 73);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(269, 110);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 6;
            this.buttonSub.Text = "SUB";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AX: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BX: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CX: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DX: ";
            // 
            // labelRozkaz1
            // 
            this.labelRozkaz1.AutoSize = true;
            this.labelRozkaz1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRozkaz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozkaz1.Location = new System.Drawing.Point(0, 0);
            this.labelRozkaz1.Margin = new System.Windows.Forms.Padding(0);
            this.labelRozkaz1.MinimumSize = new System.Drawing.Size(42, 13);
            this.labelRozkaz1.Name = "labelRozkaz1";
            this.labelRozkaz1.Size = new System.Drawing.Size(42, 17);
            this.labelRozkaz1.TabIndex = 11;
            // 
            // labelRozkaz2
            // 
            this.labelRozkaz2.AutoSize = true;
            this.labelRozkaz2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRozkaz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozkaz2.Location = new System.Drawing.Point(42, 0);
            this.labelRozkaz2.Margin = new System.Windows.Forms.Padding(0);
            this.labelRozkaz2.MaximumSize = new System.Drawing.Size(50, 0);
            this.labelRozkaz2.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelRozkaz2.Name = "labelRozkaz2";
            this.labelRozkaz2.Size = new System.Drawing.Size(80, 17);
            this.labelRozkaz2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.labelRozkaz1);
            this.flowLayoutPanel1.Controls.Add(this.labelRozkaz2);
            this.flowLayoutPanel1.Controls.Add(this.labelRozkaz3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(354, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 21);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // labelRozkaz3
            // 
            this.labelRozkaz3.AutoSize = true;
            this.labelRozkaz3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRozkaz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozkaz3.Location = new System.Drawing.Point(122, 0);
            this.labelRozkaz3.Margin = new System.Windows.Forms.Padding(0);
            this.labelRozkaz3.MaximumSize = new System.Drawing.Size(50, 0);
            this.labelRozkaz3.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelRozkaz3.Name = "labelRozkaz3";
            this.labelRozkaz3.Size = new System.Drawing.Size(80, 17);
            this.labelRozkaz3.TabIndex = 13;
            // 
            // commit
            // 
            this.commit.Location = new System.Drawing.Point(481, 64);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(75, 23);
            this.commit.TabIndex = 14;
            this.commit.Text = "Wykonaj";
            this.commit.UseVisualStyleBackColor = true;
            this.commit.Click += new System.EventHandler(this.commit_Click);
            // 
            // natychmiastowe
            // 
            this.natychmiastowe.Location = new System.Drawing.Point(354, 113);
            this.natychmiastowe.Name = "natychmiastowe";
            this.natychmiastowe.Size = new System.Drawing.Size(100, 20);
            this.natychmiastowe.TabIndex = 15;
            this.natychmiastowe.Text = "podaj argument";
            this.natychmiastowe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.natychmiastowe_KeyPress);
            this.natychmiastowe.Leave += new System.EventHandler(this.natychmiastowe_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.comboBox1.Location = new System.Drawing.Point(354, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "wybierz rejestr";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelKolejka
            // 
            this.labelKolejka.AutoSize = true;
            this.labelKolejka.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelKolejka.Location = new System.Drawing.Point(98, 253);
            this.labelKolejka.MinimumSize = new System.Drawing.Size(150, 90);
            this.labelKolejka.Name = "labelKolejka";
            this.labelKolejka.Size = new System.Drawing.Size(150, 90);
            this.labelKolejka.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "kolejka";
            // 
            // doKolejki
            // 
            this.doKolejki.Location = new System.Drawing.Point(479, 110);
            this.doKolejki.Name = "doKolejki";
            this.doKolejki.Size = new System.Drawing.Size(75, 47);
            this.doKolejki.TabIndex = 19;
            this.doKolejki.Text = "dodaj do kolejki";
            this.doKolejki.UseVisualStyleBackColor = true;
            this.doKolejki.Click += new System.EventHandler(this.doKolejki_Click);
            // 
            // wykonajKolejke
            // 
            this.wykonajKolejke.Location = new System.Drawing.Point(101, 346);
            this.wykonajKolejke.Name = "wykonajKolejke";
            this.wykonajKolejke.Size = new System.Drawing.Size(62, 55);
            this.wykonajKolejke.TabIndex = 20;
            this.wykonajKolejke.Text = "Wykonaj kolejkę";
            this.wykonajKolejke.UseVisualStyleBackColor = true;
            this.wykonajKolejke.Click += new System.EventHandler(this.wykonajKolejke_Click);
            // 
            // krokowa
            // 
            this.krokowa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.krokowa.Location = new System.Drawing.Point(182, 346);
            this.krokowa.Name = "krokowa";
            this.krokowa.Size = new System.Drawing.Size(62, 55);
            this.krokowa.TabIndex = 21;
            this.krokowa.Text = "Praca krokowa";
            this.krokowa.UseVisualStyleBackColor = true;
            this.krokowa.Click += new System.EventHandler(this.krokowa_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(269, 248);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 22;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonOtworz
            // 
            this.buttonOtworz.Location = new System.Drawing.Point(350, 248);
            this.buttonOtworz.Name = "buttonOtworz";
            this.buttonOtworz.Size = new System.Drawing.Size(75, 23);
            this.buttonOtworz.TabIndex = 23;
            this.buttonOtworz.Text = "Otwórz";
            this.buttonOtworz.UseVisualStyleBackColor = true;
            this.buttonOtworz.Click += new System.EventHandler(this.buttonOtworz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(357, 70);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(75, 23);
            this.buttonWyczysc.TabIndex = 25;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(269, 139);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(75, 23);
            this.buttonPush.TabIndex = 26;
            this.buttonPush.Text = "PUSH";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(269, 168);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(75, 23);
            this.buttonPop.TabIndex = 27;
            this.buttonPop.Text = "POP";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "IP: ";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIP.Location = new System.Drawing.Point(98, 159);
            this.labelIP.MinimumSize = new System.Drawing.Size(150, 13);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(150, 17);
            this.labelIP.TabIndex = 28;
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10h",
            "15h",
            "16h",
            "1Ah",
            "1Ch"});
            this.comboBox2.Location = new System.Drawing.Point(275, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.Text = "numer przerwania";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "numer przerwania";
            // 
            // buttonPrzerwanie
            // 
            this.buttonPrzerwanie.Location = new System.Drawing.Point(402, 322);
            this.buttonPrzerwanie.Name = "buttonPrzerwanie";
            this.buttonPrzerwanie.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwanie.TabIndex = 32;
            this.buttonPrzerwanie.Text = "wykonaj";
            this.buttonPrzerwanie.UseVisualStyleBackColor = true;
            this.buttonPrzerwanie.Click += new System.EventHandler(this.buttonPrzerwanie_Click);
            // 
            // AHBox
            // 
            this.AHBox.Location = new System.Drawing.Point(269, 364);
            this.AHBox.Name = "AHBox";
            this.AHBox.Size = new System.Drawing.Size(100, 20);
            this.AHBox.TabIndex = 33;
            this.AHBox.Text = "0";
            // 
            // ALBox
            // 
            this.ALBox.Location = new System.Drawing.Point(375, 364);
            this.ALBox.Name = "ALBox";
            this.ALBox.Size = new System.Drawing.Size(100, 20);
            this.ALBox.TabIndex = 34;
            this.ALBox.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ustaw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ALBox);
            this.Controls.Add(this.AHBox);
            this.Controls.Add(this.buttonPrzerwanie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonOtworz);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.krokowa);
            this.Controls.Add(this.wykonajKolejke);
            this.Controls.Add(this.doKolejki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelKolejka);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.natychmiastowe);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMov);
            this.Controls.Add(this.Dx);
            this.Controls.Add(this.Cx);
            this.Controls.Add(this.Bx);
            this.Controls.Add(this.Ax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ax;
        private System.Windows.Forms.Label Bx;
        private System.Windows.Forms.Label Cx;
        private System.Windows.Forms.Label Dx;
        private System.Windows.Forms.Button buttonMov;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRozkaz1;
        private System.Windows.Forms.Label labelRozkaz2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelRozkaz3;
        private System.Windows.Forms.Button commit;
        private System.Windows.Forms.TextBox natychmiastowe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelKolejka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button doKolejki;
        private System.Windows.Forms.Button wykonajKolejke;
        private System.Windows.Forms.Button krokowa;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonOtworz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonPrzerwanie;
        private System.Windows.Forms.TextBox AHBox;
        private System.Windows.Forms.TextBox ALBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
    }
}

