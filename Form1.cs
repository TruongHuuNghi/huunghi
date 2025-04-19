using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace asm2
{
    public partial class Form1 : Form
    {
        // khai bao cac mang luu tru cac thong tin cua cac khach hang
        string[] names = new string[100];
        int[] types = new int[100];
        double[] lastMonths = new double[100];
        double[] thisMonths = new double[100];
        int[] numberPeoples = new int[100];
        double[] usages = new double[100];
        double[] totalCost = new double[100];
        // khai bao bien lu tru so luong bills hien co
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Display()
        {
            dgv.DataSource = null;
            var bills = new DataTable();
            bills.Columns.Add("Name");
            bills.Columns.Add("Last Month");
            bills.Columns.Add("This Month");
            bills.Columns.Add("Usage");
            bills.Columns.Add("Total Cost");
            for (int i = 0; i < n; i++)
            {
                bills.Rows.Add(names[i], lastMonths[i], thisMonths[i], usages[i], totalCost[i]);
            }
            dgv.DataSource = bills;
            dgv.Refresh();
        }
        private void ClearData()
        {
            txtNameofcustomer.Text = "";
            txtWaterMeterLastmonth.Clear();
            txtWaterMeterThisMonth.Clear();
            txtNumberofpeople.Clear();
            cbTypeofcustomer.Text = "";
            txtSeachbyofcustomer.Clear();
            Display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTypeofcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = cbTypeofcustomer.SelectedIndex;
            if (selectIndex ==0)
            {
                lbNumberofpeople.Visible = true;
                txtNumberofpeople.Visible=true;

            }
            else
            {
                lbNumberofpeople.Visible = false;
                txtNumberofpeople.Visible = false;
            }
        }
        private double getPriceUnit(int customerType, double usageTotal)
        {
            double priceUnit = 0;
            if (customerType == 0)
            {
                int NumberPeople = int.Parse(txtNumberofpeople.Text);
                double avg = usageTotal / NumberPeople;
                if (avg <= 10)
                {
                    priceUnit = 1;
                }
                else if (avg <= 20)
                {
                    priceUnit = 2;
                }
                else if (avg <= 30)
                {
                    priceUnit = 3;
                }
                else
                {
                    priceUnit = 4;
                }
            }
            else if ( customerType == 1)
            {
                priceUnit=5;
            }
            else if( customerType == 2)
            {
                priceUnit=6;
            }
            else if(customerType == 3)
            {
                priceUnit=7;
            }
            return priceUnit;
        }

        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            string customerName = txtNameofcustomer.Text;
            double waterMeterLastMonth = double.Parse(txtWaterMeterLastmonth.Text);
            double waterMeterThisMonth = double.Parse(txtWaterMeterThisMonth.Text);
            int customerTypes = cbTypeofcustomer.SelectedIndex;
            double usageTotal = waterMeterThisMonth - waterMeterLastMonth;
            double priceUnit = getPriceUnit(customerTypes, usageTotal);
            double totalBill = priceUnit * usageTotal * 1.1;
            MessageBox.Show("Customer name: " + customerName + "\n" + "Usage: " + usageTotal + "m3" + "\n" + "Bill: " + totalBill + "vnd");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string customername = txtNameofcustomer.Text;
            double warterMeterLastMonth = double.Parse(txtWaterMeterLastmonth.Text);
            double warterMeterThisMonth = double.Parse(txtWaterMeterThisMonth.Text);
            int customerType = cbTypeofcustomer.SelectedIndex;
            double usageTotal = warterMeterThisMonth - warterMeterLastMonth;
            double priceUnit = getPriceUnit(customerType, usageTotal);
            double totalBill = priceUnit * usageTotal * 1.1;
            names[n] = customername;
            types[n] = customerType;
            lastMonths[n] = warterMeterLastMonth;
            thisMonths[n] = warterMeterThisMonth;
            numberPeoples[n] = (customerType == 0) ? int.Parse(txtNumberofpeople.Text) : 0;
            usages[n] = usageTotal;
            n++;
            Display();
            MessageBox.Show("Save successfully!");

        }
    }
}
