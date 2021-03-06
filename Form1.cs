﻿using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using Microsoft.VisualBasic.Devices;
using System.Data;

namespace POSK

{
    public partial class Form1 : Form
    {
        public Rejestr A = new Rejestr("AX");
        public Rejestr B = new Rejestr("BX");
        public Rejestr C = new Rejestr("CX");
        public Rejestr D = new Rejestr("DX");
        public Rejestr IP = new Rejestr("IP");

        public int operacja = -1;

        public int arg=0;

        public bool czyWybranoDocelowyRejestr = false;

        public bool rejestrowe;
        public Rejestr rejDocelowy;
        public Rejestr rejZrodlowy;

        public List<Rozkaz> listaRozkazow = new List<Rozkaz>();
        public int indeks;

        public short[] stos = new short[8];
        public int SP = 7;
        public Form1()
        {            
            InitializeComponent();
            refresh();            
        }

       public void refresh()
        {
            Ax.Text = A.getStringValue();
            Bx.Text = B.getStringValue();
            Cx.Text = C.getStringValue();
            Dx.Text = D.getStringValue();
            IP.setValue(SP);
            labelIP.Text = IP.getStringValue();
            refreshKolejka();
        }

        public void refreshKolejka()
        {
          
                indeks = listaRozkazow.Count-1;

            labelKolejka.Text = "";

            foreach(Rozkaz r in listaRozkazow)
            {
                String s = labelKolejka.Text;
                labelKolejka.Text = r.tekstRozkazu() + s;
            }
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
                    if (czyWybranoDocelowyRejestr)
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

                } else
                    {
                        natychmiastowe.Text = "wybierz operację";
                        natychmiastowe.SelectAll();

                    }


            //else if(e.KeyChar==(char)27)
            //{
            //    Clear();
            //}
        }

        private void natychmiastowe_Leave(object sender, EventArgs e)
        {
            natychmiastowe.Text = "podaj argument";
        }

        private void commit_Click(object sender, EventArgs e)
        {
            
            
                switch (operacja)
                {
                    case -1:
                        {
                            natychmiastowe.Text = "wybierz operację";

                        } break;
                    case 0:
                        {
                            if (rejestrowe)
                                Mov();
                            else
                                MovNatychmiastowe();
                        } break;
                    case 1:
                        {
                            if (rejestrowe)
                                Add();
                            else
                               AddNatychmiastowe();
                        }
                        break;
                    case 2:
                        {
                            if (rejestrowe)
                               Sub();
                            else
                                SubNatychmiastowe();
                        }
                        break;
                
            }
            refresh();
            Clear();
            
        }
        public void Mov()
        {
            rejDocelowy.setValue(rejZrodlowy.getValue()) ;
           // rejZrodlowy.setValue(0);           
        }
        public void MovNatychmiastowe()
        {
            rejDocelowy.setValue(arg);
        }

        public void Add()
        {
            rejDocelowy.AddValue(rejZrodlowy.getValue());

        }
        public void AddNatychmiastowe()
        {
            rejDocelowy.AddValue(arg);
        }

        public void Sub()
        {
            rejDocelowy.SubValue(rejZrodlowy.getValue());
        }
        public void SubNatychmiastowe()
        {
            rejDocelowy.SubValue(arg);
        }


        public void Clear()
        {
            arg = 0;
            rejDocelowy = new Rejestr();
            rejZrodlowy = new Rejestr();
            labelRozkaz1.Text = "";
            labelRozkaz2.Text = "";
            labelRozkaz3.Text = "";
            operacja = -1;
            czyWybranoDocelowyRejestr = false;
            rejestrowe = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboBox box = (ComboBox)sender;

          
            switch (box.SelectedIndex)
            {
                case 0:
                    {
                        if (czyWybranoDocelowyRejestr)
                        {
                            rejZrodlowy = A;
                            labelRozkaz3.Text = "AX";
                            rejestrowe = true;
                        }
                        else
                        {
                            rejDocelowy = A;
                            labelRozkaz2.Text = "AX";
                            czyWybranoDocelowyRejestr = true;
                            
                        }
                    }break;
                case 1:
                    {
                        if (czyWybranoDocelowyRejestr)
                        {
                            rejZrodlowy = B;
                            labelRozkaz3.Text = "BX";
                            rejestrowe = true;
                        }
                        else
                        {
                            rejDocelowy = B;
                            labelRozkaz2.Text = "BX";
                            czyWybranoDocelowyRejestr = true;
                        }
                    }
                    break;
                case 2:
                    {
                        if (czyWybranoDocelowyRejestr)
                        {
                            rejZrodlowy = C;
                            labelRozkaz3.Text = "CX";
                            rejestrowe = true;
                        }
                        else
                        {
                            rejDocelowy = C;
                            labelRozkaz2.Text = "CX";
                            czyWybranoDocelowyRejestr = true;
                           
                        }
                    }
                    break;
                case 3:
                    {
                        if (czyWybranoDocelowyRejestr)
                        {
                            rejZrodlowy = D;
                            labelRozkaz3.Text = "DX";
                            rejestrowe = true;
                        }
                        else
                        {
                            rejDocelowy = D;
                            labelRozkaz2.Text = "DX";
                            czyWybranoDocelowyRejestr = true;
                            
                        }
                    }
                    break;
            }
        }

