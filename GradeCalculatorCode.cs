﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Created By OctaneGames or Matthew Henriques. on 1/31/2020 or 2/01/2020

namespace GradeCalculatorApp
{
    public partial class GC : Form
    {
        public static int totalpercentage = 0;
        public static int weight1 = 0;
        public static int weight2 = 0;
        public static int weight3 = 0;
        public static int weight4 = 0;
        public static int percent1 = 0;
        public static int percent2 = 0;
        public static int percent3 = 0;
        public static int percent4 = 0;
        public static string text1 = "";
        public static string text2 = "";
        public static string text3 = "";
        public static string text4 = "";
        public static string text5 = "";
        public static string text6 = "";
        public static string text7 = "";
        public static string text8 = "";
        


        public GC()
        {

            Console.WriteLine("Starting Application");
            

            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //For right now this only works if all 4 are filled in



            //making vars and setting them to zero
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;

            int ttotal1 = 0;
            int ttotal2 = 0;
            int ttotal3 = 0;
           

            int weight11 = 0;
            int weight22 = 0;


            int realtotal = 0;

            



            //getting text strings
            text1 = textBox1.Text;
            text2 = textBox2.Text;
            text3 = textBox3.Text;
            text4 = textBox4.Text;
            text5 = textBox5.Text;
            text6 = textBox6.Text;
            text7 = textBox7.Text;
            text8 = textBox8.Text;

            //making bools that check if the person put any text in the text fields
            bool bol1 = string.IsNullOrEmpty(text1);
            bool bol2 = string.IsNullOrEmpty(text2); 
            bool bol3 = string.IsNullOrEmpty(text3);
            bool bol4 = string.IsNullOrEmpty(text4); 
            bool bol5 = string.IsNullOrEmpty(text5); 
            bool bol6 = string.IsNullOrEmpty(text6); 
            bool bol7 = string.IsNullOrEmpty(text7); 
            bool bol8 = string.IsNullOrEmpty(text8);

            bool boll1 = false;
            bool boll2 = false;
            bool boll3 = false;
            bool boll4 = false;

            if (bol1 != true && bol2 != true)
            {
                percent1 = Int32.Parse(text1);
                weight1 = Int32.Parse(text2);
                boll1 = true;
                Console.WriteLine("working");
                
            } 


            if(bol3 != true && bol4 != true)
            {

                percent2 = Int32.Parse(text3);
                weight2 = Int32.Parse(text4);
                boll2 = true;
               

            }
            if(bol5 != true && bol6 != true)
            {
                percent3 = Int32.Parse(text5);
                weight3 = Int32.Parse(text6);
                boll3 = true;
               
                
            }
            if (bol7 != true && bol8 != true)
            {
                percent4 = Int32.Parse(text7);
                percent4 = Int32.Parse(text7);
                boll4 = true;
                
                
            }

            if(boll1 == true && boll2 == false && boll3 == false & boll4 == false)
            {
                total1 = weight1 * percent1;
                ttotal1 = total1;
                weight11 = weight1;
                weight22 = ttotal1 / weight11;
                realtotal = weight22;
                string output = realtotal + " " + "percent";
                Output.Text = output;
                Output.Enabled = true;

            }
            if(boll1 == true && boll2 == true && boll3 == false & boll4 == false)
            {
                total1 = weight1 * percent1;
                total2 = weight2 * percent2;
                ttotal1 = total1 + total2;
                weight11 = weight1 + weight2;
                weight22 = ttotal1 / weight11;
                realtotal = weight22;
                string output = realtotal + " " + "percent";
                Output.Text = output;
                Output.Enabled = true;
            }
            if(boll1 == true && boll2 == true && boll3 == true & boll4 == false)
            {
                total1 = weight1 * percent1;
                total2 = weight2 * percent2;
                total3 = weight3 * percent3;

                ttotal1 = total1 + total2 + total3;
                weight11 = weight1 + weight2 + weight3;
                weight22 = ttotal1 / weight11;
                realtotal = weight22;
                string output = realtotal + " " + "percent";
                Output.Text = output;
                Output.Enabled = true;
            }


            if (boll1 == true && boll2 == true && boll3 == true & boll4 == true)
            {
                //multipying weight and percent
                total1 = weight1 * percent1;
                total2 = weight2 * percent2;
                total3 = weight3 * percent3;
                total4 = weight4 * percent4;

                //adding up all the first,second,third,forth totals of multiplying weight and percent
                ttotal1 = total1 + total2;
                ttotal2 = total3 + total4;
                ttotal3 = ttotal1 + ttotal2;


                //adding up all the weights together
                weight11 = weight1 + weight2 + weight3 + weight4;

                //diving up the total of weight * percent added together and the number of weight added together
                weight22 = ttotal3 / weight11;

                realtotal = weight22;

                string output = realtotal + " " + "percent";

                Output.Text = output;

                Output.Enabled = true;




                Console.WriteLine(realtotal + "" + "percent");
            } else {
                Console.WriteLine("Please fill in the stuff");
                        }


        }

       
    }
}
