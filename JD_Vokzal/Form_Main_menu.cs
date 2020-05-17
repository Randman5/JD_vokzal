using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JD_Vokzal
{
    public partial class Form_Main_menu : Form
    {
        public Form_Main_menu()
        {
            InitializeComponent();
        }
        
        //btn пассажиры
        private void BTN_The_passengers_MouseEnter(object sender, EventArgs e){ BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры2; }
        private void BTN_The_passengers_MouseLeave(object sender, EventArgs e){ BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры1; }
        private void BTN_The_passengers_MouseDown(object sender, MouseEventArgs e) { BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры3; }
        private void BTN_The_passengers_MouseUp(object sender, MouseEventArgs e) { BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры2; }
        private void BTN_The_passengers_Enter(object sender, EventArgs e){  BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры2; }
        private void BTN_The_passengers_Leave(object sender, EventArgs e){ BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры1;}
        private void BTN_The_passengers_Click(object sender, EventArgs e)
        {
            BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры3;
            //-----------------------------------------------------------------
            The_passengers passengers = new The_passengers();
            passengers.ShowDialog();
            //-----------------------------------------------------------------
            BTN_The_passengers.BackgroundImage = Properties.Resources.Пассажиры2;
        }
        //btn Составы BTN_Group_Wagons
        private void BTN_Group_Wagons_MouseEnter(object sender, EventArgs e) { BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы2; }
        private void BTN_Group_Wagons_MouseLeave(object sender, EventArgs e) { BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы1; }
        private void BTN_Group_Wagons_MouseDown(object sender, MouseEventArgs e) { BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы3; }
        private void BTN_Group_Wagons_MouseUp(object sender, MouseEventArgs e) { BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы2; }
        private void BTN_Group_Wagons_Enter(object sender, EventArgs e) { BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы2; }
        private void BTN_Group_Wagons_Leave(object sender, EventArgs e) { BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы1; }
        private void BTN_Group_Wagons_Click(object sender, EventArgs e)
        {
            BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы3;
            //-----------------------------------------------------------------
            Group_Wagons Group_Wagons = new Group_Wagons();
            Group_Wagons.ShowDialog();
            //-----------------------------------------------------------------
            BTN_Group_Wagons.BackgroundImage = Properties.Resources.Составы2;
        }
        //btn города BTN_Cities
        private void BTN_Cities_MouseEnter(object sender, EventArgs e) { BTN_Cities.BackgroundImage = Properties.Resources.Города2; }
        private void BTN_Cities_MouseLeave(object sender, EventArgs e) { BTN_Cities.BackgroundImage = Properties.Resources.Города1; }
        private void BTN_Cities_MouseDown(object sender, MouseEventArgs e) { BTN_Cities.BackgroundImage = Properties.Resources.Города3; }
        private void BTN_Cities_MouseUp(object sender, MouseEventArgs e) { BTN_Cities.BackgroundImage = Properties.Resources.Города2; }
        private void BTN_Cities_Enter(object sender, EventArgs e) { BTN_Cities.BackgroundImage = Properties.Resources.Города2; }
        private void BTN_Cities_Leave(object sender, EventArgs e) { BTN_Cities.BackgroundImage = Properties.Resources.Города1; }
        private void BTN_Cities_Click(object sender, EventArgs e)
        {
            BTN_Cities.BackgroundImage = Properties.Resources.Города3;
            //-----------------------------------------------------------------
            Cities Cities = new Cities();
            Cities.ShowDialog();
            //-----------------------------------------------------------------
            BTN_Cities.BackgroundImage = Properties.Resources.Города2;
        }
        //btn вагоны BTN_WAGONS
        private void BTN_WAGONS_MouseEnter(object sender, EventArgs e) { BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон2; }
        private void BTN_WAGONS_MouseLeave(object sender, EventArgs e) { BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон1; }
        private void BTN_WAGONS_MouseDown(object sender, MouseEventArgs e) { BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон3; }
        private void BTN_WAGONS_MouseUp(object sender, MouseEventArgs e) { BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон2; }
        private void BTN_WAGONS_Enter(object sender, EventArgs e) { BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон2; }
        private void BTN_WAGONS_Leave(object sender, EventArgs e) { BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон1; }
        private void BTN_WAGONS_Click(object sender, EventArgs e)
        {
            BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон3;
            //-----------------------------------------------------------------
            Wagons Wagons = new Wagons();
            Wagons.ShowDialog();
            //-----------------------------------------------------------------
            BTN_WAGONS.BackgroundImage = Properties.Resources.Вагон2;
        }
        //btn Рейсы BTN_Flights
        private void BTN_Flights_MouseEnter(object sender, EventArgs e) { BTN_Flights.BackgroundImage = Properties.Resources.Рейсы2; }
        private void BTN_Flights_MouseLeave(object sender, EventArgs e) { BTN_Flights.BackgroundImage = Properties.Resources.Рейсы1; }
        private void BTN_Flights_MouseDown(object sender, MouseEventArgs e) { BTN_Flights.BackgroundImage = Properties.Resources.Рейсы3; }
        private void BTN_Flights_MouseUp(object sender, MouseEventArgs e) { BTN_Flights.BackgroundImage = Properties.Resources.Рейсы2; }
        private void BTN_Flights_Enter(object sender, EventArgs e) { BTN_Flights.BackgroundImage = Properties.Resources.Рейсы2; }
        private void BTN_Flights_Leave(object sender, EventArgs e) { BTN_Flights.BackgroundImage = Properties.Resources.Рейсы1; }
        private void BTN_Flights_Click(object sender, EventArgs e)
        {
            BTN_Flights.BackgroundImage = Properties.Resources.Рейсы3;
            //-----------------------------------------------------------------
            Flights Flights = new Flights();
            Flights.ShowDialog();
            //-----------------------------------------------------------------
            BTN_Flights.BackgroundImage = Properties.Resources.Рейсы2;
        }
        //btn Билеты BTN_Tickets
        private void BTN_Tickets_MouseEnter(object sender, EventArgs e) { BTN_Tickets.BackgroundImage = Properties.Resources.Билет2; }
        private void BTN_Tickets_MouseLeave(object sender, EventArgs e) { BTN_Tickets.BackgroundImage = Properties.Resources.Билет1; }
        private void BTN_Tickets_MouseDown(object sender, MouseEventArgs e) { BTN_Tickets.BackgroundImage = Properties.Resources.Билет3; }
        private void BTN_Tickets_MouseUp(object sender, MouseEventArgs e) { BTN_Tickets.BackgroundImage = Properties.Resources.Билет2; }
        private void BTN_Tickets_Enter(object sender, EventArgs e) { BTN_Tickets.BackgroundImage = Properties.Resources.Билет2; }
        private void BTN_Tickets_Leave(object sender, EventArgs e) { BTN_Tickets.BackgroundImage = Properties.Resources.Билет1; }
        private void BTN_Tickets_Click(object sender, EventArgs e)
        {
            BTN_Tickets.BackgroundImage = Properties.Resources.Билет2;
            //-----------------------------------------------------------------
            Tickets_purchased Tickets_purchased = new Tickets_purchased();
            Tickets_purchased.ShowDialog();
            //-----------------------------------------------------------------
            BTN_Tickets.BackgroundImage = Properties.Resources.Билет3;
        }

    }
}
