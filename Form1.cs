using System;
using System.Windows.Forms;

namespace POSK

{
    public partial class Form1 : Form
    {
        public Rejestr A = new Rejestr();
        public Rejestr B = new Rejestr();
        public Rejestr C = new Rejestr();
        public Rejestr D = new Rejestr();
        public int operacja = -1;
        public int indexArgument = 1;
        public int arg1=0;
        public int arg2=0;
        public Form1()
        {            
            InitializeComponent();
            
            A.setValue(65);
            refresh();



        }

       public void refresh()
        {
            Ax.Text = A.getStringValue();
            Bx.Text = B.getStringValue();
            Cx.Text = C.getStringValue();
            Dx.Text = D.getStringValue();
        }

        private void Mov_Click(object sender, EventArgs e)
        {
            labelRozkaz1.Text = "MOV ";
            operacja = 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            labelRozkaz1.Text = "ADD ";
            operacja = 1;
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            labelRozkaz1.Text = "SUB ";
            operacja = 2;
        }

        private void natychmiastowe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
                if(operacja!=-1)
            {
                switch (indexArgument)
                {
                    case 1:
                        {
                            short i;
                            if (Int16.TryParse(natychmiastowe.Text, out i))
                            {
                                labelRozkaz2.Text = natychmiastowe.Text;
                                arg1 = i;
                                indexArgument = 2;
                            }
                            else
                            {
                                natychmiastowe.Text = "to nie liczba";
                                natychmiastowe.SelectAll();
                            }


                        }break;
                    case 2:
                        {
                            short i;
                            if (Int16.TryParse(natychmiastowe.Text, out i))
                            {
                                labelRozkaz3.Text = natychmiastowe.Text;
                                arg2 = i;
                                indexArgument = 1;
                            }
                            else
                            {
                                natychmiastowe.Text = "to nie liczba";
                                natychmiastowe.SelectAll();
                            }


                        }
                        break;
                }
            }else
                {
                    natychmiastowe.Text = "wybierz operację ";
                    natychmiastowe.SelectAll();
                }
        }

        private void natychmiastowe_Leave(object sender, EventArgs e)
        {
            natychmiastowe.Text = "podaj argument";
        }
    }
}
