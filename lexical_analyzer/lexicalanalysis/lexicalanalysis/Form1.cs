using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace lexicalanalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //OpenFileDialog ofd = new OpenFileDialog();

        List<string> it = new List<string>();
        int id = 0;
        string s = string.Empty;
        public void display() {


            if (s == "cout")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            
            else if (s.Contains("."))
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Header");
                id++;
                s = string.Empty;

            }
            else if (s=="if")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "else")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "return")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "using".Trim())
            {
                s.Skip(' ');
                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s.Trim() == "namespace")
            {
                s.Skip(' ');
                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "std")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "printf")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "scanf")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "int")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "float")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "double")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "char")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            
            else if (s == "cin")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "iostream")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "cstring")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "main")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "include")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s is Int64)
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Number");
                id++;
                s = string.Empty;

            }
            else if (s == "for")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "while")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "do")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else if (s == "string")
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Keyword");
                id++;
                s = string.Empty;

            }
            else
            {

                it.Add(id.ToString() + "\t" + s.ToString() + "\t" + "Identifier");
                id++;
                s = string.Empty;

            }

        
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           
           if (ofd.ShowDialog() == DialogResult.OK)
          {

              StreamReader sr = new StreamReader(ofd.FileName);
             richTextBox1.Text= sr.ReadToEnd();
            
          }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            string scanner = richTextBox1.Text;
            char[] ar = scanner.ToCharArray();
            //int id = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i].ToString());

            }
            for (int i = 0; i < ar.Length; i++)
            {

                if (ar[i] == '#')
                {
                    if (s != string.Empty)
                    {

                        display();
                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special symbol");
                    id++;
                    


                }
                else if (ar[i] == ')')
                {
                    if (s != string.Empty)
                    {

                        display();

                    }

                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special symbol");
                    id++;
                    

                }
                else if (ar[i] == '(')
                {
                    if (s != string.Empty)
                    {

                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special symbol");
                    id++;
                   


                }
                else if (ar[i] == '{')
                {
                    if (s != string.Empty)
                    {

                        display();
                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special symbol");
                    id++;
                    


                }
                else if (ar[i] == '}')
                {
                    if (s != string.Empty)
                    {

                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special symbol");
                    id++;
                    


                }
                else if (ar[i] == '>')
                {
                    if (s != string.Empty)
                    {

                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Greater than");
                    id++;
                    


                }
                else if (ar[i] == '<')
                {
                    if (s != string.Empty)
                    {

                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Less than");
                    id++;
                    


                }
                else if (ar[i] == '=')
                {
                    if (s != string.Empty)
                    {

                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Equal");
                    id++;
                   


                }
                else if (ar[i] == ';')
                {
                    if (s != string.Empty)
                    {


                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special Symbol");
                    id++;
                    


                }
                else if (ar[i] == '+')
                {
                    if (s != string.Empty)
                    {


                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Operator");
                    id++;



                }
                else if (ar[i] == '-')
                {
                    if (s != string.Empty)
                    {


                        display();
                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Operator");
                    id++;



                }
                else if (ar[i] == '*')
                {
                    if (s != string.Empty)
                    {


                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Operator");
                    id++;



                }
                else if (ar[i] == '/')
                {
                    if (s != string.Empty)
                    {


                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Operator");
                    id++;



                }
                else if (ar[i] == '[')
                {
                    if (s != string.Empty)
                    {


                        display();

                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special Symbol");
                    id++;



                }
                else if (ar[i] == ']')
                {
                    if (s != string.Empty)
                    {


                        display();
                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special Symbol");
                    id++;



                }
                else if (ar[i] == ',')
                {
                    if (s != string.Empty)
                    {


                        display();
                    }
                    it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Special Symbol");
                    id++;
                }

                else if (ar[i] == ' ')
                {
                    s.Skip('\n');
                    if (s != string.Empty)
                    {

                        s.Skip(ar[i]);
                        display();

                    }
                    //it.Add(id.ToString() + "\t" + ar[i].ToString() + "\t" + "Space");
                    //id++;



                }
                else if (ar[i] == '\n')
                {


                    s = string.Empty;

                }

                else
                {
                    s.Skip('\n');
                    s = string.Concat(s, ar[i].ToString());




                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = "";
            foreach (string d in it)
            {

                
                s += d + Environment.NewLine;
            
            }
            richTextBox2.Text = s;
            
        }
            
      
        
    }
}
