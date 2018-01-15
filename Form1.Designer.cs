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
            this.Ax = new System.Windows.Forms.Label();
            this.Bx = new System.Windows.Forms.Label();
            this.Cx = new System.Windows.Forms.Label();
            this.Dx = new System.Windows.Forms.Label();
            this.Mov = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
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
            // Mov
            // 
            this.Mov.Location = new System.Drawing.Point(269, 34);
            this.Mov.Name = "Mov";
            this.Mov.Size = new System.Drawing.Size(75, 23);
            this.Mov.TabIndex = 4;
            this.Mov.Text = "MOV";
            this.Mov.UseVisualStyleBackColor = true;
            this.Mov.Click += new System.EventHandler(this.Mov_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(269, 73);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(269, 110);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 6;
            this.Sub.Text = "SUB";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 19);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 289);
            this.Controls.Add(this.natychmiastowe);
            this.Controls.Add(this.commit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Mov);
            this.Controls.Add(this.Dx);
            this.Controls.Add(this.Cx);
            this.Controls.Add(this.Bx);
            this.Controls.Add(this.Ax);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button Mov;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
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
    }
}

