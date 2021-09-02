using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 今天吃啥
{

    public partial class Form1 : Form
    {


        String getDataPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openData_Click(object sender, EventArgs e)
        {   
            
            OpenFileDialog dataPath = new OpenFileDialog();
            dataPath.Title = "選擇資料來源";
            dataPath.Filter = "TXT文字文件 | *.txt";
            dataPath.ShowDialog();

            getDataPath = dataPath.FileName;

            dataFrom.Text = "目前資料來源為 : " + getDataPath; //顯示到dataFrom
            openData.Text = "更改資料來源";
        }

        private void dataFrom_Click(object sender, EventArgs e)
        {

        }

        private void priceFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (priceFilter.Checked)
            {
                priceIn.Enabled = true;
                priceIn.Text = "0";
                SecondRestaurant.Text = "價錢篩選將只推薦一間";
                ThirdRestaurant.Text = "價錢篩選將只推薦一間";
            }
            else
            {
                priceIn.Enabled = false;
                priceIn.Text = "";
                SecondRestaurant.Text = "尚無結果";
                ThirdRestaurant.Text = "尚無結果";
            }
        }


        private void runIt_Click(object sender, EventArgs e)
        {
            if (getDataPath == null)
            {
                getDataPath = @"data.txt";
            }


            if (File.Exists(@getDataPath) == true)
            {

                if (priceFilter.Checked == false)
                {
                    RestaurantNameAndPrice nameAndPrice = new RestaurantNameAndPrice();
                    String[] nameAndPrice_ = nameAndPrice.GetName(getDataPath);
                    Console.WriteLine(nameAndPrice_[0] + nameAndPrice_[1]);
                    FirstRestaurant.Text = nameAndPrice_[0];

                    do
                    {
                        nameAndPrice_ = nameAndPrice.GetName(getDataPath);
                        Console.WriteLine(nameAndPrice_[0] + nameAndPrice_[1]);
                        SecondRestaurant.Text = nameAndPrice_[0];
                    } while (SecondRestaurant.Text == FirstRestaurant.Text);

                    do
                    {
                        nameAndPrice_ = nameAndPrice.GetName(getDataPath);
                        Console.WriteLine(nameAndPrice_[0] + nameAndPrice_[1]);
                        ThirdRestaurant.Text = nameAndPrice_[0];
                    } while (ThirdRestaurant.Text == FirstRestaurant.Text || ThirdRestaurant.Text == SecondRestaurant.Text);
                }

                else
                {

                    RestaurantNameAndPrice nameAndPrice = new RestaurantNameAndPrice();
                    int restaurantPrice;
                    int priceSet = Convert.ToInt32(priceIn.Text);



                    do
                    {
                        String[] nameAndPrice_ = nameAndPrice.GetName(getDataPath);
                        Console.WriteLine(nameAndPrice_[0] + nameAndPrice_[1]);
                        restaurantPrice = Convert.ToInt32(nameAndPrice_[1]);
                            FirstRestaurant.Text = nameAndPrice_[0];

                    } while (restaurantPrice > priceSet);
                }

            }
            else 
            {
                MessageBox.Show("請選擇資料清單或者確認本程式目錄下是否有data.txt檔案","哎呀 出現錯誤了!",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }


        }
    }
}

