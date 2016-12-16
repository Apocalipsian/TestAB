using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
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
    public partial class testAB : Form
    {
        public testAB()
        {
            InitializeComponent();
        }

        public static bool check = false;
        public static IWebDriver driver;

        public static bool checkView()
        {
            Cookie cookie = driver.Manage().Cookies.GetCookieNamed("OIATM");
            if (cookie.Value.Last().ToString() == "0")
                return false;
            else
                return true;

        }

        public static string getTestId()
        {
            var dataLayer = driver.FindElements(By.XPath("/html/head/script")).Select(w => w.GetAttribute("innerHTML")).Where(wa => wa.Contains("dataLayer"));
            string testID = "";

            int p1 = dataLayer.FirstOrDefault().IndexOf("testId = '") + "testId = '".Length;
            int p2 = dataLayer.FirstOrDefault().LastIndexOf("';\r\n");

            if (p1 > 0 && p2 > 0)
                testID = dataLayer.FirstOrDefault().Substring(p1, p2 - p1);

            return testID;
        }

        public static bool checkEvent()
        {

            var dataLayer = driver.FindElements(By.XPath("/html/head/script")).Select(w => w.GetAttribute("innerHTML")).Where(wa => wa.Contains("dataLayer"));

            bool testEvent = dataLayer.FirstOrDefault().Contains(@"_gaq.push(['_setCustomVar', 1, 'TestAB', testId");

            return testEvent;
        }

        public static void getUrl(string url)
        {
            if (driver == null)
                driver = new FirefoxDriver();

            driver.Url = url;
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
        }
        //l
        public static List<string> getUrlOfBox(RichTextBox box)
        {
            List<string> listBox = new List<string>();
            box.Text = Regex.Replace(box.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            listBox.AddRange((string[])box.Lines);
            try
            {
                if (listBox[listBox.Count - 1] == "")
                    listBox.RemoveAt(listBox.Count - 1);
            }
            catch { }
            return listBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (testOnBox.Lines.Count() != 0 && testOffBox.Lines.Count() != 0 && cookieBox.Lines.Count() != 0)
            {


                List<string> urls = new List<string>();
                List<string> urlsOff = new List<string>();
                int index = 0;
                url = null;

                var cookieList = getUrlOfBox(cookieBox);

                for (int j = 0; j <= cookieList.Count - 1; j++)
                {

                    check = false;

                    #region wszystkie strony poddane testowi
                    if (testOnBox.Lines.Count() > 0)
                        urls = getUrlOfBox(testOnBox);

                    if (urls.Count > 0)
                    {

                        foreach (var item in urls)
                        {

                            getUrl(item);

                            if (cookieList.Count > 0 && check == false)
                            {
                                check = true;
                                dataGridView1.Rows.Add("Strony poddane testowi/ Wersja : " + cookieList[j]);
                                dataGridView1.Rows[index].Cells[0].Style.BackColor = Color.Blue;

                                index++;
                                Cookie cookie = new Cookie("OIATM", cookieList[j]);

                                do
                                {
                                    driver.Manage().Cookies.DeleteCookieNamed("OIATM");
                                    driver.Manage().Cookies.AddCookie(cookie);
                                    //driver.Navigate().Refresh();
                                    driver.Url = item;
                                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));

                                } while (driver.Manage().Cookies.GetCookieNamed("OIATM").Value != cookieList[j]);
                            }
                            else if (cookieList.Count == 0 && check == false)
                            {
                                dataGridView1.Rows.Add("Strony poddane testowi");
                                dataGridView1.Rows[index].Cells[0].Style.BackColor = Color.Blue;

                                index++;
                            }
                            bool eventTest = checkEvent();
                            string testId = getTestId();
                            bool checkViewPage = checkView();

                            dataGridView1.Rows.Add(item, eventTest.ToString(), testId, checkViewPage);


                            if (eventTest == false)
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Green;

                            if (testId == "")
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;

                            if (checkViewPage == false)
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;

                            index++;
                        }
                        try
                        {
                            driver.Quit();
                            driver = null;
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Serio?\nMoże byś jednak podał urle");
                    }

                    #endregion

                    #region strony nie poddane testowi

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows.Add("Strony nie poddane testowi");
                    index += 2;

                    if (testOffBox.Lines.Count() > 0)
                        urlsOff = getUrlOfBox(testOffBox);

                    if (urlsOff.Count > 0)
                    {
                        foreach (var item in urlsOff)
                        {

                            getUrl(item);

                            bool eventTest = checkEvent();
                            string testId = getTestId();
                            bool checkViewPage = checkView();

                            dataGridView1.Rows.Add(item, eventTest.ToString(), testId, checkViewPage);


                            if (eventTest == true)
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Green;

                            if (testId != "")
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;

                            if (checkViewPage == true)
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;

                            index++;
                        }

                        driver.Quit();
                        driver = null;
                    }
                    else
                    {
                        MessageBox.Show("Serio?\nMoże byś jednak podał urle");
                    }


                    #endregion

                    #region mix

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows.Add("MIX");
                    index += 2;
                    Random rand = new Random();

                    int numberOff = urlsOff.Count;
                    int numberOn = urls.Count;

                    if (urlsOff.Count > 0 && urls.Count > 0)
                    {

                        for (int i = 1; i < 7; i++)
                        {
                            int jj = rand.Next(0, urls.Count);
                            getUrl(urls[jj]);

                            bool eventTest = checkEvent();
                            string testId = getTestId();
                            bool checkViewPage = checkView();

                            dataGridView1.Rows.Add(urls[jj], eventTest.ToString(), testId, checkViewPage);


                            if (eventTest == false)
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Green;

                            if (testId == "")
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;

                            if (checkViewPage == false)
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;

                            index++;


                            int k = rand.Next(0, urlsOff.Count);
                            getUrl(urlsOff[k]);

                            bool eventTest2 = checkEvent();
                            string testId2 = getTestId();
                            bool checkViewPage2 = checkView();

                            dataGridView1.Rows.Add(urlsOff[k], eventTest2.ToString(), testId2, checkViewPage2);


                            if (eventTest2 == true)
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Green;

                            if (testId2 != "")
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;

                            if (checkViewPage2 == false)
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;

                            index++;

                        }

                        try
                        {
                            driver.Quit();
                            driver = null;
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Serio?\nMoże byś jednak podał urle");
                    }


                    #endregion

                    #region mix2

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows.Add("MIX2");
                    index += 2;


                    if (urlsOff.Count > 0 && urls.Count > 0)
                    {

                        for (int i = 1; i < 7; i++)
                        {

                            int k = rand.Next(0, urlsOff.Count);
                            getUrl(urlsOff[k]);

                            bool eventTest2 = checkEvent();
                            string testId2 = getTestId();
                            bool checkViewPage2 = checkView();

                            dataGridView1.Rows.Add(urlsOff[k], eventTest2.ToString(), testId2, checkViewPage2);



                            if (eventTest2 == true)
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Green;

                            if (testId2 != "")
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;

                            if (i == 1)
                            {
                                if (checkViewPage2 == true)
                                    dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                                else
                                    dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;
                            }
                            else
                            {
                                if (checkViewPage2 == false)
                                    dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                                else
                                    dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;
                            }
                            index++;

                            int jj = rand.Next(0, urls.Count);
                            getUrl(urls[jj]);

                            bool eventTest = checkEvent();
                            string testId = getTestId();
                            bool checkViewPage = checkView();

                            dataGridView1.Rows.Add(urls[jj], eventTest.ToString(), testId, checkViewPage);


                            if (eventTest == false)
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[1].Style.BackColor = Color.Green;

                            if (testId == "")
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[2].Style.BackColor = Color.Green;

                            if (checkViewPage == false)
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red;
                            else
                                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;






                            index++;

                        }

                        try
                        {
                            driver.Quit();
                            driver = null;
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Serio?\nMoże byś jednak podał urle");
                    }


                    #endregion
                }
            }
            else
                MessageBox.Show("Serio ? Nie uzupełniłeś wszsytkich danych !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text|*.txt";
            openFile.Title = "Otwórz urle";
            openFile.ShowDialog();

            try
            {
                testOnBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Zapisz urle";
            saveFileDialog1.ShowDialog();
            try
            {
                testOnBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text|*.txt";
            openFile.Title = "Otwórz urle";
            openFile.ShowDialog();

            try
            {
                testOffBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Zapisz urle";
            saveFileDialog1.ShowDialog();
            try
            {
                testOffBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            }
            catch (Exception)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text|*.txt";
            openFile.Title = "Otwórz urle";
            openFile.ShowDialog();

            try
            {
                cookieBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Zapisz urle";
            saveFileDialog1.ShowDialog();
            try
            {
                cookieBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            }
            catch (Exception)
            {

            }
        }


    }
}
