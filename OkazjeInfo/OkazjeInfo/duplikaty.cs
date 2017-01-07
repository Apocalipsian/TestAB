using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkazjeInfo
{
    public partial class duplikaty : Form
    {

        static IWebDriver driver;
        static public List<string> productIdList = new List<string>();
        static public List<string> cookieList = new List<string>();
        Methods metody = new Methods();

        public List<string> getDuplicateProduct(List<string> listProductId)
        {
            listProductId = driver.FindElements(By.XPath(
                   @"//div[@id='listingPage']//div[contains(@class,'rightCol')]/div[contains(@class,'squaresListing')]
                    /div[contains(@class, 'squaresContent narrow')]/div[contains(@class, 'productItem')]//a[contains(@class,'productItemContent')]")).Select(w => w.GetAttribute("data_product_id")).ToList();

            var duplicate = listProductId.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();
            return duplicate;

        }

        public duplikaty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listBox = new List<string>();
            //richTextBox2.Clear();

            richTextBox2.Clear();

            richTextBox1.Text = Regex.Replace(richTextBox1.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);

            listBox.AddRange((string[])richTextBox1.Lines);

            if (listBox[listBox.Count - 1] == "")
                listBox.RemoveAt(listBox.Count - 1);

            if (checkCookie.Checked)
            {
                cookieRichBox.Text = Regex.Replace(cookieRichBox.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
                cookieList.AddRange((string[])cookieRichBox.Lines);

                if (cookieList[cookieList.Count - 1] == "")
                    cookieList.RemoveAt(cookieList.Count - 1);
            }



            foreach (var url in listBox)
            {


                if (checkCookie.Checked)
                {
                    if (driver == null)
                        driver = new FirefoxDriver();
                    driver.Url = url;

                    for (int j = 0; j < cookieList.Count; j++)
                    {

                        List<string> duplicate = new List<string>();
                        Cookie cookie = new Cookie("OIATM", cookieList[j]);
                        do
                        {
                            driver.Manage().Cookies.DeleteCookieNamed("OIATM");
                            driver.Manage().Cookies.AddCookie(cookie);
                            driver.Navigate().Refresh();
                            //   var t = driver.Manage().Cookies.GetCookieNamed("OIATM").Value;


                        } while (driver.Manage().Cookies.GetCookieNamed("OIATM").Value != cookieList[j]);

                        duplicate = getDuplicateProduct(duplicate);

                        richTextBox2.Text += Environment.NewLine + url + " Wersja : " + (j + 1) + "   Ilosc duplikatów : " + duplicate.Count();
                    }

                    try
                    {
                        driver.Quit();
                    }
                    catch (Exception)
                    {
                        driver = null;

                    }
                }
                else
                {
                    if (driver == null)
                        driver = new PhantomJSDriver();

                    driver.Url = url;
                    List<string> duplicate = new List<string>();
                    duplicate = getDuplicateProduct(duplicate);

                    richTextBox2.Text += Environment.NewLine + url + "   Ilosc duplikatów : " + duplicate.Count();
                }
            }

            listBox = new List<string>();
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {


            }

            driver = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            metody.openFile(richTextBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            metody.saveFile(richTextBox1);
        }
    }
}
