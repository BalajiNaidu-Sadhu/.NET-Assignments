using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        int xMin = -209;
        int xMax = 209;
        int yMin = -209;
        int yMax = 209;
        int xInterval = 20; int yInterval = 20;
        static bool isxpresent, isypresent;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        const int EM_SETCUEBANNER = 0x1501;
        
        
        //Colors
        Color circle = Color.HotPink;
        Color le = Color.Red;
        Color CE = Color.Green;
        Color QE = Color.Blue;
        public Form1()
        {
            InitializeComponent();
            btnCSCE.BackColor = CE;
            btnCSCircle.BackColor = circle;
            btnCSQE.BackColor = QE;
            btnCSLE.BackColor = le;
            ToolTip LETip = new ToolTip();
            LETip.ShowAlways= true;
            LETip.SetToolTip(LEtooltip, "This is Linear equation where m is the slope and c is the Y intercept.");

            ToolTip QETip = new ToolTip();
            LETip.ShowAlways = true;
            LETip.SetToolTip(QEtoolTip, "This is Quadratic equation where a,b,c are coefficients.");

            ToolTip CETip = new ToolTip();
            LETip.ShowAlways = true;
            LETip.SetToolTip(CEtoolTip, "This is Cubic equation where a,b,c,d are coefficients.");

            ToolTip CirTip = new ToolTip();
            LETip.ShowAlways = true;
            LETip.SetToolTip(CirtoolTip, "This is Circle equation where (h,k) is the centre and 'r' is the radius.");



            SendMessage(txtYmax.Handle, EM_SETCUEBANNER, 1, "+/-200");
            SendMessage(txtYmin.Handle, EM_SETCUEBANNER, 1, "+/-200");
            SendMessage(txtXmax.Handle, EM_SETCUEBANNER, 1, "+/-200");
            SendMessage(txtXmin.Handle, EM_SETCUEBANNER, 1, "+/-200");
            SendMessage(txtCirr.Handle, EM_SETCUEBANNER, 1, "+/-100");
            SendMessage(txtCirk.Handle, EM_SETCUEBANNER, 1, "+/-100");
            SendMessage(txtCirh.Handle, EM_SETCUEBANNER, 1, "+/-100");
            SendMessage(txtCEa.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtCEd.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtCEc.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtCEb.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtQEc.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtQEb.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtQEa.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtLEc.Handle, EM_SETCUEBANNER, 1, "+/-5");
            SendMessage(txtLEm.Handle, EM_SETCUEBANNER, 1, "+/-5");
        }
        private void validateInputs()
        {
            
            isxpresent = false;
            isypresent = false;
            if (txtXmin.Text != "" || txtXmax.Text != "")
            {
                isxpresent = true;
            }
           

            if (txtYmin.Text != "" || txtYmax.Text != "")
            {
                isypresent = true;
            }
            
            if (txtXmin.Text != "" && txtXmax.Text != "")
            {
                if (Math.Abs(Convert.ToInt32(txtXmax.Text)) < Math.Abs(Convert.ToInt32(txtXmin.Text)))
                {
                    txtErrorBox.Text = "Xmax should be greater than Xmin";
                }
            }
             if (txtYmin.Text != "" && txtYmax.Text != "")
            {
                if (Math.Abs(Convert.ToInt32(txtYmin.Text)) > Math.Abs(Convert.ToInt32(txtYmax.Text)))
                {
                    txtErrorBox.Text = "Ymax should be greater than Ymin";
                }
            }

        }


        private void btnResult_Click(object sender, EventArgs e)
        {


            picGraph.Refresh();
            txtErrorBox.Clear();
            validateInputs();
            isChecked_makeGraph();
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = txtLEm.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                Button _sender = (Button)sender;
                _sender.BackColor = MyDialog.Color;
                switch (_sender.Name)
                {
                    case "btnCSLE": le = MyDialog.Color; break;
                    case "btnCSQE": QE = MyDialog.Color; break;
                    case "btnCSCE": CE = MyDialog.Color; break;
                    case "btnCSCircle": circle = MyDialog.Color; break;
                    default: break;
                }
            }
        }

        private void isChecked_makeGraph()
        {
            if (chkLE.Checked)
            {
                if (txtLEm.Text == "" || txtLEc.Text == "")
                {
                    txtErrorBox.Text = "Please enter both m and c values.";

                }
                else
                {
                    MakeGraph(isxpresent, isypresent, 1);
                }
            }
            if (chkQE.Checked)
            {
                if (txtQEa.Text == "" || txtQEb.Text == "" || txtQEc.Text == "")
                {
                    txtErrorBox.Text = "Please enter all coefficients a,b,c";

                }
                else
                {
                    MakeGraph(isxpresent, isypresent, 2);
                }
            }
            if (chkCE.Checked)
            {
                if (txtCEa.Text == "" || txtCEb.Text == "" || txtCEc.Text == "" || txtCEd.Text == "")
                {
                    txtErrorBox.Text = "Please enter all coefficients a,b,c,d";

                }
                else
                {
                    MakeGraph(isxpresent, isypresent, 3);
                }
            }
            if (chkCirE.Checked)
            {
                if (txtCirr.Text == "" || txtCirh.Text == "" || txtCirk.Text == "")
                {
                    txtErrorBox.Text = "Please enter centre(h,k) and radius r values";

                }
                else
                {
                    MakeGraph(isxpresent, isypresent, 4);
                }
            }
            if (!chkCirE.Checked && !chkCE.Checked && !chkLE.Checked && !chkQE.Checked)
            {
                txtErrorBox.Text = "Please check atleast one checkbox to display graph";
            }
        }
        private void MakeGraph(bool isxpresent, bool isypresent,int option)
        {
            int wid = picGraph.ClientSize.Width;
            int hgt = picGraph.ClientSize.Height;
            

            Graphics gr = picGraph.CreateGraphics();

            
           
            // Draw the graph.
            using (Pen graph_pen = new Pen(Color.Black, 0))
            {
                // Draw the axes.
                if (!isxpresent && !isypresent)
                {
                    
                        gr.TranslateTransform(wid / 2, hgt / 2);
                        gr.DrawLine(graph_pen, xMin, 0, xMax, 0);
                        gr.DrawLine(graph_pen, 0, -yMin, 0, -yMax);
                        for (int x = (int)xMin; x <= xMax; x = x + xInterval)
                        {
                            gr.DrawLine(graph_pen, x, -0.9f, x, 0.9f);
                        }

                        for (int y = (int)yMin; y <= yMax; y = y + yInterval)
                        {
                            gr.DrawLine(graph_pen, -0.9f, y, 0.9f, y);
                        }

                    SolidBrush brush = new SolidBrush(Color.Black);
                    Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                    PointF p1 = new PointF();
                    p1.X = (wid / 2) - 30;
                    p1.Y = -30;
                    gr.DrawString("X", font, brush, p1);
                    PointF p2 = new PointF();
                    p2.X = 30;
                    p2.Y = -(hgt / 2) + 30;
                    gr.DrawString("Y", font, brush, p2);
                }
                if (isxpresent && isypresent)
                {
                    if (txtXmin.Text != "" && txtXmax.Text != "" && txtYmin.Text != "" && txtYmax.Text != "")
                    {
                        if (((Convert.ToInt32(txtXmin.Text) <= 0) && (Convert.ToInt32(txtYmin.Text) <= 0))
                           && ((Convert.ToInt32(txtXmax.Text) > 0) && (Convert.ToInt32(txtYmax.Text) > 0)))
                        {

                            gr.TranslateTransform(wid / 2, hgt / 2);
                            gr.DrawLine(graph_pen, xMin, 0, xMax, 0);
                            gr.DrawLine(graph_pen, 0, -yMin, 0, -yMax);
                            for (int x = (int)xMin; x <= xMax; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, x, -0.9f, x, 0.9f);
                            }

                            for (int y = (int)yMin; y <= yMax; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -0.9f, y, 0.9f, y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = (wid/2) - 30;
                            p1.Y = -30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = 30;
                            p2.Y = -(hgt/2) + 30;
                            gr.DrawString("Y", font, brush, p2);

                        }
                    }
                    else if (txtXmin.Text != "" && txtXmax.Text == "" && txtYmin.Text != "" && txtYmax.Text == "")
                    {

                        if ((Convert.ToInt32(txtXmin.Text) > 0) && (Convert.ToInt32(txtYmin.Text) > 0))
                        {
                            gr.TranslateTransform(0, hgt);
                            for (int x = 0; x <= xMax * 2; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, x, -2f, x, 2f);
                            }
                            for (int y = 0; y <= yMax * 2; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -2f, -y, 2f, -y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = wid - 30;
                            p1.Y = -30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = 30;
                            p2.Y = -hgt + 30;
                            gr.DrawString("Y", font, brush, p2);
                        }
                    }

                    else if (txtXmin.Text == "" && txtXmax.Text != "" && txtYmin.Text != "" && txtYmax.Text == "")
                    {
                        if ((Convert.ToInt32(txtXmax.Text) < 0) && (Convert.ToInt32(txtYmin.Text) > 0))
                        {
                            gr.TranslateTransform(wid, hgt);
                            for (int x = 0; x <= xMax * 2; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, -x, -2f, -x, 2f);
                            }
                            for (int y = 0; y <= yMax * 2; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -2f, -y, 2f, -y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = -wid + 30;
                            p1.Y = -30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = -30;
                            p2.Y = -hgt + 30;
                            gr.DrawString("Y", font, brush, p2);
                        }
                    }
                    else if (txtXmin.Text == "" && txtXmax.Text != "" && txtYmin.Text == "" && txtYmax.Text != "")
                    {
                        if ((Convert.ToInt32(txtXmax.Text) < 0) && (Convert.ToInt32(txtYmax.Text) < 0))
                        {
                            gr.TranslateTransform(wid, 0);
                            for (int x = 0; x <= xMax * 2; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, -x, -2f, -x, 2f);
                            }
                            for (int y = 0; y <= yMax * 2; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -2f,y, 2f, y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = -wid +30;
                            p1.Y = 30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = -30;
                            p2.Y = hgt - 30;
                            gr.DrawString("Y", font, brush, p2);
                        }
                    }
                    else if (txtXmin.Text != "" && txtXmax.Text == "" && txtYmin.Text == "" && txtYmax.Text != "")
                    {
                        if ((Convert.ToInt32(txtXmin.Text) > 0) && (Convert.ToInt32(txtYmax.Text) < 0))
                        {
                            gr.TranslateTransform(0, 0);
                            for (int x = 0; x <= xMax * 2; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, x, -2f, x, 2f);
                            }
                            for (int y = 0; y <= yMax * 2; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -2f, y, 2f, y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = wid - 30;
                            p1.Y = 30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = 10;
                            p2.Y = hgt - 30;
                            gr.DrawString("Y", font, brush, p2);
                        }
                    }
                }
                else if (isxpresent&&!isypresent)
                { if (txtXmin.Text != "")
                    {
                        if (Convert.ToInt32(txtXmin.Text) > 0)
                        {
                            gr.TranslateTransform(0, hgt / 2);
                            gr.DrawLine(graph_pen, 0, 0, wid, 0);
                            for (int x = 0; x <= wid; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, x, -0.9f, x, 0.9f);
                            }
                            for (int y = -hgt / 2; y <= hgt / 2; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, 0.9f, y, -0.9f, y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = wid - 30;
                            p1.Y = -30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = 30;
                            p2.Y = (hgt / 2) - 30;
                            gr.DrawString("Y", font, brush, p2);
                        }
                    }
                     if (txtXmax.Text!="")
                    {
                        if (Convert.ToInt32(txtXmax.Text) < 0)
                        {
                            gr.TranslateTransform(wid, hgt / 2);
                            gr.DrawLine(graph_pen, 0, 0, -wid, 0);
                            for (int x = 0; x <= wid; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, -x, -0.9f, -x, 0.9f);
                            }
                            for (int y = -hgt / 2; y <= hgt / 2; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, 2f, y, -2f, y);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = -wid+10;
                            p1.Y = -30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = -30;
                            p2.Y = -(hgt/2)+30;
                            gr.DrawString("Y", font, brush, p2);

                        }

                    }

                }
                else if (isypresent && !isxpresent)
                {
                    if (txtYmin.Text != "")
                    {
                        if (Convert.ToInt32(txtYmin.Text) > 0)
                        {
                            gr.TranslateTransform(wid / 2, hgt);
                            gr.DrawLine(graph_pen, 0, 0, 0, -hgt);
                            for (int y = 0; y <= hgt; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -2f, -y, 2f, -y);
                            }
                            for (int x = xMin; x <= xMax; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, x, 3f, x, -3f);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = (wid/2) - 30;
                            p1.Y = -30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = 10;
                            p2.Y = -hgt + 30;
                            gr.DrawString("Y", font, brush, p2);
                        }
                    }
                    if (txtYmax.Text != "")
                    {
                        if (Convert.ToInt32(txtYmax.Text) < 0)
                        {
                            gr.TranslateTransform(wid / 2, 0);
                            gr.DrawLine(graph_pen, 0, 0, 0, hgt);
                            for (int y = 0; y <= hgt; y = y + yInterval)
                            {
                                gr.DrawLine(graph_pen, -2f, y, 2f, y);
                            }
                            for (int x = xMin; x <= xMax; x = x + xInterval)
                            {
                                gr.DrawLine(graph_pen, x, 3f, x, -3f);
                            }
                            SolidBrush brush = new SolidBrush(Color.Black);
                            Font font = new Font("LucidaConsole", 12, FontStyle.Bold);
                            PointF p1 = new PointF();
                            p1.X = (wid/2)-30;
                            p1.Y = 30;
                            gr.DrawString("X", font, brush, p1);
                            PointF p2 = new PointF();
                            p2.X = 10;
                            p2.Y = hgt - 30;
                            gr.DrawString("Y", font, brush, p2);
                        }

                    }

                }
            }
            switch(option)
            {
                case 1: MakeLine(gr,hgt, wid, xMin, xMax, xInterval); break;
                case 2: MakeQuadraticEquation(gr,hgt, wid, xMin, xMax, xInterval); break;
                case 3: MakeCubicEquation(gr,hgt, wid, xMin, xMax, xInterval); break;
                case 4: MakeCircle(gr,hgt, wid); break;
            }
          
        }       
            
        

         private void MakeLine(Graphics gr,int hgt,int wid,int xmin,int xmax,int xinterval)
        {
            Pen graph_pen = new Pen(le, 0);
            //Graphics gr = picGraph.CreateGraphics();

            // Loop over x values to generate points.
            List<PointF> points = new List<PointF>();
            // for (float x = xmin; x <= xmax; x += xinterval)
            for (float x = xMin; x <= xMax; x += xinterval)
            {

                    try
                    {
                        // Get the next point.
                       
                        float y = (Convert.ToInt32(txtLEm.Text) * x) + Convert.ToInt32(txtLEc.Text);


                       // if (y >= (-hgt / 2) && y <= (hgt / 2))
                        //{
                            points.Add(new PointF(x, -y));
                        //}
                        //else if (points.Count <= 1)
                        //{
                        //    txtErrorBox.Text = "Out of scope for Linear Equation";
                        //}
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }

                if (points.Count > 1)
                    // gr.DrawLines(graph_pen, points.ToArray());
                    gr.DrawLines(graph_pen, points.ToArray());
                points.Clear();
            }
        private void MakeQuadraticEquation(Graphics gr,int hgt, int wid, int xmin, int xmax, int xinterval)
        {
            Pen graph_pen = new Pen(QE, 0);

           // gr.TranslateTransform(wid / 2, hgt / 2);
            List<PointF> points = new List<PointF>();
            for (float x = xMin; x <= xMax; x += xinterval)
            {

                try
                {
                    // Get the next point.

                     float y = (Convert.ToInt32(txtQEa.Text) * (x*x)) + (Convert.ToInt32(txtQEb.Text)*x)+ 
                     Convert.ToInt32(txtQEc.Text);


                    //if (y >= (-hgt / 2) && y <= (hgt / 2))
                    //{
                        points.Add(new PointF(x, -y));
                    //}
                    //else if (points.Count <= 1)
                    //{
                    //    txtErrorBox.Text = "Out of scope";
                    //}
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

            if (points.Count > 1)
                gr.DrawCurve(graph_pen, points.ToArray());
            points.Clear();

        }
        private void MakeCubicEquation(Graphics gr,int hgt, int wid, int xmin, int xmax, int xinterval)
        {
            Pen graph_pen = new Pen(CE, 0);
            //Graphics gr = picGraph.CreateGraphics();

           // gr.TranslateTransform(wid / 2, hgt / 2);
            List<PointF> points = new List<PointF>();
            for (float x = xMin; x <= xMax; x += xinterval)
            {

                try
                {
                    // Get the next point.
                     float y = (Convert.ToInt32(txtCEa.Text) * (x * x*x))+(Convert.ToInt32(txtCEb.Text) * (x * x))
                         + (Convert.ToInt32(txtCEc.Text) * x) +
                       Convert.ToInt32(txtCEd.Text);
                    
                    
                        points.Add(new PointF(x, -(y / 10000)));
                  
                    
                }
                catch
                {
                    MessageBox.Show("Error in Input fields.");
                }
            }

            if (points.Count > 1)
                gr.DrawCurve(graph_pen, points.ToArray());
            points.Clear();

        }
        private void MakeCircle(Graphics gr,int hgt, int wid)
        {
            Pen graph_pen = new Pen(circle, 0);

            gr.DrawEllipse(graph_pen, (Convert.ToInt32(txtCirh.Text)- Convert.ToInt32(txtCirr.Text)),
                (Convert.ToInt32(txtCirk.Text) - Convert.ToInt32(txtCirr.Text)), (Convert.ToInt32(txtCirr.Text)*2),
                (Convert.ToInt32(txtCirr.Text)*2));
        }
    }
}
