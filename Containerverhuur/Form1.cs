using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containerverhuur
{
    public partial class Form1 : Form
    {
        private ContainerRent _newContainerRent1;
        private DateTime dateStart, dateEnd;
        private double _priceTotal, collectionCosts = 0;
        private double discount = 1;
        private int days = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _newContainerRent1 = new ContainerRent("standaard", 40, 60, 125, 0.85);

            labelSubscription1.Text = _newContainerRent1.Name;

            labelPrice1.Text = _newContainerRent1.Rent.ToString();

            labelCollect1.Text = $"{_newContainerRent1.CollectMin} {_newContainerRent1.CollectMax}";

            labelCustomer.Text = "vaste \n klant";
            // Fills labels
            //int counterContainerRentals = 0;
            //foreach (Label labelSubscription in panelSubscriptions.Controls)
            //{
            //    //if (control.GetType() == typeof(Label))
            //    labelSubscription.Text = _nweContainerRent1.Name;
            //    counterContainerRentals++;
            //}

            // Fills labels
            //int counterPrices = 0;
            //foreach (Label labelPrice in panelPrices.Controls)
            //{
            //    labelPrice.Text = _nweContainerRent1.Rent.ToString();
            //    counterPrices++;
            //}

            // Fills numericupdowns

            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year + 20;
                control.Minimum = DateTime.Today.Year;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Minimum = DateTime.Today.Month;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Minimum = DateTime.Today.Day;
                control.Value = DateTime.Today.Day;
            }

            labelTicketsTotal.Text = $@"(huur * volume * dagen + afvoerkosten) * korting";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00,-}";
        }
        
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            _priceTotal = 0; 
            collectionCosts = 0;
            discount = 1;
            days = 0;
            // Checks if the correct dates are selected (in order)
            if (ValidateDate())
            {
                days = (int)(dateEnd - dateStart).TotalDays;
                _priceTotal += _newContainerRent1.Rent * (double)numericUpDownVolume.Value * days;
                if ((double)numericUpDownVolume.Value <= 2)
                {
                    collectionCosts = _newContainerRent1.CollectMin;
                    _priceTotal += collectionCosts;
                }
                else
                {
                    collectionCosts = _newContainerRent1.CollectMax;
                    _priceTotal += collectionCosts;
                }

                if (checkBoxRegularCustomer.Checked)
                {
                    discount = _newContainerRent1.Discount;
                    _priceTotal *= discount;
                }

                // Displays costs/ charges, car fuel costs not yet implemented
                labelTicketsTotal.Text = $@"(huur € {_newContainerRent1.Rent},- * volume {numericUpDownVolume.Value} m3 * dagen {days} + afvoerkosten € {collectionCosts},-) * korting {(1-discount)*100}%";
                labelPriceTotal.Text = $@"Totaal: € {_priceTotal:0.00},-";
            }
        }

        private bool ValidateDate()
        {
            int checkDay1 = DateTime.DaysInMonth((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value);
            int checkDay2 = DateTime.DaysInMonth((int)numericUpDownYear2.Value, (int)numericUpDownMonth2.Value);
            
            if ((int)numericUpDownDay1.Value <= checkDay1 && (int)numericUpDownDay2.Value <= checkDay2)
            {
                dateStart = new DateTime((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value, (int)numericUpDownDay1.Value);
                dateEnd = new DateTime((int)numericUpDownYear2.Value, (int)numericUpDownMonth2.Value, (int)numericUpDownDay2.Value);
                if (dateStart < dateEnd)
                {
                    
                    return true;
                }
                else
                {
                    MessageBox.Show($"Please fill the dates in the correct order \nstart date < end date");
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show($@"Please select the correct day of the month");
                return false;
            }
        }
    }
}
