using CİnemaBuyTicket.Class;
using CİnemaBuyTicket.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CİnemaBuyTicket
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();

        }

private void MainMenu_Load(object sender, EventArgs e)
{
    for (int i = 0; i < 10; i++)
    {
        Movie movie = new Movie();
        Button button = new Button();
        button.Location = new Point(45 * (i), 45 * (i + 1));
        button.Size = new Size(290, 32);
        
                
    }

}
    }
}
