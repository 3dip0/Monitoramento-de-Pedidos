using Microsoft.Reporting.WinForms;
using MMLib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoramento_de_Pedidos
{
    public partial class impressaoLocal : Form
    {
        public impressaoLocal(string numeroPedido, string nome, string endereco, string obs, string subTotal, string taxa, string total, string trocoPara, string trocoCliente, string formaPagamento, string formaEntrega, DataSet dataSet)
        {
            InitializeComponent();
            carrinho carrinho = new carrinho();

            TextInfo myTI = new CultureInfo("pt-BR", false).TextInfo;
            DateTime dateTime = DateTime.Now;

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("hora", myTI.ToUpper(dateTime.ToString("g"))));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("numeroPedido", myTI.ToUpper(numeroPedido)));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nome", myTI.ToUpper(nome.RemoveDiacritics())));


            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("subTotal", myTI.ToUpper(subTotal)));
            if (formaEntrega == "ENTREGA:")
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("endereco", myTI.ToUpper(endereco.RemoveDiacritics())));

                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("taxa", myTI.ToUpper(taxa)));

            }
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("endereco", myTI.ToUpper(endereco.RemoveDiacritics())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("obs", myTI.ToUpper(obs.RemoveDiacritics())));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("taxa", myTI.ToUpper(taxa)));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("total", myTI.ToUpper(total)));


            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("formaPagamento", myTI.ToUpper(formaPagamento)));
            if (myTI.ToUpper(formaPagamento) != "CARTAO")
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("trocoPara", myTI.ToUpper(trocoPara)));

                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("trocoCliente", myTI.ToUpper(trocoCliente)));
            }




            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("formEntrega", myTI.ToUpper(formaEntrega)));


            ReportDataSource rdsCarrinho = new ReportDataSource("Carrinho", dataSet.Tables[0]);

            reportViewer1.LocalReport.DataSources.Add(rdsCarrinho);




            reportViewer1.LocalReport.Refresh();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            var setup = reportViewer1.GetPageSettings();
            setup.PaperSize.Height = 500;
            setup.PaperSize.Width = 370;


            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            reportViewer1.SetPageSettings(setup);



            this.reportViewer1.RefreshReport();
        }

        private void impressaoLocal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
