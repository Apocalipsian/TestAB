using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkazjeInfo
{
    public class Methods
    {

        public IWebDriver getUrl(string url,IWebDriver driver)
        {
            if (driver == null)
                driver = new PhantomJSDriver();

            driver.Url = url;
             driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(100));

            //  wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            driver.Manage().Window.Maximize();
            return driver;
        }

        public  List<string> getUrlOfBox(RichTextBox box)
        {
            List<string> listBox = new List<string>();
            box.Text = Regex.Replace(box.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            listBox.AddRange((string[])box.Lines);
            try
            {
                if (listBox[listBox.Count - 1] == "" && listBox.Count() !=0)
                    listBox.RemoveAt(listBox.Count - 1);
            }
            catch { }
            return listBox;
        }

        public  void openFile(RichTextBox textBox)
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

        public static void saveFile(RichTextBox textBox)
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

    }
}
