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
    public partial class urls : Form
    {
        static string devel = String.Format("Server=devel-db;Port=5444;User Id=automatyzacja;Password=Michal_jest_krulem_wszystkiego;Database=okazje1;timeout=0");
        static string master = String.Format("Server=master;Port=5432;User Id=automatyzacja;Password=Michal_jest_krulem_wszystkiego;Database=okazje_master;timeout=0");
        Methods methods = new Methods();
        //string lastGeneration;


        public urls()
        {
            InitializeComponent();
            // var lastGeneration = methods.conncetDatabase("select insert_date from okazje_map order by insert_date desc limit 1", master);
        }

        private void cluster_Click(object sender, EventArgs e)
        {
           

            urlsBox = methods.conncetDatabase(@"select  source_url 
                                                            from redirection 
                                                            where source_url 
                                                            LIKE '%klaster.html' and redirection_insert > '" + DateTime.Today.AddDays(-30) +
                                                             "' order by random() limit " + numberOfRecords.Value, master, urlsBox,textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select  source_url 
                                                            from redirection 
                                                            where source_url 
                                                            LIKE '%/lf/%' and redirection_insert > '" + DateTime.Today.AddDays(-30) +
                                                             "' order by random() limit " + numberOfRecords.Value, master, urlsBox, textBox1.Text);
        }

        private void frazy_Click(object sender, EventArgs e)
        {


            urlsBox = methods.conncetDatabase(@"SELECT phrase_text
                                                FROM
                                                (SELECT phrase_id,
                                                phrase_text
                                                FROM phrases p
                                                WHERE phrase_date>now()-interval '1month'
                                                AND satelite_id=0
                                                UNION SELECT phrase_original_id AS phrase_id,
                                                phrase_text
                                                FROM phrases_rejected pr
                                                WHERE phrase_date>now()-interval '1month') AS s
                                                GROUP BY s.phrase_text
                                                ORDER BY count(*) DESC limit " + numberOfRecords.Value, master,urlsBox, textBox1.Text);


        }

        private void kat_Click(object sender, EventArgs e)
        {
            // 
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro', 'okazje.info.pl') 
                                                from okazje_map 
                                                where filter is null 
                                                and producer_id = 0 
                                                and city_id = 0 
                                                and shop_id = 0 
                                                and url not like '%promocje%' 
                                                and url not like '%zakres%' 
                                                and is_ranking is false  
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro','okazje.info.pl') 
                                                from okazje_map  
                                                where  producer_id = 0 
                                                and city_id = 0 
                                                and shop_id = 0 
                                                and is_price = TRUE 
                                                and url not like '%promocje%'  
                                                and is_ranking is false  
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);
        }

        private void katShop_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro','okazje.info.pl') 
                                                from okazje_map  
                                                where  producer_id = 0 
                                                and city_id = 0 
                                                and shop_id != 0 
                                                and filter is null
                                                and is_price = FALSE
                                                and url not like '%promocje%'  
                                                and is_ranking is false  
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);

        }

        private void katCity_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro','okazje.info.pl') 
                                                from okazje_map  
                                                where  producer_id = 0 
                                                and city_id != 0 
                                                and shop_id = 0 
                                                and is_price = FALSE
                                                and filter is null
                                                and url not like '%promocje%'  
                                                and is_ranking is false  
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);
        }

        private void katProducer_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro','okazje.info.pl') 
                                                from okazje_map  
                                                where  producer_id != 0 
                                                and city_id = 0 
                                                and shop_id = 0 
                                                and filter is null
                                                and is_price = FALSE
                                                and url not like '%promocje%'  
                                                and is_ranking is false  
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);
        }

        private void mix_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro','okazje.info.pl') 
                                                from okazje_map  
                                                where is_ranking is false 
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);
        }

        private void katTech_Click(object sender, EventArgs e)
        {


            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro', 'okazje.info.pl') 
                                                from okazje_map
                                                where producer_id = 0
                                                and city_id = 0
                                                and shop_id = 0
                                                and is_price = FALSE
                                                and filter is not null
                                                and url not like '%promocje%'
                                                and is_ranking is false
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);

            
        }

        private void rankingi_Click(object sender, EventArgs e)
        {
            urlsBox = methods.conncetDatabase(@"select replace(url,'kotreba-okazjemap.okazje.biuro','okazje.info.pl') 
                                                from okazje_map  
                                                where  producer_id = 0 
                                                and city_id = 0 
                                                and shop_id = 0 
                                                and is_price = FALSE
                                                and filter is null
                                                and url not like '%promocje%'  
                                                and is_ranking is true  
                                                order by random() limit " + numberOfRecords.Value, devel, urlsBox, textBox1.Text);

        }
    }
}
