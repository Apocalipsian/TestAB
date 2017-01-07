using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkazjeInfo
{
    public partial class sortowanie : Form
    {
        Methods methods = new Methods();
        IWebDriver driver;

        public sortowanie()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            List<string> sortUrls = methods.getUrlOfBox(urlBox);
            List<double> priceList = new List<double>();
            List<string> prices = new List<string>();
            bool exceptionthrown = false;
            dataGridView1.Rows.Clear();


            foreach (var url in sortUrls)
            {
                driver = methods.getUrl(url, driver);
                
                
              //  int webCount = Convert.ToInt16(driver.FindElement(By.XPath("//div[@id='listingPageArea']/div[@id='listingPage']/div[@class='rightCol overflowH']/div[@class='yu']/div/a")).Text);



                if (driver.Url.Contains("#sort,cena_desc") == false && driver.Url.Contains("#sort,cena") == false)
                {
                    driver.Url = driver.Url.Replace("#sort,shopcount", "").Replace("#sort,review", "");
                    driver.Url += "#sort,cena_desc";
                    if (driver.Url.Contains("okazje.info.pl"))
                        driver.Navigate().Refresh();
                    else
                        driver.Url = driver.Url;

                    do
                    {
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));

                        try
                        {
                            driver.FindElement(By.XPath("//*[@id='offersIndicator']"));
                        }
                        catch
                        {
                            exceptionthrown = true;
                        }

                    } while (!exceptionthrown);

                    exceptionthrown = false;
                }

                for (int k = 0; k < 2; k++)
                {

                    do
                    {
                        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));

                        try
                        {
                            driver.FindElement(By.XPath("//*[@id='offersIndicator']"));
                        }
                        catch
                        {
                            exceptionthrown = true;
                        }

                    } while (!exceptionthrown);

                    exceptionthrown = false;

                    while (!exceptionthrown)
                    {
                        try
                        {
                            prices.Clear();
                            prices = driver.FindElements(By.XPath("//*[@id='listingPage']/div/div/div/div/a/div/div/span[1]")).Select(w => w.Text).ToList();
                            exceptionthrown = true;
                        }
                        catch (Exception)
                        { }
                    }

                    exceptionthrown = false;
                    priceList.Clear();
                    for (int i = 0; i < prices.Count(); i++)
                    {
                        prices[i] = prices[i].Replace("zł", "").Replace("od", "").Replace(" ", "");
                        priceList.Add(Convert.ToDouble(prices[i]));
                    }

                    if (driver.Url.Contains("#sort,cena_desc"))
                    {

                        List<double> tmp = priceList.OrderByDescending(w => w).ToList();

                        for (int i = 0; i < tmp.Count; i++)
                        {
                            if (priceList[i] != tmp[i])
                            {
                                dataGridView1.Rows.Add(driver.Url, false);
                                break;
                            }

                            if (i == tmp.Count - 1 && tmp[i] == priceList[i])
                                dataGridView1.Rows.Add(driver.Url, true);
                        }
                        if (k < 2)
                        {
                            driver.Url = driver.Url.Replace("#sort,cena_desc", "#sort,cena");
                            if (driver.Url.Contains("okazje.info.pl"))
                                driver.Navigate().Refresh();
                            else
                                driver.Url = driver.Url;


                            do
                            {
                                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));

                                try
                                {
                                    driver.FindElement(By.XPath("//*[@id='offersIndicator']"));
                                }
                                catch
                                {
                                    exceptionthrown = true;
                                }

                            } while (!exceptionthrown);

                            exceptionthrown = false;

                        }
                    }
                    else
                    {

                        List<double> tmp = priceList.OrderBy(w => w).ToList();

                        for (int i = 0; i < tmp.Count; i++)
                        {
                            if (priceList[i] != tmp[i])
                            {
                                dataGridView1.Rows.Add(driver.Url, false);
                                break;
                            }

                            if (i == tmp.Count - 1 && tmp[i] == priceList[i])
                                dataGridView1.Rows.Add(driver.Url, true);
                        }

                        if (k < 2)
                        {
                            driver.Url = driver.Url.Replace("#sort,cena", "#sort,cena_desc");
                            if (driver.Url.Contains("okazje.info.pl"))
                                driver.Navigate().Refresh();
                            else
                            {
                                driver.Url = driver.Url;
                               
                            }

                            do
                            {
                                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));

                                try
                                {
                                    driver.FindElement(By.XPath("//*[@id='offersIndicator']"));
                                }
                                catch
                                {
                                    exceptionthrown = true;
                                }

                            } while (!exceptionthrown);

                            exceptionthrown = false;
                        }
                    }



                    priceList.Clear();
                    prices.Clear();
                }
            }

            sortUrls.Clear();
            driver.Quit();
            driver = null;
        }
    }
}
