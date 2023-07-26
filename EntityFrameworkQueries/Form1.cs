using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new ApContext();

            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList();
        }

        private void btnAllCAVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new ApContext();

            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorName)
                                        .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {

            ApContext dbContext = new();
            //Anonymous type
            List<VendorLocation> results = (from v in dbContext.Vendors
                                            select new VendorLocation
                                            {
                                                VendorName = v.VendorName,
                                                VendorCity = v.VendorCity,
                                                VendorState = v.VendorState
                                            }).ToList();

            StringBuilder displayString = new();
            foreach (VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }
            MessageBox.Show(displayString.ToString());

        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();

            //Check if something exists
            bool doesExist = (from v in dbContext.Vendors
                              where v.VendorState == "WA"
                              select v).Any();

            //Get number of Invoices
            int invoiceCount = (from i in dbContext.Invoices
                                select i).Count();

            //query a single vendor
            Vendor? singleVendor = (from v in dbContext.Vendors
                          where v.VendorName == "IBM"
                          select v).SingleOrDefault();
            if (singleVendor != null)
            {
                //do something with vendor
            }
        }
    }

    class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorState { get; set; }

        public string VendorCity { get; set; }
    }
}