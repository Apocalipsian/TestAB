using Npgsql;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkazjeInfo
{
    public class Methods
    {
        static NpgsqlConnection conn;
        static Random rand = new Random();


        public IWebDriver getUrl(string url, IWebDriver driver)
        {
            if (driver == null)
                driver = new PhantomJSDriver();

            driver.Url = url;

            //*[@id="offersIndicator"]

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            // var t = driver.FindElement(By.XPath("//*[@id='offersIndicator']"));



            //  wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            driver.Manage().Window.Maximize();
            return driver;
        }

        public List<string> getUrlOfBox(RichTextBox box)
        {
            List<string> listBox = new List<string>();
            box.Text = Regex.Replace(box.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            listBox.AddRange((string[])box.Lines);
            try
            {
                if (listBox[listBox.Count - 1] == "" && listBox.Count() != 0)
                    listBox.RemoveAt(listBox.Count - 1);
            }
            catch { }
            return listBox;
        }

        public void openFile(RichTextBox textBox)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text|*.txt";
            openFile.Title = "Otwórz urle";
            openFile.ShowDialog();

            try
            {
                textBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {

            }
        }

        public void saveFile(RichTextBox textBox)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Zapisz urle";
            saveFileDialog1.ShowDialog();
            try
            {
                textBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            }
            catch (Exception)
            {

            }
        }

        public RichTextBox conncetDatabase(string query, string baza, RichTextBox box, string trunk)
        {
            box.Clear();

//            conn = new NpgsqlConnection(baza);
            List<string> rekordy = new List<string>();
  //          conn.Open();

            box.Clear();
            try
            {
                conn = new NpgsqlConnection(baza);
    //            List<string> rekordy = new List<string>();
                conn.Open();
            }
            catch (System.Net.Sockets.SocketException e)
            {
                MessageBox.Show("Nie moszna polaczyc sie z baza");
                return box;
            }

            NpgsqlCommand cmd2 = new NpgsqlCommand(query, conn);
            try
            {
                using (NpgsqlDataReader dr2 = cmd2.ExecuteReader())
                {
                    while (dr2.Read())
                    {
                        if (trunk != "")
                            rekordy.Add(dr2[0].ToString().Replace("www.", "").Replace("okazje.info.pl", trunk));
                        else
                            rekordy.Add(dr2[0].ToString());

                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
            conn.Dispose();

            for (int i = 0; i < rekordy.Count; i++)
            {
                box.Text += rekordy[i] + "\n";
            }

            return box;
        }


        ////// FILTRY ! 

        public List<filtry.unactiveFilters> getUnactiveFilters(IWebDriver driver, string type)
        {
            filtry.unactiveFilters newFilter;
            List<filtry.unactiveFilters> lists = new List<filtry.unactiveFilters>();
            switch (type)
            {
                
                case "fs":
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
                                                                        and not(contains(@class, 'price'))]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'param') and not(contains(@class, 'active'))]"));



                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }


                            return lists;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "price":
               

                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'price')]//div/div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                            var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'price')]//div//div[contains(@class,'check') and contains(.//@name, 'param') and not(contains(@class, 'active'))]"));



                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }

                            return lists;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "shop":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'shop')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp[i];

                                lists.Add(newFilter);
                            }

                            return lists;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "showonly":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'showOnly')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                            var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'showOnly')]/div[contains(@class, 'param')]//div[contains(@class,'check') and not(contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }

                            return lists;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów promocji.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "producer":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'producer')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));
                            var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'producer')]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'param') and not(contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }

                            return lists;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }
                case "city":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'city')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and not(contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp[i];

                                lists.Add(newFilter);
                            }

                            return lists;


                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                default:
                    return null;

            }


        }
        public List<filtry.unactiveFilters> getAcitveFilters(IWebDriver driver, string type)
        {

            filtry.unactiveFilters newFilter;
            List<filtry.unactiveFilters> lists = new List<filtry.unactiveFilters>();
            switch (type)
            {

                case "fs":
                    {
                        try
                        {
                            // do kliknięcia
                            var tmp = driver.FindElements(By.XPath(@"//div[@class='filterSet']//div[contains(@class, 'box') and not (contains(@class, 'box color')) and not(contains(@class, 'showOnly')) 
                                                                        and not(contains(@class, 'fs')) and not(contains(@class, 'producer'))and not(contains(@class, 'shop')) 
                                                                        and not(contains(@class, 'shop'))and not(contains(@class, 'city'))and not(contains(@class, 'price'))]
                                                                        /div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and (contains(@class, 'active'))]"));
                            // do zaznaczenia
                            var tmp2 = driver.FindElements(By.XPath(@"//div[@class='filterSet']//div[contains(@class, 'box') and not(contains(@class,'box color')) and not(contains(@class, 'showOnly')) 
                                                                        and not(contains(@class, 'fs')) and not(contains(@class, 'producer'))and not(contains(@class, 'shop')) and not(contains(@class, 'shop'))and not(contains(@class, 'city'))
                                                                        and not(contains(@class, 'price'))]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'param') and (contains(@class, 'active'))]"));



                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }


                            return lists;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "price":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'price')]//div/div[@class='val']/label/a[not(@href='#') and (contains(@class, 'active'))]"));
                            var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'price')]//div//div[contains(@class,'check') and contains(.//@name, 'param') and (contains(@class, 'active'))]"));



                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }

                            return lists;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "shop":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'shop')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and (contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp[i];

                                lists.Add(newFilter);
                            }

                            return lists;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "showonly":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'showOnly')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and (contains(@class, 'active'))]"));
                            var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'showOnly')]/div[contains(@class, 'param')]//div[contains(@class,'check')]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }

                            return lists;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów promocji.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                case "producer":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'producer')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and (contains(@class, 'active'))]"));
                            var tmp2 = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'producer')]/div[contains(@class, 'param')]//div[contains(@class,'check') and contains(.//@name, 'param') and (contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp2[i];

                                lists.Add(newFilter);
                            }

                            return lists;

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }
                case "city":
                    {
                        try
                        {
                            var tmp = driver.FindElements(By.XPath(@"//div[contains(@class, 'box') and contains(@class, 'city')]/div[contains(@class, 'param')]//div[@class='val']/label/a[not(@href='#') and (contains(@class, 'active'))]"));


                            for (int i = 0; i < tmp.Count; i++)
                            {
                                newFilter = new filtry.unactiveFilters();
                                newFilter.textFilter = tmp[i];
                                newFilter.checkFilter = tmp[i];

                                lists.Add(newFilter);
                            }

                            return lists;


                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Nie mogłem pobrać filtrów FS.\nBłąd : {0}", e.Message);
                            return null;
                        }
                    }

                default:
                    return null;

            }
        }


        public string click(IWebDriver driver, List<filtry.unactiveFilters> lists, int number)
        {
            string filterName;

            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

            if (number >= 0)
            {
                filterName = lists[number].textFilter.Text;
                lists[number].textFilter.Click();
                return filterName;
            }
            else
            {
                number = rand.Next(0, lists.Count-1);

                filterName = lists[number].textFilter.Text;

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", lists[number].textFilter);
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
                try
                {
                    lists[number].textFilter.Click();
                    wait.Until(ExpectedConditions.StalenessOf(lists[number].textFilter));
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
                }
                catch
                {
                    MessageBox.Show("Nie udało się kliknąć filtru");
                }
                return filterName;
            }
        }

        public string check(IWebDriver driver, List<filtry.unactiveFilters> lists, int number)
        {
            string filterName = "";

            if (number >= 0)
            {
                filterName = lists[number].textFilter.Text;
                lists[number].checkFilter.Click();
                return filterName;
            }
            else if (lists.Count>0)
            {
                number = rand.Next(0, lists.Count-1);

                filterName = lists[number].textFilter.Text;

                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", lists[number].textFilter);
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
                try
                {
                    lists[number].checkFilter.Click();
                }
                catch
                {
                    MessageBox.Show("Nie udało się zaznaczyć filtru");
                }
                return filterName;
            }
            return filterName;
        }

        public void clickMore(IWebDriver driver)
        {
            var moreButton = driver.FindElements(By.XPath(@"//*[@id='listingPage']/div[contains(@class, 'leftCol')]/div[contains(@class, 'filterSet')]
                                            / div[contains(@class, 'box')]/div[contains(@class, 'paramS')]/div[contains(@class, 'paramH')]"));

            if (moreButton.Count > 0 && moreButton.FirstOrDefault().Text == "więcej >")
            {
                foreach (var item in moreButton)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", item);

                    item.Click();
                }
            }
        }


        public void compareFilters(List<string> checkFilters, IWebDriver driver)
        {
            string message = "";
            List<string> resultFilters = new List<string>();

            resultFilters = driver.FindElements(By.XPath("//*[@id='yi']/div[contains(@class,'filterDeselect')]/h2/span/label")).Select(w => w.Text).ToList();

            if (resultFilters.Count() != checkFilters.Count())
            {
                try
                {
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

                    message = driver.FindElement(By.XPath("//*[@id='removedFiltersBox']")).Text;
                }
                catch { }

                if (message != "")
                    MessageBox.Show("Poprawnie zdjeło filtry");
            }
            MessageBox.Show("Ilość zaznaczonych : " + checkFilters.Count + "\nIlosć z pola 'Wybrane' : " + resultFilters.Count, "Dlaczego owca beczy ?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1,
                (MessageBoxOptions)0x40000);
        }


        public void clickCheck(IWebDriver driver)
        {
            var clickCheck = driver.FindElement(By.XPath("//*[@id='selectChosenFilters']/div/div"));
            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", clickCheck);

            try
            {
                clickCheck.Click();
                wait.Until(ExpectedConditions.StalenessOf(clickCheck));
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie mogłem kliknąć w 'Wybierz zaznaczone'\nKod błędu :" + e.Message);

            }
        }



        public void clickResult(IWebDriver driver)
        {
            var clickCheck = driver.FindElements(By.XPath("//*[@id='yi']/div/h2"));

            int number = rand.Next(0, clickCheck.Count - 1);

            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", clickCheck[number]);

            try
            {
                clickCheck[number].Click();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie mogłem kliknąć w 'Wybierz zaznaczone'\nKod błędu :" + e.Message);

            }
        }




    }
}
