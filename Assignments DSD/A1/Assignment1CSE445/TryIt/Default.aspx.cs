using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Call the service to get the Fahrenheit value
            A1Service.Service1Client farService = new A1Service.Service1Client();
            int farValue = farService.c2f(int.Parse(TextBox1.Text));

            // Display the Fahrenheit value in the Label1 control
            Label1.Text = "Temperature in Fahrenheit is " + farValue.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Call the service to get the Celsius value
            A1Service.Service1Client celService = new A1Service.Service1Client();
            int celValue = celService.f2c(int.Parse(TextBox2.Text));

            // Display the Celsius value in the Label2 control
            Label2.Text = "Temperature in Celsius is " + celValue.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Call the service to get the sorted string
            A1Service.Service1Client sortString = new A1Service.Service1Client();
            string sortStVal = sortString.sort(TextBox3.Text);

            // Display the sorted string in the Label3 control
            Label3.Text = "Sorted String: " + sortStVal;
        }
    }
}