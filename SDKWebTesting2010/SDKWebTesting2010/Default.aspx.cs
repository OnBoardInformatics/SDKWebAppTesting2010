using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Us.Onboardis.Demo2.OnboardInformatics;
using Us.Onboardis.Demo2.OnboardInformatics.Api;

namespace SDKWebTesting2010
{
    public partial class _Default : System.Web.UI.Page
    {
        private string stringResponse;

        protected void Page_Load(object sender, EventArgs e)
        {
            LabelTesting.Text = "Calling endpoint: summaries";
            testSummariesProperties();
        }

        public void testSummariesProperties()
        {
            String point = "-75.576834";  // Point
            String radius = "10";  // Radius
            String unit = "mi";  // Unit
            String page = "1";  // Page
            String size = "30";  // Size
            String filter = "absenteeOwner eq OWNER OCCUPIED";  // Filter

            try
            {
                // first arguemnt 'basePath' is optional
                PropertiesApi propertiesApi = new PropertiesApi("http://demo2.onboardis.us");
                stringResponse = propertiesApi.Summaries(point, radius, unit, page, size, filter);

                LabelTesting02.Text = stringResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
