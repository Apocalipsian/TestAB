using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkazjeInfo
{
    public partial class filtry : Form
    {

        List<string> ft = new List<string>();
        Methods metody = new Methods();
        List<string> filtersCheck = new List<string>();
        List<unactiveFilters> filterList = new List<unactiveFilters>();
        IWebDriver driver = null;
        string message = "";

        public List<unactiveFilters> getUnactiveFilters(IWebDriver driver)
        {
            unactiveFilters newFilter;
            List<unactiveFilters> lists = new List<unactiveFilters>();
            if (techBox.Checked == true)
            {



                try
                {
                    // do kliknięcia
                    var tmp = driver.FindElements(By.XPath(@"//div[@class='filterSet']//div[contains(@class, 'box') and not (contains(@class, 'box color')) and not(contains(@class, 'showOnly')) 
                                                                        and not(contains(@class, 'fs')) and not(contains(@class, 'producer'))and not(contains(@class, 'shop')) 
                                                                        and not(contains(@class, 'shop'))and not(contains(@class, 'city'))and not(contains(@class, 'price'))]
                                                                        /div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                    // do zaznaczenia
                    var tmp2 = driver.FindElements(By.XPath(@"//div[@class='filterSet']//div[contains(@class, 'box') and not(contains(@class,'box color')) and not(contains(@class, 'showOnly')) 
                                                                        and not(contains(@class, 'fs')) and not(contains(@class, 'producer'))and not(contains(@class, 'shop')) and not(contains(@class, 'shop'))and not(contains(@class, 'city'))
                                                                        and not(contains(@class, 'price'))]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'param') and not (.//@checked)]"));



                    for (int i = 0; i < tmp.Count; i++)
                    {
                        newFilter = new unactiveFilters();
                        newFilter.textFilter = tmp[i];
                        newFilter.checkFilter = tmp2[i];

                        lists.Add(newFilter);
                    }



                }
                catch 
                {
                 //   MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);

                }
            }

            if (priceBox.Checked)

            {
                try
                {
                    var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'price')]//div/div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                    var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'price')]//div//div[contains(@class,'check') and contains(.//@name, 'param') and not (.//@checked)]"));



                    for (int i = 0; i < tmp.Count; i++)
                    {
                        newFilter = new unactiveFilters();
                        newFilter.textFilter = tmp[i];
                        newFilter.checkFilter = tmp2[i];

                        lists.Add(newFilter);
                    }


                }
                catch 
                {
                   // MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);

                }
            }

            if (shopBox.Checked)
            {
                try
                {
                    var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'shop')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));


                    for (int i = 0; i < tmp.Count; i++)
                    {
                        newFilter = new unactiveFilters();
                        newFilter.textFilter = tmp[i];
                        newFilter.checkFilter = tmp[i];

                        lists.Add(newFilter);
                    }



                }
                catch 
                {
                   // MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);

                }
            }

            if (showOnlyBox.Checked)
            {
                try
                {
                    var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'showOnly')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                    var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'showOnly')]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'promotion') and not (.//@checked)]"));


                    for (int i = 0; i < tmp.Count; i++)
                    {
                        newFilter = new unactiveFilters();
                        newFilter.textFilter = tmp[i];
                        newFilter.checkFilter = tmp2[i];

                        lists.Add(newFilter);
                    }



                }
                catch 
                {
                   // MessageBox.Show("Nie mogłem pobrać filtrów promocji.\nBłąd : {0}", e.Message);

                }
            }

            if (producentBox.Checked)
            {
                try
                {
                    var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'producer')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                    var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'producer')]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'param') and not (.//@checked)]"));


                    for (int i = 0; i < tmp.Count; i++)
                    {
                        newFilter = new unactiveFilters();
                        newFilter.textFilter = tmp[i];
                        newFilter.checkFilter = tmp2[i];

                        lists.Add(newFilter);
                    }


                }
                catch 
                {
                   // MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);

                }
            }

            if (cityBox.Checked)
            {
                try
                {
                    var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'city')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));


                    for (int i = 0; i < tmp.Count; i++)
                    {
                        newFilter = new unactiveFilters();
                        newFilter.textFilter = tmp[i];
                        newFilter.checkFilter = tmp[i];

                        lists.Add(newFilter);
                    }



                }
                catch 
                {
                  //  MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);

                }
            }

            return lists;
        }




        public void scenarios (string type, int count)
        {

            #region SCENARIUSZ : KLIK
            if (type == "KLIK")
            {
               
                    IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

                    for (int i = 0; i < count; i++)
                    {
                        filterList = null;


                        metody.clickMore(driver);

                        filterList = getUnactiveFilters(driver);

                        filtersCheck.Add(metody.click(driver, filterList, -1));

                        metody.compareFilters(filtersCheck, driver);
                    }

                   // driver.Quit();
                     filtersCheck.Clear();
                
            }
            #endregion

            #region SCENARIUSZ KLIK w "ZAZANCZONE"
            if (type =="KLIK W 'WYBIERZ ZAZNACZONE'")
            {

                metody.clickCheck(driver);
            }
            #endregion

            #region SCENARIUSZ : ZAZNACZ
            if (type == "ZAZNACZ")
            {
                    IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

                    for (int i = 0; i < count; i++)
                    {

                        metody.clickMore(driver);

                        filterList = getUnactiveFilters(driver);

                        filtersCheck.Add(metody.check(driver, filterList, -1));
                        Thread.Sleep(100);
                    }

                    filtersCheck.Clear();
                    filterList.Clear();
                
            }
            #endregion

            if(type == "COFNIJ")
            {
                for (int i = 0; i < count; i++)
                {
                    IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));
                 //   var clickCheck = driver.FindElement(By.XPath("//*[@id='selectChosenFilters']/div/div"));

                    driver.Navigate().Back();
                    //   wait.Until(ExpectedConditions.StalenessOf(clickCheck));
                    Thread.Sleep(1000);
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

                }
            }

        }


        public class unactiveFilters
        {
            public IWebElement textFilter { get; set; }
            public IWebElement checkFilter { get; set; }
        }

        public filtry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            List<string> urlLists = metody.getUrlOfBox(richTextBox1);


            if (combo1.SelectedItem != null && combo1.SelectedItem.ToString() != "" && urlLists.Count != 0)
            {

                driver = new FirefoxDriver();
                driver.Url = urlLists[0];

                scenarios(combo1.SelectedItem.ToString(), Convert.ToInt16(Count_1.Value));

                if (combo2.SelectedItem != null && combo2.SelectedItem.ToString() != "")
                    scenarios(combo2.SelectedItem.ToString(), Convert.ToInt16(Count_2.Value));

                if (combo3.SelectedItem != null && combo3.SelectedItem.ToString() != "")
                    scenarios(combo3.SelectedItem.ToString(), Convert.ToInt16(Count_3.Value));

                if (combo4.SelectedItem != null && combo4.SelectedItem.ToString() != "")
                    scenarios(combo4.SelectedItem.ToString(), Convert.ToInt16(Count_4.Value));

                if (combo5.SelectedItem != null && combo5.SelectedItem.ToString() != "")
                    scenarios(combo5.SelectedItem.ToString(), Convert.ToInt16(Count_5.Value));

                driver.Quit();
            }



            /*
            #region SCENARIUSZ : ZAZNACZ + KLIK
            if (checkBox.Checked == true && clickBox.Checked)
            {
                foreach (var url in urlLists)
                {
                    driver = new FirefoxDriver();
                    driver.Url = url;
                    IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

                    for (int i = 0; i < countInter.Value; i++)
                    {

                        metody.clickMore(driver);

                        filterList = getUnactiveFilters(driver);

                        filtersCheck.Add(metody.check(driver, filterList, -1));

                    }
                    filtersCheck.Add(metody.click(driver, filterList, -1));
                    metody.compareFilters(filtersCheck, driver);

                    driver.Quit();
                    filtersCheck.Clear();
                    filterList.Clear();
                }
            }
            #endregion
    */
        }

        private void allFiltersBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allFiltersBox.Checked)
            {
                techBox.Checked = true;
                priceBox.Checked = true;
                shopBox.Checked = true;
                cityBox.Checked = true;
                producentBox.Checked = true;
                showOnlyBox.Checked = true;
            }

            if (allFiltersBox.Checked== false)
            {
                techBox.Checked = !true;
                priceBox.Checked = !true;
                shopBox.Checked = !true;
                cityBox.Checked = !true;
                producentBox.Checked = !true;
                showOnlyBox.Checked = !true;
            }


        }


        #region boxy 
        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo1.SelectedIndex > -1)
            {
                combo2.Visible = true;
                label1.Visible = true;
                Count_2.Visible = true;
            }
        }

        private void combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo2.SelectedIndex > -1)
            {
                combo3.Visible = true;
                label3.Visible = true;
                Count_3.Visible = true;
            }
        }


      

        private void combo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo3.SelectedIndex > -1)
            {
                combo4.Visible = true;
                label4.Visible = true;
                Count_4.Visible = true;
            }
        }




      

        private void combo4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo4.SelectedIndex > -1)
            {
                combo5.Visible = true;
                label5.Visible = true;
                Count_5.Visible = true;
            }
        }

        private void combo5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo5.SelectedIndex > -1)
            {
                combo6.Visible = true;
                label7.Visible = true;
                Count_6.Visible = true;
            }
        }

        private void combo6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo6.SelectedIndex > -1)
            {
                combo7.Visible = true;
                label8.Visible = true;
                Count_7.Visible = true;
            }
        }

        #endregion
    }
}
