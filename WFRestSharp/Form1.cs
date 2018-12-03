using ClassGeo;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRestSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSourceNoms.DataSource = RemplirDataGridNoms();
            dataGridViewNoms.DataSource = bindingSourceNoms;
        }
       

        private void bindingSourceNoms_CurrentChanged(object sender, EventArgs e)
        {
            if(bindingSourceNoms.Current!=null)
            {
                string nom = ((Pays)bindingSourceNoms.Current).Nom;
                Pays nomsPays = new Pays();
                RestClient client = new RestClient("http://user07.2isa.org/Geo.svc");
                RestRequest request = new RestRequest("Pays/{nom}", Method.GET);

                request.AddParameter("nom", nom, ParameterType.UrlSegment);

                request.AddQueryParameter("format", "json");
                IRestResponse<Pays> response = client.Execute<Pays>(request);
                if (response.ResponseStatus == ResponseStatus.Completed)
                {
                    nomsPays = response.Data;
                }
                tbNomPays.Text = nomsPays.Nom;
                tbCapitale.Text = nomsPays.Capitale;
                tbNrHabitants.Text = nomsPays.NbHabitants.ToString();
            }
        }

        public List<Pays> RemplirDataGridNoms()
        {
            List<Pays> nomsPays = new List<Pays>();
            RestClient client = new RestClient("http://user07.2isa.org/Geo.svc");
            RestRequest request = new RestRequest("Pays", Method.GET);
            request.AddQueryParameter("format", "json");
            IRestResponse<List<Pays>> response = client.Execute<List<Pays>>(request);
            if (response.ResponseStatus == ResponseStatus.Completed)
            {
                nomsPays = response.Data;
            }
            return nomsPays;
        }
    }
}
