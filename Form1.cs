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

        public int arg=0;

        public bool czyWybranoRejestr = false;

        public bool rejestrowe;
        public Rejestr rejDocelowy;
        public Rejestr rejZrodlowy;

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

                    if (czyWybranoRejestr)
                    {
                        short i;
                        if (Int16.TryParse(natychmiastowe.Text, out i))
                        {
                            labelRozkaz3.Text = natychmiastowe.Text;
                            arg = i;

                        }
                        else
                        {
                            natychmiastowe.Text = "to nie liczba";
                            natychmiastowe.SelectAll();
                        }
                    }
                    else
                    {
                        natychmiastowe.Text = "wybierz rejestr";
                        natychmiastowe.SelectAll();
                    }
            }else
                {
                    natychmiastowe.Text = "wybierz operację";
                    natychmiastowe.SelectAll();
                }
            else if(e.KeyChar==(char)27)
            {
                arg = 0;
                
                labelRozkaz1.Text = "";
                labelRozkaz2.Text = "";
                labelRozkaz3.Text = "";
                operacja = -1;
            }
        }

        private void natychmiastowe_Leave(object sender, EventArgs e)
        {
            natychmiastowe.Text = "podaj argument";
        }

        private void commit_Click(object sender, EventArgs e)
        {
            if (rejestrowe)
            {

            }
            else{
                switch (operacja)
                {
                    case -1:
                        {
                            natychmiastowe.Text = "wybierz operację";

                        } break;
                    case 0:
                        {
                            MovNatychmiastowe();
                        } break;
                }
            }
            refresh();
        }

        public void MovNatychmiastowe()
        {
            
        }
        public void Add()
        {

        }
        public void Sub()
        {

        }
    }
}
