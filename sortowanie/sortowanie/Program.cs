using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new PhantomJSDriver();

            while (true)
            {
                string url = Console.ReadLine();
                driver.Url = url;
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));

                var t = driver.FindElements(By.XPath("//*[@id='listingPage']/div/div/div/div/a/div/div/span[1]")).Select(w => w.Text).ToList();
                List<double> tmp = new List<double>();

                for (int i = 0; i < t.Count(); i++)
                {
                    t[i] = t[i].Replace("zł", "");
                    t[i] = t[i].Replace("od", "").Replace(" ", "");
                    tmp.Add(Convert.ToDouble(t[i]));
                }

                t.Clear();



                if (driver.Url.Contains("cena_desc"))
                {
                    var tmp2 = tmp.OrderByDescending(w => w).ToList();

                    for (int i = 0; i < tmp.Count; i++)
                    {
                        if (tmp[i] != tmp2[i])
                        {
                            Console.WriteLine("NOK");
                            break;
                        }

                       
                    }
                    tmp2.Clear();
                    tmp.Clear();
                }
                else
                {
                    var tmp2 = tmp.OrderBy(w => w).ToList();

                    for (int i = 0; i < tmp.Count; i++)
                    {
                        if (tmp[i] != tmp2[i])
                        {
                            Console.WriteLine("NOK");
                            break;
                        }

                        if (i == tmp.Count - 1 && tmp[i] == tmp2[i])
                            Console.WriteLine("OK");
                    }
                    tmp2.Clear();
                    tmp.Clear();
                }

                
            }
            driver.Quit();
        }
    }
}