        private void doKolejki_Click(object sender, EventArgs e)
        {
            Rozkaz r = new Rozkaz();
            r.operacja = operacja;
            r.arg1=rejDocelowy;
            if (rejestrowe)
            {
                r.arg2 = rejZrodlowy;
            }
            else
            {
                r.arg2 = arg;
            }
             
            listaRozkazow.Add(r);

            refresh();
            Clear();
        }

        private void wykonajKolejke_Click(object sender, EventArgs e)
        {

            foreach (Rozkaz r in listaRozkazow)
            {
                operacja = r.operacja;

                rejDocelowy = r.arg1;
                if (Int16.TryParse(r.arg2.ToString(), out short i))
                {
                    rejestrowe = false;
                    arg = i;

                }
                else
                {
                    rejZrodlowy = (Rejestr)r.arg2;
                    rejestrowe = true;
                }


                commit_Click(sender, e);
            }

            listaRozkazow.Clear();
            refresh();

        }

        private void krokowa_Click(object sender, EventArgs e)
        {
            if (listaRozkazow.Count > 0)
            {
                Rozkaz r = listaRozkazow[indeks];

                operacja = r.operacja;

                rejDocelowy = r.arg1;
                if (Int16.TryParse(r.arg2.ToString(), out short i))
                {
                    rejestrowe = false;
                    arg = i;

                }
                else
                {
                    rejZrodlowy = (Rejestr)r.arg2;
                    rejestrowe = true;
                }


                commit_Click(sender, e);


                listaRozkazow.RemoveAt(indeks);
                indeks--;
                refresh();
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
                Clear();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            using (Stream fs = new FileStream(Environment.ExpandEnvironmentVariables("%AppData%\\listaRozkazów.xml"),
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Rozkaz>));
                serializer.Serialize(fs, listaRozkazow);
            }
            label6.Text = "Zapisano";
            timer1.Start();
        }

        private void buttonOtworz_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Rozkaz>));

            using (FileStream fs = File.OpenRead(Environment.ExpandEnvironmentVariables("%AppData%\\listaRozkazów.xml")))
            {
                listaRozkazow = (List<Rozkaz>)serializer.Deserialize(fs);
            }
            refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = "";
            timer1.Stop();
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            if (SP >= 0)
            {
                stos[SP] = rejDocelowy.getValue();
                SP--;
                Clear();
                refresh();
            }
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            if (SP < stos.Length)
            {
                SP++;
                rejDocelowy.setValue(stos[SP]);
                
                Clear();
                refresh();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte a, b;
            if(Byte.TryParse(AHBox.Text,out a))
            {
                A.NH = a;
            }
            if (Byte.TryParse(ALBox.Text, out b))
            {
                A.NL = b;
            }
            refresh();
        }

        private void buttonPrzerwanie_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        przerwanie10h();

                    }break;
                case 1:
                    {
                        przerwanie15h();
                    }
                    break;
                case 2:
                    {
                        przerwanie16h();
                    }
                    break;
                case 3:
                    {
                        przerwanie1Ah();
                    }
                    break;
                case 4:
                    {
                        Console.Beep();
                    }
                    break;

            }
        }

        public void przerwanie10h()
        {
            switch (A.NH)
            {
                case 3:
                    {
                        B.setValue(Int16.Parse((Cursor.Position.X).ToString()));
                        C.setValue(Int16.Parse((Cursor.Position.Y).ToString()));
                    }
                    break;
                case 10:
                    {
                        ComputerInfo computerInfo = new ComputerInfo();

                        B.setValue(Convert.ToInt32(computerInfo.TotalPhysicalMemory / 1000000));
                        C.setValue(Convert.ToInt32(computerInfo.AvailablePhysicalMemory / 1000000));
                    }
                    break;
                
            }

            refresh();
        }

        public void przerwanie15h()
        {
            switch (A.NH)
            {
                case 5:
                    {
                       
                        C.setValue(Screen.PrimaryScreen.Bounds.Width );
                        D.setValue( Screen.PrimaryScreen.Bounds.Height);
                    }
                    break;
                case 22:
                    {
                        B.setValue(Int32.Parse(DateTime.Now.Hour.ToString()));

                    }
                    break;

            }

            refresh();
        }

        public void przerwanie16h()
        {
            switch (A.NH)
            {
                case 61:
                    {

                        B.setValue(A.NL);
                    }
                    break;
                case 24:
                    {
                        Keyboard keyboard = new Keyboard();
                        if (keyboard.CapsLock)
                            B.setValue(1);
                        else
                            B.setValue(2);

                    }
                    break;

            }

            refresh();
        }

        public void przerwanie1Ah()
        {
            switch (A.NH)
            {
                case 0:
                    {

                        B.setValue((int)DateTime.Now.Ticks);
                    }
                    break;
                case 6:
                    {
                        B.setValue(A.NL);
                        timer2.Start();


                    }
                    break;

            }

            refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (B.getValue() > 0)
            {
                B.setValue(B.getValue() - 1);
            }
            else
            {
                timer2.Stop();
                Console.Beep();
            }
            refresh();
        }
    }
}
