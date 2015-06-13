using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja_Hotelowa_LINQ
{
    public partial class Panel_recepcjonisty : Form
    {
        Baza_Danych_LINQDataContext dc = new Baza_Danych_LINQDataContext();
        public Panel_recepcjonisty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = (from c in dc.Pracownicies where c.login == "1" select new { c.login, c.haslo, c.poziom_uprawnien });
            dataGridView1.DataSource = data;
            
        }
        
    }
}
