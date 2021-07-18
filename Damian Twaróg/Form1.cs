using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damian_Twaróg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AX2_TextChanged(object sender, EventArgs e)
        {
            AX1.Text = AX2.Text;
            AX2.MaxLength = 4;
        }

        private void BX2_TextChanged(object sender, EventArgs e)
        {
            BX1.Text = BX2.Text;
            BX2.MaxLength = 4;
        }

        private void CX2_TextChanged(object sender, EventArgs e)
        {
            CX1.Text = CX2.Text;
            CX2.MaxLength = 4;
        }

        private void DX2_TextChanged(object sender, EventArgs e)
        {
            DX1.Text = DX2.Text;
            DX2.MaxLength = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AX1.Text = "0000";
            BX1.Text = "0000";
            CX1.Text = "0000";
            DX1.Text = "0000";
            AX2.Text = "0000";
            BX2.Text = "0000";
            CX2.Text = "0000";
            DX2.Text = "0000";
        }
        public static void XCHG(ref string x, ref string y)
        {
            string tmp = x;
            x = y;
            y = tmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var random = new Random();
            string AX = "";
            string BX = "";
            string CX = "";
            string DX = "";
            for (int i = 0; i < 4; i++)
            {
                int A = random.Next(0, 16);
                AX += A.ToString("X");
            }
            for (int i = 0; i < 4; i++)
            {
                int B = random.Next(0, 16);
                BX += B.ToString("X");
            }
            for (int i = 0; i < 4; i++)
            {
                int C = random.Next(0, 16);
                CX += C.ToString("X");
            }
            for (int i = 0; i < 4; i++)
            {
                int D = random.Next(0, 16);
                DX += D.ToString("X");
            }


            AX1.Text = AX;
            AX2.Text = AX;
            BX1.Text = BX;
            BX2.Text = BX;
            CX1.Text = CX;
            CX2.Text = CX;
            DX1.Text = DX;
            DX2.Text = DX;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AXR1.Checked)
            {

                if (BXR2.Checked)
                {
                    BX1.Text = AX1.Text;
                }
                else if (CXR2.Checked)
                {
                    CX1.Text = AX1.Text;
                }
                else if (DXR2.Checked)
                {
                    DX1.Text = AX1.Text;
                }
            }
            if (BXR1.Checked)
            {
                if (AXR2.Checked)
                {
                    AX1.Text = BX1.Text;
                }

                else if (CXR2.Checked)
                {
                    CX1.Text = BX1.Text;
                }
                else if (DXR2.Checked)
                {
                    DX1.Text = BX1.Text;
                }
            }
            if (CXR1.Checked)
            {
                if (AXR2.Checked)
                {
                    AX1.Text = CX1.Text;
                }
                else if (BXR2.Checked)
                {
                    BX1.Text = CX1.Text;
                }

                else if (DXR2.Checked)
                {
                    DX1.Text = CX1.Text;
                }
            }
            if (DXR1.Checked)
            {
                if (AXR2.Checked)
                {
                    AX1.Text = DX1.Text;
                }
                else if (BXR2.Checked)
                {
                    BX1.Text = DX1.Text;
                }

                else if (CXR2.Checked)
                {
                    CX1.Text = DX1.Text;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (AXR1.Checked)
            {
                if (BXR2.Checked)
                {
                    string x = AX1.Text;
                    string y = BX1.Text;

                    XCHG(ref x, ref y);

                    AX1.Text = x;
                    BX1.Text = y;
                }
                else if (CXR2.Checked)
                {
                    string x = AX1.Text;
                    string y = CX1.Text;

                    XCHG(ref x, ref y);

                    AX1.Text = x;
                    CX1.Text = y;
                }
                else if (DXR2.Checked)
                {
                    string x = AX1.Text;
                    string y = DX1.Text;

                    XCHG(ref x, ref y);

                    AX1.Text = x;
                    DX1.Text = y;
                }
            }
            if (BXR1.Checked)
            {
                if (AXR2.Checked)
                {
                    string x = BX1.Text;
                    string y = AX1.Text;

                    XCHG(ref x, ref y);

                    BX1.Text = x;
                    AX1.Text = y;
                }

                else if (CXR2.Checked)
                {
                    string x = BX1.Text;
                    string y = CX1.Text;

                    XCHG(ref x, ref y);

                    BX1.Text = x;
                    CX1.Text = y;
                }
                else if (DXR2.Checked)
                {
                    string x = BX1.Text;
                    string y = DX1.Text;

                    XCHG(ref x, ref y);

                    BX1.Text = x;
                    DX1.Text = y;
                }
            }
            if (CXR1.Checked)
            {
                if (AXR2.Checked)
                {
                    string x = CX1.Text;
                    string y = AX1.Text;

                    XCHG(ref x, ref y);

                    CX1.Text = x;
                    AX1.Text = y;
                }
                else if (BXR2.Checked)
                {
                    string x = CX1.Text;
                    string y = BX1.Text;

                    XCHG(ref x, ref y);

                    CX1.Text = x;
                    BX1.Text = y;
                }

                else if (DXR2.Checked)
                {
                    string x = CX1.Text;
                    string y = DX1.Text;

                    XCHG(ref x, ref y);

                    CX1.Text = x;
                    DX1.Text = y;
                }
            }
            if (DXR1.Checked)
            {
                if (AXR2.Checked)
                {
                    string x = DX1.Text;
                    string y = AX1.Text;

                    XCHG(ref x, ref y);

                    DX1.Text = x;
                    AX1.Text = y;
                }
                else if (BXR2.Checked)
                {
                    string x = DX1.Text;
                    string y = BX1.Text;

                    XCHG(ref x, ref y);

                    DX1.Text = x;
                    BX1.Text = y;
                }

                else if (CXR2.Checked)
                {
                    string x = DX1.Text;
                    string y = CX1.Text;

                    XCHG(ref x, ref y);

                    DX1.Text = x;
                    CX1.Text = y;
                }
            }

        }
    }
}
    

    
    


