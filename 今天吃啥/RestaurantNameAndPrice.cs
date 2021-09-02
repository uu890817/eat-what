using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace 今天吃啥
{

    /// <summary>
    /// 轉換餐廳名稱及價位
    /// </summary>
    public class RestaurantNameAndPrice
    {
        public String[] GetName(String getDataPath)
        {

           
            StreamReader data = new StreamReader(getDataPath);
            String lineRead = data.ReadToEnd();
            String[] lineToList = lineRead.Split('\n');
            int lineCount = lineToList.Count();
            Random randomRestaurantName = new Random();
            int randomRestaurantNumber = randomRestaurantName.Next(0, lineCount);
            Console.WriteLine(randomRestaurantNumber);
            String restaurantNameAndPrice = lineToList[randomRestaurantNumber];
            String[] returnNameAndPrice = restaurantNameAndPrice.Split(' ');
            
            return returnNameAndPrice;
        }


            
        }


    }
